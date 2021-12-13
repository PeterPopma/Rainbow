using Rainbow.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Synth
{
    class WaveInfo
    {
        float[] waveFileDataLeft = Array.Empty<float>();               // original data read from .wav file
        float[] waveFileDataRight = Array.Empty<float>();               // original data read from .wav file
        float[] waveFileSecondaryLeft = Array.Empty<float>();                  // original secondary data read from .wav file
        float[] waveFileSecondaryRight = Array.Empty<float>();                 // original secondary data read from .wav file
        float[] waveDataLeft = new float[0];                    // data after effects applied
        float[] waveDataRight = new float[0];                   // data after effects applied
        private string waveFileName = "";                       // name+path of .wav file
        int[] shapeVolume1 = new int[0];                        // shape of the volume. this consists of 1000 items with value between 0 and SHAPE_MAX_VALUE
        int[] shapeVolume2 = new int[0];                        // shape of the volume. this consists of 1000 items with value between 0 and SHAPE_MAX_VALUE
        bool inverted1;                                         // indicates that the sound must be inverted
        bool inverted2;                                         // indicates that the secondary sound must be inverted

        public string WaveFileName { get => waveFileName; set => waveFileName = value; }
        public float[] WaveFileDataLeft { get => waveFileDataLeft; set => waveFileDataLeft = value; }
        public float[] WaveFileDataRight { get => waveFileDataRight; set => waveFileDataRight = value; }
        public float[] WaveDataLeft { get => waveDataLeft; set => waveDataLeft = value; }
        public float[] WaveDataRight { get => waveDataRight; set => waveDataRight = value; }
        public float[] WaveFileSecondaryLeft { get => waveFileSecondaryLeft; set => waveFileSecondaryLeft = value; }
        public float[] WaveFileSecondaryRight { get => waveFileSecondaryRight; set => waveFileSecondaryRight = value; }
        public int[] ShapeVolume1 { get => shapeVolume1; set => shapeVolume1 = value; }
        public int[] ShapeVolume2 { get => shapeVolume2; set => shapeVolume2 = value; }
        public bool Inverted1 { get => inverted1; set => inverted1 = value; }
        public bool Inverted2 { get => inverted2; set => inverted2 = value; }

    }


}
