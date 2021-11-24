using Jacobi.Vst.Core;
using NAudio.Wave;
using Rainbow.UI;
using Rainbow.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Synth
{
    class SynthGenerator
    {
        WaveInfo currentWave = new WaveInfo();
        private int samplesPerSecond = 44100;
        private int bitsPerSample = 32;
        private string dataFolder = "";
        private double repeatBegin = 0.05;
        private double repeatEnd = 0.4;
        private List<Note> notes = new List<Note>();

        public string DataFolder { get => dataFolder; set => dataFolder = value; }
        internal WaveInfo CurrentWave { get => currentWave; set => currentWave = value; }
        internal FormMain? MainView { get; set; }
        public double RepeatBegin { get => repeatBegin; set => repeatBegin = value; }
        public double RepeatEnd { get => repeatEnd; set => repeatEnd = value; }
        internal List<Note> Notes { get => notes; set => notes = value; }

        public SynthGenerator()
        {
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

        public void Initialize()
        {
            /*
            // find all presets
            try
            {
                string[] fileEntries = Directory.GetFiles("presets\\");
                foreach (string fileName in fileEntries)
                {
                    if (fileName.EndsWith(".pst"))
                    {
                        string name = fileName.Substring(8, fileName.Length - 12);
                        string category = Preset.ReadCategory(name);
                        PresetItem presetItem = new PresetItem(name, category);
                        presets.Add(presetItem);
                        if (currentPreset == null)        // set first preset
                        {
                            currentPreset = presetItem;
                            labelPreset.Text = name;
                            Preset.Load(SynthGenerator, name);
                        }
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory("presets");
            }
            */

            //            currentWave.WaveFileName = dataFolder + "\\wavefiles\\bell2.wav";
            //            currentWave.WaveFileName = dataFolder + "\\wavefiles\\horn2.wav"; 
            //            WaveFile.SaveToDisk(currentWave, samplesPerSecond, bitsPerSample);
            //GenerateSynthData(36);
        }

        public void LoadWaveFile(string wavefile)
        {
            CurrentWave.WaveFileName = dataFolder + "\\wavefiles\\" + wavefile + ".wav";
            WaveFile.LoadFromDisk(currentWave, samplesPerSecond);
        }

        public void SaveAsWaveFile()
        {
            WaveFile.SaveToDisk(CurrentWave, samplesPerSecond, bitsPerSample);
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
                    if (note.PlayPosition > CurrentWave.WaveFileDataLeft.Length * repeatEnd && note.Active)
                    {
                        note.PlayPosition = CurrentWave.WaveFileDataLeft.Length * repeatBegin;
//                        System.Diagnostics.Debug.WriteLine("rewind:" + note.Tone);
                    }
                    int position = (int)note.PlayPosition;
                    if (position >= CurrentWave.WaveFileDataLeft.Length)
                    {
                        Notes.RemoveAll(r => r.Tone == note.Tone);
                    }
                    else
                    {
                        tempDataLeft += Convert.ToDouble(CurrentWave.WaveFileDataLeft[position]) * note.Velocity;
                        tempDataRight += Convert.ToDouble(CurrentWave.WaveFileDataLeft[position]) * note.Velocity;
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
