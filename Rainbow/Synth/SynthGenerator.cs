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
        private double duration = 3.4;
        private double maxDuration = 10.0;
        private List<Note> notes = new List<Note>();
        private float effectOne = 0;
        public const int SHAPE_NUMPOINTS = 1000;
        public const int SHAPE_MAX_VALUE = 500;
        private int mixMode;
        private int stretchMode;
        private int soundBufferSize;

        internal WaveInfo WaveInfo { get => waveInfo; set => waveInfo = value; }
        internal FormMain? MainView { get; set; }
        public double RepeatBegin { get => repeatBegin; set => repeatBegin = value; }
        public double RepeatEnd { get => repeatEnd; set => repeatEnd = value; }
        internal List<Note> Notes { get => notes; set => notes = value; }
        public float EffectOne { get => effectOne; set => effectOne = value; }
        public int MixMode { get => mixMode; set => mixMode = value; }
        public int StretchMode { get => stretchMode; set => stretchMode = value; }
        public double Duration { get => duration; set => duration = value; }
        public double MaxDuration { get => maxDuration; set => maxDuration = value; }

        public SynthGenerator()
        {
        }

        public void Initialize()
        {
            waveInfo.ShapeVolume1 = new int[SHAPE_NUMPOINTS];
            for(int k=0; k<SHAPE_NUMPOINTS; k++)
            {
                waveInfo.ShapeVolume1[k] = SHAPE_MAX_VALUE;
            }
            waveInfo.ShapeVolume2 = new int[SHAPE_NUMPOINTS];
            for (int k = 0; k < SHAPE_NUMPOINTS; k++)
            {
                waveInfo.ShapeVolume2[k] = SHAPE_MAX_VALUE;
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

        public void LoadWaveFile(string wavefileName)
        {
            WaveInfo.WaveFileName = wavefileName;
            float[] leftChannel = null, rightChannel = null;
            WaveFile.LoadFromDisk(waveInfo, samplesPerSecond, ref leftChannel, ref rightChannel);
            waveInfo.WaveFileDataLeft = leftChannel;
            waveInfo.WaveFileDataLeft = rightChannel;
        }


        public void LoadSecondaryWaveFile(string wavefileName)
        {
            WaveInfo.WaveFileName = wavefileName;
            float[] leftChannel = null, rightChannel = null;
            if (wavefileName.Equals("[None]"))
            {
                waveInfo.WaveFileSecondaryLeft = Array.Empty<float>();
                waveInfo.WaveFileSecondaryRight = Array.Empty<float>();
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

        private float[] InvertSound(float[] soundData)
        {
            float[] inverted = new float[soundData.Length];
            for(int i = 0; i < soundData.Length; i++)
            {
                inverted[i] = soundData[soundData.Length - 1 - i];
            }

            return inverted;
        }

        public void UpdateSoundBufferSize()
        {
            if(stretchMode==0)
            {
                soundBufferSize = Math.Max(WaveInfo.WaveFileDataLeft.Length, WaveInfo.WaveFileSecondaryLeft.Length);
            }
            else if(stretchMode == 2)
            {
                soundBufferSize = Math.Max(WaveInfo.WaveFileDataLeft.Length, WaveInfo.WaveFileSecondaryLeft.Length);
                // TODO : stretch smallest sound
            }
            else
            {
                soundBufferSize = Math.Min(WaveInfo.WaveFileDataLeft.Length, WaveInfo.WaveFileSecondaryLeft.Length);
                // TODO : shrink largest sound
            }
            float seconds = soundBufferSize / (float)samplesPerSecond;
            duration = seconds;
            maxDuration = duration * 3;
        }

        public float[] UpdateEffects(float[] sourceData, float[] sourceDataSecondary)
        {
            ApplyVolume(sourceData, waveInfo.ShapeVolume1);
            if (WaveInfo.Inverted1)
            {
                sourceData = InvertSound(sourceData);
            }

            if (sourceDataSecondary!=null)
            {
                ApplyVolume(sourceDataSecondary, waveInfo.ShapeVolume2);
                if (WaveInfo.Inverted2)
                {
                    sourceDataSecondary = InvertSound(sourceDataSecondary);
                }

                float[] mixedData = new float[soundBufferSize];
                for (long k=0; k<soundBufferSize; k++)
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

            Normalize(sourceData);

            return sourceData;
        }

        private void ApplyVolume(float[] waveData, int[] shapeVolume)
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
                    waveData[numSample] = waveData[numSample] * shapeVolume[currentPosition] / (float)SHAPE_MAX_VALUE;
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
