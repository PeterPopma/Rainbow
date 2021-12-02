using Jacobi.Vst.Core;
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
        float[] waveFileDataLeft = new float[0];                // original data read from .wav file
        float[] waveFileDataRight = new float[0];               // original data read from .wav file
        float[] waveFileSecondaryLeft = null;                   // original secondary data read from .wav file
        float[] waveFileSecondaryRight = null;                  // original secondary data read from .wav file
        float[] waveDataLeft = new float[0];                    // data after effects applied
        float[] waveDataRight = new float[0];                   // data after effects applied
        private string waveFileName = "";                       // name+path of .wav file
        int[] shapeVolume = new int[0];                         // shape of the volume. this consists of 1000 items with value between 0 and SHAPE_MAX_VALUE

        public string WaveFileName { get => waveFileName; set => waveFileName = value; }
        public float[] WaveFileDataLeft { get => waveFileDataLeft; set => waveFileDataLeft = value; }
        public float[] WaveFileDataRight { get => waveFileDataRight; set => waveFileDataRight = value; }
        public float[] WaveDataLeft { get => waveDataLeft; set => waveDataLeft = value; }
        public float[] WaveDataRight { get => waveDataRight; set => waveDataRight = value; }
        public float[] WaveFileSecondaryLeft { get => waveFileSecondaryLeft; set => waveFileSecondaryLeft = value; }
        public float[] WaveFileSecondaryRight { get => waveFileSecondaryRight; set => waveFileSecondaryRight = value; }
        public int[] ShapeVolume { get => shapeVolume; set => shapeVolume = value; }
    }
}
