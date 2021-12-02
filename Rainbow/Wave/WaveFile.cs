using NAudio.Wave;
using Rainbow.Synth;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Wave
{
    class WaveFile
    {
        public static void WriteWaveData(BinaryWriter writer, WaveInfo waveInfo, int samplesPerSecond, int bitsPerSample)
        {
            WaveDataChunk waveExportData = new WaveDataChunk();     // data that can be saved as .wav.
            WaveHeader header = new WaveHeader();

            // Write the header
            writer.Write(header.sGroupID.ToCharArray());
            writer.Write(header.dwFileLength);
            writer.Write(header.sRiffType.ToCharArray());

            // Write the format chunk
            writer.Write("fmt ".ToCharArray());     // chunk id
            writer.Write((uint)16);                       // chunk size
            writer.Write((ushort)1);                        // format tag (PCM=1)
            writer.Write((ushort)2);                        // channels
            writer.Write((uint)samplesPerSecond);         // samplerate
            writer.Write((uint)(samplesPerSecond * 2 * bitsPerSample / 8));        // byte rate
            writer.Write((ushort)(2 * bitsPerSample / 8));        // block align (samplesPerSecond * wChannels * (wBitsPerSample / 8)
            writer.Write((ushort)bitsPerSample);            // bits per sample

            // Convert synth data to wav format (interleaved)
            waveExportData.audioData = new int[waveInfo.WaveFileDataLeft.Length*2];
            for (int i = 0; i < waveInfo.WaveFileDataLeft.Length; i++)
            {
                if (bitsPerSample == 32)
                {
                    waveExportData.audioData[i * 2] = (int)(waveInfo.WaveFileDataLeft[i] * 65536);
                    waveExportData.audioData[i * 2 + 1] = (int)(waveInfo.WaveFileDataRight[i] * 65536);
                }
                else
                {
                    waveExportData.audioData[i * 2] = (int)waveInfo.WaveFileDataLeft[i];
                    waveExportData.audioData[i * 2 + 1] = (int)waveInfo.WaveFileDataRight[i];
                }
            }

            waveExportData.dwChunkSize = (uint)(waveExportData.audioData.Length * (bitsPerSample / 8));
            header.dwFileLength = 36 + waveExportData.dwChunkSize;


            // Write the data chunk
            writer.Write(waveExportData.sChunkID.ToCharArray());
            writer.Write(waveExportData.dwChunkSize);

            foreach (int dataPoint in waveExportData.audioData)
            {
                if (bitsPerSample == 32)
                {
                    writer.Write(dataPoint);
                }
                else
                {
                    writer.Write((short)dataPoint);
                }
            }
        }

        public static void SaveToDisk(WaveInfo waveInfo, int samplesPerSecond, int bitsPerSample)
        {
            using (FileStream fileStream = new FileStream(waveInfo.WaveFileName, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                WriteWaveData(writer, waveInfo, samplesPerSecond, bitsPerSample);

                writer.Seek(4, SeekOrigin.Begin);
                uint filesize = (uint)writer.BaseStream.Length;
                writer.Write(filesize - 8);

            }
        }

        // load a .wav file. Supported is PCM, mono/stereo, 8/16/24 bits, all samplerates.
        // loaded file is transformed into a 44100 Kz 16 bits stereo stream. 
        // if the source is mono, the data is copied to both streams
        public static void LoadFromDisk(WaveInfo waveInfo, int samplesPerSecond, ref float[] leftChannel, ref float[] rightChannel)
        {
            using (WaveFileReader reader = new WaveFileReader(waveInfo.WaveFileName))
            {
                byte[] buffer = new byte[reader.Length];
                int read = reader.Read(buffer, 0, buffer.Length);
                double sampleRatio = samplesPerSecond / (double)reader.WaveFormat.SampleRate;
                int numSamplesDestination = (int)(reader.SampleCount * sampleRatio);       // number of samples in final result (44100 * duration in s)
                leftChannel = new float[numSamplesDestination];            // output=2 channels
                rightChannel = new float[numSamplesDestination];            // output=2 channels

                for (int destSampleNumber = 0; destSampleNumber < numSamplesDestination; destSampleNumber++)
                {
                    if (reader.WaveFormat.BitsPerSample == 8)
                    {
                        int position = reader.WaveFormat.Channels * (int)(destSampleNumber / sampleRatio);
                        leftChannel[destSampleNumber] = (short)((buffer[position] - 128) * 256);
                        if (reader.WaveFormat.Channels == 2)
                        {
                            rightChannel[destSampleNumber] = (short)((buffer[position + 1] - 128) * 256);
                        }
                        else
                        {
                            // use data of first channel for right channel
                            rightChannel[destSampleNumber] = (short)((buffer[position] - 128) * 256);
                        }
                    }
                    else if(reader.WaveFormat.BitsPerSample == 16)
                    // 16-bits audio
                    {
                        int positionInReadBuffer = 2 * reader.WaveFormat.Channels * (int)(destSampleNumber / sampleRatio);
                        leftChannel[destSampleNumber] = (float)(BitConverter.ToInt16(new byte[2] { buffer[positionInReadBuffer], buffer[positionInReadBuffer + 1] }, 0) / 32768.0);
                        if (reader.WaveFormat.Channels == 2)
                        {
                            rightChannel[destSampleNumber] = (float)(BitConverter.ToInt16(new byte[2] { buffer[positionInReadBuffer + 2], buffer[positionInReadBuffer + 3] }, 0) / 32768.0);
                        }
                        else
                        {
                            // use data of first channel for right channel
                            rightChannel[destSampleNumber] = (float)(BitConverter.ToInt16(new byte[2] { buffer[positionInReadBuffer], buffer[positionInReadBuffer + 1] }, 0) / 32768.0);
                        }
                    }
                    else if (reader.WaveFormat.BitsPerSample == 24)
                    {
                        int positionInReadBuffer = 3 * reader.WaveFormat.Channels * (int)(destSampleNumber / sampleRatio);        // position in source .wav file

                        // Create smaller array in order to add the 4th 8-bit value
                        byte[] byteArrayLeft = new byte[4] { 0, buffer[positionInReadBuffer + 2], buffer[positionInReadBuffer + 1], buffer[positionInReadBuffer] };

                        leftChannel[destSampleNumber] = (float)(BitConverter.ToInt16(byteArrayLeft, 0) / 32768.0);

                        if (reader.WaveFormat.Channels == 2)
                        {
                            byte[] byteArrayRight = new byte[4] { 0, buffer[positionInReadBuffer + 5], buffer[positionInReadBuffer + 4], buffer[positionInReadBuffer + 3] };
                            rightChannel[destSampleNumber] = (float)(BitConverter.ToInt16(byteArrayRight, 0) / 32768.0);
                        }
                        else
                        {
                            // use data of first channel for right channel
                            rightChannel[destSampleNumber] = (float)(BitConverter.ToInt16(byteArrayLeft, 0) / 32768.0);
                        }
                    }
                    else if (reader.WaveFormat.BitsPerSample == 32)
                    {
                        int positionInReadBuffer = 4 * reader.WaveFormat.Channels * (int)(destSampleNumber / sampleRatio);        // position in source .wav file

                        byte[] byteArrayLeft = new byte[4] { buffer[positionInReadBuffer], buffer[positionInReadBuffer + 1], buffer[positionInReadBuffer + 2], buffer[positionInReadBuffer + 3] };
                        int intValue = BitConverter.ToInt32(byteArrayLeft, 0);
                        float floatValue = intValue / (float)Int32.MaxValue;
                        leftChannel[destSampleNumber] = floatValue;
                        
                        if (reader.WaveFormat.Channels == 2)
                        {
                            byte[] byteArrayRight = new byte[4] { buffer[positionInReadBuffer + 4], buffer[positionInReadBuffer + 5], buffer[positionInReadBuffer + 6], buffer[positionInReadBuffer + 7] };
                            intValue = BitConverter.ToInt32(byteArrayRight, 0);
                            floatValue = intValue / (float)Int32.MaxValue;
                            rightChannel[destSampleNumber] = floatValue;
                        }
                        else
                        {
                            // use data of first channel for right channel
                            rightChannel[destSampleNumber] = floatValue;
                        }

                    }
                }
            }
        }

    }
}
