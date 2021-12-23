using Jacobi.Vst.Core;
using Rainbow.UI;
using Rainbow.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;

namespace Rainbow.Synth
{
    class SynthGenerator
    {
        WaveInfo waveInfo = new WaveInfo();
        private int samplesPerSecondInternal = 44100;
        private int samplesPerSecondOutput = 44100;
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
        private int numMixWaves = 1; 
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
        public int NumMixWaves { get => numMixWaves; set => numMixWaves = value; }
        public int BitsPerSample { get => bitsPerSample; set => bitsPerSample = value; }
        public int SamplesPerSecondOutput { get => samplesPerSecondOutput; set => samplesPerSecondOutput = value; }

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

        public void LoadWaveFile(string wavefileName, int soundNumber)
        {
            WaveFile.LoadFromDisk(wavefileName, waveInfo, samplesPerSecondInternal, soundNumber);
        }

        // call when Preset settings changed (but when .wav files change, call LoadWaveFile first)
        public void UpdateEffects()
        {
            WaveInfo.WaveDataLeft = ProcessSound(WaveInfo.WaveFileData1Left, WaveInfo.WaveFileData2Left);
            WaveInfo.WaveDataRight = ProcessSound(WaveInfo.WaveFileData1Right, WaveInfo.WaveFileData2Right);
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
            if (stretchMode==0)   // overlapping
            {
                soundBufferSize = Math.Max(WaveInfo.WaveFileData1Left.Length, WaveInfo.WaveFileData2Left.Length);
            }
            else if (stretchMode == 1)      // Repeat smallest
            {
                soundBufferSize = Math.Max(WaveInfo.WaveFileData1Left.Length, WaveInfo.WaveFileData2Left.Length);
            }
            else if (stretchMode == 2)      // Stretch to Largest
            {
                soundBufferSize = Math.Max(WaveInfo.WaveFileData1Left.Length, WaveInfo.WaveFileData2Left.Length);
            }
            else   // Shrink to Smallest
            {
                soundBufferSize = Math.Min(WaveInfo.WaveFileData1Left.Length, WaveInfo.WaveFileData2Left.Length);
            }
            float seconds = soundBufferSize / (float)samplesPerSecondInternal;
            duration = seconds;
            maxDuration = duration * 3;
            UpdateEffects();
        }

        // resize the soundbuffers
        private void ApplyStretch(ref float[] sourceData1, ref float[] sourceData2)
        {
            if (stretchMode == 0)   // overlap
            {
                if (sourceData1.Length>sourceData2.Length)
                {
                    float[] newBuffer = new float[sourceData1.Length];
                    // Fill sourceData2 with leading zeroes
                    for (int k=0; k<newBuffer.Length; k++)
                    {
                        if (k < sourceData1.Length - sourceData2.Length)
                        {
                            newBuffer[k] = 0;
                        }
                        else
                        {
                            newBuffer[k] = sourceData2[k - sourceData1.Length + sourceData2.Length];
                        }
                    }
                    sourceData2 = newBuffer;
                }
                else
                {
                    float[] newBuffer = new float[sourceData2.Length];
                    // Fill sourceData1 with trailing zeroes
                    for (int k = 0; k < newBuffer.Length; k++)
                    {
                        if (k < sourceData1.Length)
                        {
                            newBuffer[k] = sourceData1[k];
                        }
                        else
                        {
                            newBuffer[k] = 0;
                        }
                    }
                    sourceData1 = newBuffer;
                }
            }
            if (stretchMode == 1)   // repeat smallest
            {
                if (sourceData1.Length > sourceData2.Length)
                {
                    float[] newBuffer = new float[sourceData1.Length];
                    for (int k = 0; k < newBuffer.Length; k++)
                    {
                        newBuffer[k] = sourceData2[k % sourceData2.Length];
                    }
                    sourceData2 = newBuffer;
                }
                else
                {
                    float[] newBuffer = new float[sourceData2.Length];
                    for (int k = 0; k < newBuffer.Length; k++)
                    {
                        newBuffer[k] = sourceData1[k % sourceData1.Length];
                    }
                    sourceData1 = newBuffer;
                }
            }
            if (stretchMode == 2)   // stretch to largest
            {
                if (sourceData1.Length > sourceData2.Length)
                {
                    float[] newBuffer = new float[sourceData1.Length];
                    for (int k = 0; k < newBuffer.Length; k++)
                    {
                        float percentageComplete = k/(float)newBuffer.Length;
                        newBuffer[k] = sourceData2[(int)(percentageComplete * sourceData2.Length)];
                    }
                    sourceData2 = newBuffer;
                }
                else 
                {
                    float[] newBuffer = new float[sourceData2.Length];
                    for (int k = 0; k < newBuffer.Length; k++)
                    {
                        float percentageComplete = k / (float)newBuffer.Length;
                        newBuffer[k] = sourceData1[(int)(percentageComplete * sourceData1.Length)];
                    }
                    sourceData1 = newBuffer;
                }
            }
            if (stretchMode == 3)   // shrink to smallest
            {
                if (sourceData1.Length > sourceData2.Length)
                {
                    float[] newBuffer = new float[sourceData2.Length];
                    for (int k = 0; k < newBuffer.Length; k++)
                    {
                        float shrinkFactor = sourceData1.Length / (float)sourceData2.Length;
                        newBuffer[k] = sourceData1[(int)(k * shrinkFactor)];
                    }
                    sourceData1 = newBuffer;
                }
                else
                {
                    float[] newBuffer = new float[sourceData1.Length];
                    for (int k = 0; k < newBuffer.Length; k++)
                    {
                        float shrinkFactor = sourceData2.Length / (float)sourceData1.Length;
                        newBuffer[k] = sourceData2[(int)(k * shrinkFactor)];
                    }
                    sourceData2 = newBuffer;
                }
            }
        }

        private float ApplyMix(float percentageComplete, float soundData1, float soundData2)
        {
            if (MixMode == 0)   // Fade in - Fade out
            {
                return soundData1 * (1 - percentageComplete) + soundData2 * percentageComplete;
            } else if(MixMode == 1)   // Both same weight
            {
                return soundData1 + soundData2;
            }
            else if(MixMode == 2)   // Multiply 1 by 2
            {
                return soundData1 * soundData2;
            } 
            else if(MixMode == 3)   // Alternate Square
            {
                float value = 0;
                if (percentageComplete % (1/(float)numMixWaves) <= 1 / ((float)numMixWaves*2))
                {
                    value += soundData1;
                }
                else
                {
                    value += soundData2;
                }
                return value;
            }
            else if(MixMode == 4)   // Alternate Triangle
            {
                float value = 0;
                float currentPhase = percentageComplete % (1 / (float)numMixWaves) * numMixWaves;
                value += (1-currentPhase) * soundData1;
                value += currentPhase * soundData2;
                return value;
            }
            else   // Alternate Sine
            {
                double value = 0;
                float currentPhase = percentageComplete % (1 / (float)numMixWaves) * numMixWaves;
                value += Math.Cos(currentPhase * Math.PI) * soundData1;
                value += Math.Sin(currentPhase * Math.PI) * soundData2;
                return (float)value;
            }

        }

    public float[] ProcessSound(float[] sourceData1, float[] sourceData2)
        {
            float[] tempData1 = ApplyVolume(sourceData1, waveInfo.ShapeVolume1);
            if (WaveInfo.Inverted1)
            {
                tempData1 = InvertSound(tempData1);
            }

            float[] tempData2 = ApplyVolume(sourceData2, waveInfo.ShapeVolume2);
            if (WaveInfo.Inverted2)
            {
                tempData2 = InvertSound(tempData2);
            }

            ApplyStretch(ref tempData1, ref tempData2);

            if(soundBufferSize==0)
            {
                return null;
            }

            float[] mixedData = new float[soundBufferSize];
            for (long k=0; k<soundBufferSize; k++)
            {
                mixedData[k] = 0;
                float percentageComplete = k / (float)mixedData.Length;

                mixedData[k] += ApplyMix(percentageComplete, tempData1[k], tempData2[k]);
            }

            mixedData = ApplyDuration(mixedData);

            Normalize(mixedData);

            return mixedData;
        }

        private float[] ApplyDuration(float[] sourceData)
        {
            float[] destData = new float[(int)(duration * samplesPerSecondInternal)];
            for (long k=0; k<destData.Length; k++)
            {
                float percentageComplete = k / (float)destData.Length;
                int position = (int)(percentageComplete * sourceData.Length);
                destData[k] = sourceData[position];
            }

            return destData;
        }

        private float[] ApplyVolume(float[] waveData, int[] shapeVolume)
        {
            float[] destData = new float[waveData.Length];
            for (int numSample = 0; numSample < waveData.Length; numSample++)
            {
                int currentPosition = (int)(SHAPE_NUMPOINTS * numSample / (float)waveData.Length);
                if(currentPosition<0 || currentPosition>=SHAPE_NUMPOINTS)
                {
                    int pp = 0;
                }
                else
                {
                    destData[numSample] = waveData[numSample] * shapeVolume[currentPosition] / (float)SHAPE_MAX_VALUE;
                }
            }

            return destData;
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
                    if (position >= WaveInfo.WaveDataLeft.Length)
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

        private void WriteWaveData(BinaryWriter writer, WaveDataChunk data)
        {
            // Write the header
            writer.Write("RIFF".ToCharArray());
            writer.Write(36 + data.dwChunkSize);
            writer.Write("WAVE".ToCharArray());

            // Write the format chunk
            writer.Write("fmt ".ToCharArray());     // chunk id
            writer.Write((uint)16);                       // chunk size
            writer.Write((ushort)1);                        // format tag (PCM=1)
            writer.Write((ushort)2);                        // channels
            writer.Write((uint)SamplesPerSecondOutput);         // samplerate
            writer.Write((uint)(SamplesPerSecondOutput * 2 * BitsPerSample / 8));        // byte rate
            writer.Write((ushort)(2 * BitsPerSample / 8));        // block align (samplesPerSecond * wChannels * (wBitsPerSample / 8)
            writer.Write((ushort)BitsPerSample);            // bits per sample

            // Write the data chunk
            writer.Write(data.sChunkID.ToCharArray());
            writer.Write(data.dwChunkSize);

            foreach (int dataPoint in data.audioData)
            {
                if (BitsPerSample == 32)
                {
                    writer.Write(dataPoint);
                }
                else
                {
                    writer.Write((short)dataPoint);
                }
            }
        }

        // Converts the WaveData -1..1 floats to values of 
        private WaveDataChunk ConvertToFileData()
        {
            WaveDataChunk waveDataChunk = new WaveDataChunk();
            waveDataChunk.audioData = new int[WaveInfo.WaveDataLeft.Length*2];
            waveDataChunk.dwChunkSize = (uint)(waveDataChunk.audioData.Length * (bitsPerSample / 8));

            for (int sampleNumber=0; sampleNumber<WaveInfo.WaveDataLeft.Length; sampleNumber++)
            {
                waveDataChunk.audioData[sampleNumber * 2] = (int)(WaveInfo.WaveDataLeft[sampleNumber] * 32768);
                waveDataChunk.audioData[sampleNumber * 2 + 1] = (int)(WaveInfo.WaveDataRight[sampleNumber] * 32768);

                if (BitsPerSample == 32)
                {
                    waveDataChunk.audioData[sampleNumber * 2] *= 65536;
                    waveDataChunk.audioData[sampleNumber * 2 + 1] *= 65536;
                }
            }

            return waveDataChunk;
        }

        public void Save(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                WriteWaveData(writer, ConvertToFileData());

                writer.Seek(4, SeekOrigin.Begin);
                uint filesize = (uint)writer.BaseStream.Length;
                writer.Write(filesize - 8);
            }
        }

        public void Play()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(memoryStream))
            {
                WriteWaveData(writer, ConvertToFileData());

                memoryStream.Position = 0;
                new SoundPlayer(memoryStream).Play();
            }
        }
    }
}
