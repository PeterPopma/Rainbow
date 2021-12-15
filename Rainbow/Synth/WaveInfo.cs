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
        float[] waveFileData1Left = Array.Empty<float>();               // original data read from .wav file
        float[] waveFileData1Right = Array.Empty<float>();               // original data read from .wav file
        float[] waveFileData2Left = Array.Empty<float>();                  // original secondary data read from .wav file
        float[] waveFileData2Right = Array.Empty<float>();                 // original secondary data read from .wav file
        float[] waveDataLeft = new float[0];                    // data after effects applied
        float[] waveDataRight = new float[0];                   // data after effects applied
        int[] shapeVolume1 = new int[0];                        // shape of the volume. this consists of 1000 items with value between 0 and SHAPE_MAX_VALUE
        int[] shapeVolume2 = new int[0];                        // shape of the volume. this consists of 1000 items with value between 0 and SHAPE_MAX_VALUE
        bool inverted1;                                         // indicates that the sound must be inverted
        bool inverted2;                                         // indicates that the secondary sound must be inverted

        public float[] WaveFileData1Left { get => waveFileData1Left; set => waveFileData1Left = value; }
        public float[] WaveFileData1Right { get => waveFileData1Right; set => waveFileData1Right = value; }
        public float[] WaveDataLeft { get => waveDataLeft; set => waveDataLeft = value; }
        public float[] WaveDataRight { get => waveDataRight; set => waveDataRight = value; }
        public float[] WaveFileData2Left { get => waveFileData2Left; set => waveFileData2Left = value; }
        public float[] WaveFileData2Right { get => waveFileData2Right; set => waveFileData2Right = value; }
        public int[] ShapeVolume1 { get => shapeVolume1; set => shapeVolume1 = value; }
        public int[] ShapeVolume2 { get => shapeVolume2; set => shapeVolume2 = value; }
        public bool Inverted1 { get => inverted1; set => inverted1 = value; }
        public bool Inverted2 { get => inverted2; set => inverted2 = value; }
    }


}
