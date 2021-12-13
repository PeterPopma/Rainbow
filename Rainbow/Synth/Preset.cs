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
            if (presetItem.Name.Length == 0)
            {
                presetItem.Name = "default";
            }
            if (presetItem.Category.Length == 0)
            {
                presetItem.Category = "[default]";
            }
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(formMain.DataFolder + "\\presets\\" + presetItem.Name + ".pst"))
            {
                file.WriteLine(presetItem.Category);
                file.WriteLine(formMain.CurrentWaveFile.Name);
                file.WriteLine(formMain.CurrentWaveFile.Category);
                file.WriteLine(formMain.CurrentSecondaryWaveFile.Name);
                file.WriteLine(formMain.CurrentSecondaryWaveFile.Category);
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
            }
        }

        public string ReadCategory(string dataFolder, string name)
        {
            using (StreamReader srFile = new StreamReader(dataFolder + "\\presets\\" + name + ".pst"))
            {
                return srFile.ReadLine();      // category
            }
        }

        public void Load(FormMain formMain, SynthGenerator synthGenerator, string dataFolder, string name)
        {
            using (StreamReader srFile = new StreamReader(dataFolder + "\\presets\\" + name + ".pst"))
            {
                srFile.ReadLine();      // category we don't need to know when loading
                formMain.CurrentWaveFile.Name = srFile.ReadLine();
                formMain.CurrentWaveFile.Category = srFile.ReadLine();
                formMain.CurrentSecondaryWaveFile.Name = srFile.ReadLine();
                formMain.CurrentSecondaryWaveFile.Category = srFile.ReadLine();
                synthGenerator.RepeatBegin = double.Parse(srFile.ReadLine(), providerDecimalPoint);
                synthGenerator.RepeatEnd = double.Parse(srFile.ReadLine(), providerDecimalPoint);
                int length = int.Parse(srFile.ReadLine());
                synthGenerator.WaveInfo.ShapeVolume1 = new int[length];
                for (int j = 0; j < length; j++)
                {
                    synthGenerator.WaveInfo.ShapeVolume1[j] = int.Parse(srFile.ReadLine());
                }
                synthGenerator.WaveInfo.ShapeVolume2 = new int[length];
                for (int j = 0; j < length; j++)
                {
                    synthGenerator.WaveInfo.ShapeVolume2[j] = int.Parse(srFile.ReadLine());
                }
            }
            formMain.setWaveFile(formMain.CurrentWaveFile);
            formMain.setSecondaryWaveFile(formMain.CurrentSecondaryWaveFile);
            formMain.UpdatePresetControls();
        }

        public void Delete(string name)
        {
            File.Delete((@".\presets\" + name + ".pst"));
        }
    }

}
