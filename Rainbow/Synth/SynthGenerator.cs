using Jacobi.Vst.Core;
using Rainbow.UI;
using Rainbow.Wave;
using System;
using System.Collections.Generic;

namespace Rainbow.Synth
{
    class SynthGenerator
    {
        WaveInfo waveInfo = new WaveInfo();
        private int samplesPerSecond = 44100;
        private int bitsPerSample = 32;
        private double repeatBegin = 0.05;
        private double repeatEnd = 0.4;
        private List<Note> notes = new List<Note>();
        private float effectOne = 0;
        public const int SHAPE_NUMPOINTS = 1000;
        public const int SHAPE_MAX_VALUE = 500;

        internal WaveInfo WaveInfo { get => waveInfo; set => waveInfo = value; }
        internal FormMain? MainView { get; set; }
        public double RepeatBegin { get => repeatBegin; set => repeatBegin = value; }
        public double RepeatEnd { get => repeatEnd; set => repeatEnd = value; }
        internal List<Note> Notes { get => notes; set => notes = value; }
        public float EffectOne { get => effectOne; set => effectOne = value; }

        public SynthGenerator()
        {
        }

        public void Initialize()
        {
            waveInfo.ShapeVolume = new int[SHAPE_NUMPOINTS];
            for(int k=0; k<SHAPE_NUMPOINTS; k++)
            {
                waveInfo.ShapeVolume[k] = SHAPE_MAX_VALUE;
            }
        }

        public void NoteOff(byte tone)
        {
            var note = Notes.Find(x => x.Tone.Equals(tone));
            if (note != null)
            {
                note.Active = false;
            }
        }

        public void NoteOn(byte tone, byte velocity)
        {
            Note note = new Note(tone, velocity);
            Notes.Add(note);
        }

        public void LoadWaveFile(string dataFolder, string wavefileName)
        {
            WaveInfo.WaveFileName = dataFolder + "\\wavefiles\\" + wavefileName + ".wav";
            float[] leftChannel = null, rightChannel = null;
            WaveFile.LoadFromDisk(waveInfo, samplesPerSecond, ref leftChannel, ref rightChannel);
            waveInfo.WaveFileDataLeft = leftChannel;
            waveInfo.WaveFileDataLeft = rightChannel;
        }

        public void LoadSecondaryWaveFile(string dataFolder, string wavefileName)
        {
            WaveInfo.WaveFileName = dataFolder + "\\wavefiles\\" + wavefileName + ".wav";
            float[] leftChannel = null, rightChannel = null;
            if (wavefileName.Equals("[None]"))
            {
                waveInfo.WaveFileSecondaryLeft = null;
                waveInfo.WaveFileSecondaryRight = null;
            }
            else
            {
                WaveFile.LoadFromDisk(waveInfo, samplesPerSecond, ref leftChannel, ref rightChannel);
                waveInfo.WaveFileSecondaryLeft = leftChannel;
                waveInfo.WaveFileSecondaryRight = rightChannel;
            }
        }

        public void SaveAsWaveFile()
        {
            WaveFile.SaveToDisk(WaveInfo, samplesPerSecond, bitsPerSample);
        }

        // call when Preset settings changed (but when .wav files change, call LoadWaveFile first)
        public void UpdateEffects()
        {
            WaveInfo.WaveDataLeft = UpdateEffects(WaveInfo.WaveFileDataLeft, WaveInfo.WaveFileSecondaryLeft);
            WaveInfo.WaveDataRight = UpdateEffects(WaveInfo.WaveFileDataRight, WaveInfo.WaveFileSecondaryRight);
        }

        public float[] UpdateEffects(float[] sourceData, float[] sourceDataSecondary)
        {
            if (sourceDataSecondary!=null)
            {
                float[] mixedData = new float[Math.Max(sourceData.Length, sourceDataSecondary.Length)];
                for (long k=0; k<mixedData.Length; k++)
                {
                    float percentageComplete = k / (float)mixedData.Length;
                    mixedData[k] = 0;
                    if (k < sourceData.Length-1)
                    {
                        mixedData[k] = sourceData[k] * (1-percentageComplete);
                    }
                    if (k >= mixedData.Length - sourceDataSecondary.Length)
                    {
                        mixedData[k] += sourceDataSecondary[k - mixedData.Length + sourceDataSecondary.Length] * percentageComplete;
                    }
                }

                sourceData = mixedData;     // replace by mixed sound
            }

            float[] destData = new float[sourceData.Length];

            for (int numSample = 0; numSample<sourceData.Length; numSample++)
            {
                float effectOneValue = numSample % effectOne;

                if (effectOne!=0)
                {
                    destData[numSample] = (float)(sourceData[numSample] * (1 + effectOneValue / effectOne));
                }
                else
                {
                    destData[numSample] = sourceData[numSample];
                }
            }

            ApplyVolume(destData);
            Normalize(destData);

            return destData;
        }

        private void ApplyVolume(float[] waveData)
        {
            for (int numSample = 0; numSample < waveData.Length; numSample++)
            {
                int currentPosition = (int)(SHAPE_NUMPOINTS * numSample / (float)waveData.Length);
                if(currentPosition<0 || currentPosition>=SHAPE_NUMPOINTS)
                {
                    int pp = 0;
                }
                else
                {
                    waveData[numSample] = waveData[numSample] * waveInfo.ShapeVolume[currentPosition] / (float)SHAPE_MAX_VALUE;
                }
            }
        }

        private void Normalize(float[] waveData)
        {
            float lowerBand = float.MaxValue, upperBand = float.MinValue;
            for (int numSample = 0; numSample < waveData.Length; numSample++)
            {
                if (waveData[numSample] < lowerBand)
                {
                    lowerBand = waveData[numSample];
                }
                if (waveData[numSample] > upperBand)
                {
                    upperBand = waveData[numSample];
                }
            }
            float range = upperBand - lowerBand;
            float scaleFactor = 2 / range;
            float adjustValue = -1 - (lowerBand * scaleFactor);       // adjustValue + (lowerband * scaleFactor) must be -1, so adjustValue = -1 - (lowerband * scaleFactor)
            for (int numSample = 0; numSample < waveData.Length; numSample++)
            {
                waveData[numSample] = waveData[numSample] * scaleFactor + adjustValue;
            }
        }
        

        public void Play(VstAudioBuffer[] vstAudioBuffers)
        {
            for (int k = 0; k < vstAudioBuffers[0].SampleCount; k++)
            {
                double tempDataLeft = 0;
                double tempDataRight = 0;
                int totalVelocity = 0;
                int highestVelocity = 0;
                for (int i=0; i<Notes.Count; i++)
                {
                    Note note = Notes[i];
                    if (note.Velocity > highestVelocity)
                    {
                        highestVelocity = note.Velocity;
                    }
                    note.PlayPosition += note.FrequencyFactor;
                    if (note.PlayPosition > WaveInfo.WaveDataLeft.Length * repeatEnd && note.Active)
                    {
                        note.PlayPosition = WaveInfo.WaveDataLeft.Length * repeatBegin;
//                        System.Diagnostics.Debug.WriteLine("rewind:" + note.Tone);
                    }
                    int position = (int)note.PlayPosition;
                    if (position >= WaveInfo.WaveFileDataLeft.Length)
                    {
                        Notes.RemoveAll(r => r.Tone == note.Tone);
                    }
                    else
                    {
                        tempDataLeft += Convert.ToDouble(WaveInfo.WaveDataLeft[position]) * note.Velocity;
                        tempDataRight += Convert.ToDouble(WaveInfo.WaveDataLeft[position]) * note.Velocity;
                        totalVelocity += note.Velocity;
                    }
                }

                if (totalVelocity > 0)
                {
                    float finalDataLeft = (float)((tempDataLeft / totalVelocity) * (highestVelocity / 127.0));
                    float finalDataRight = (float)((tempDataRight / totalVelocity) * (highestVelocity / 127.0));

                    vstAudioBuffers[0][k] = finalDataLeft;
                    vstAudioBuffers[1][k] = finalDataRight;
                }
                else 
                {
                    vstAudioBuffers[0][k] = 0;
                    vstAudioBuffers[1][k] = 0;
                }
            }
        }

    }
}
