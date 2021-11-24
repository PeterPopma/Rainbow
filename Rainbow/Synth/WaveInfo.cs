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
        float[] waveFileDataLeft = new float[0];                // data read from .wav file
        float[] waveFileDataRight = new float[0];               // data read from .wav file
        float[] waveDataLeft = new float[0];                    // processed data
        float[] waveDataRight = new float[0];                   // processed data
        private string waveFileName = "";                       // name+path of .wav file

        public string WaveFileName { get => waveFileName; set => waveFileName = value; }
        public float[] WaveFileDataLeft { get => waveFileDataLeft; set => waveFileDataLeft = value; }
        public float[] WaveFileDataRight { get => waveFileDataRight; set => waveFileDataRight = value; }
        public float[] WaveDataLeft { get => waveDataLeft; set => waveDataLeft = value; }
        public float[] WaveDataRight { get => waveDataRight; set => waveDataRight = value; }
    }
}
