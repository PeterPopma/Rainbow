using Rainbow.Synth;
using Rainbow.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Synth
{
    class Preset
    {
        NumberFormatInfo providerDecimalPoint = new NumberFormatInfo();

        public Preset()
        {
            providerDecimalPoint.NumberDecimalSeparator = ".";
        }

        public void Save(FormMain formMain, SynthGenerator synthGenerator, CategoryItem presetItem)
        {
            if (synthGenerator.CurrentWaveFile1==null || synthGenerator.CurrentWaveFile2==null)
            {
                return;     // no valid data -> datafolder maybe pointing to wrong location
            }
            if (presetItem.Name.Length == 0)
            {
                presetItem.Name = "default";
            }
            if (presetItem.Category.Length == 0)
            {
                presetItem.Category = "[default]";
            }
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(synthGenerator.DataFolder + "\\presets\\" + presetItem.Name + ".pst"))
            {
                file.WriteLine(presetItem.Category);
                file.WriteLine(synthGenerator.CurrentWaveFile1.Name);
                file.WriteLine(synthGenerator.CurrentWaveFile1.Category);
                file.WriteLine(synthGenerator.CurrentWaveFile2.Name);
                file.WriteLine(synthGenerator.CurrentWaveFile2.Category);
                file.WriteLine(synthGenerator.RepeatBegin.ToString(providerDecimalPoint));
                file.WriteLine(synthGenerator.RepeatEnd.ToString(providerDecimalPoint));
                file.WriteLine(synthGenerator.WaveInfo.ShapeVolume1.Length);
                for (int j = 0; j < synthGenerator.WaveInfo.ShapeVolume1.Length; j++)
                {
                    file.WriteLine(synthGenerator.WaveInfo.ShapeVolume1[j]);
                }
                file.WriteLine(synthGenerator.WaveInfo.ShapeVolume2.Length);
                for (int j = 0; j < synthGenerator.WaveInfo.ShapeVolume2.Length; j++)
                {
                    file.WriteLine(synthGenerator.WaveInfo.ShapeVolume2[j]);
                }
                file.WriteLine(synthGenerator.WaveInfo.Inverted1);
                file.WriteLine(synthGenerator.WaveInfo.Inverted2);
                file.WriteLine(synthGenerator.StretchMode);
                file.WriteLine(synthGenerator.MixMode);
                file.WriteLine(synthGenerator.NumMixWaves);
                file.WriteLine(synthGenerator.Duration);
                file.WriteLine(synthGenerator.MaxDuration);
            }
        }

        public string ReadCategory(string dataFolder, string name)
        {
            using (StreamReader srFile = new StreamReader(dataFolder + "\\presets\\" + name + ".pst"))
            {
                return srFile.ReadLine();      // category
            }
        }

        public void Load(SynthGenerator synthGenerator, string name)
        {
            using (StreamReader srFile = new StreamReader(synthGenerator.DataFolder + "\\presets\\" + name + ".pst"))
            {
                srFile.ReadLine();      // preset category we don't need to know when loading
                synthGenerator.CurrentWaveFile1 = new CategoryItem(srFile.ReadLine() , srFile.ReadLine());
                synthGenerator.CurrentWaveFile2 = new CategoryItem(srFile.ReadLine(), srFile.ReadLine());
                synthGenerator.RepeatBegin = double.Parse(srFile.ReadLine(), providerDecimalPoint);
                synthGenerator.RepeatEnd = double.Parse(srFile.ReadLine(), providerDecimalPoint);
                int length = int.Parse(srFile.ReadLine());
                synthGenerator.WaveInfo.ShapeVolume1 = new int[length];
                for (int j = 0; j < length; j++)
                {
                    synthGenerator.WaveInfo.ShapeVolume1[j] = int.Parse(srFile.ReadLine());
                }
                length = int.Parse(srFile.ReadLine());
                synthGenerator.WaveInfo.ShapeVolume2 = new int[length];
                for (int j = 0; j < length; j++)
                {
                    synthGenerator.WaveInfo.ShapeVolume2[j] = int.Parse(srFile.ReadLine());
                }
                synthGenerator.WaveInfo.Inverted1 = bool.Parse(srFile.ReadLine());
                synthGenerator.WaveInfo.Inverted2 = bool.Parse(srFile.ReadLine());
                synthGenerator.StretchMode = int.Parse(srFile.ReadLine());
                synthGenerator.MixMode = int.Parse(srFile.ReadLine());
                synthGenerator.NumMixWaves = int.Parse(srFile.ReadLine());
                synthGenerator.Duration = double.Parse(srFile.ReadLine());
                synthGenerator.MaxDuration = double.Parse(srFile.ReadLine());
            }
        }

        public void Delete(string name)
        {
            File.Delete((@".\presets\" + name + ".pst"));
        }
    }

}
