using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Synth
{
    class Note
    {
        byte velocity;
        byte tone;
        bool active = false;
        double playPosition = 0;     // position of the sound data currently playing. note that this is a double, because we are playing at different frequencies.
        double frequencyFactor;

        public Note(byte tone, byte velocity)
        {
            this.velocity = velocity;
            this.tone = tone;
            double frequency = 440 * Math.Pow(1.059463094359, tone - 57);        // note 0 = c0 = 16.35 Hz, note 57 = a4 = 440Hz, note 127 = b10 = 31608.531 Hz
            frequencyFactor = frequency / 440;
            Active = true;
        }

        public byte Tone { get => tone; set => tone = value; }
        public byte Velocity { get => velocity; set => velocity = value; }
        public double PlayPosition { get => playPosition; set => playPosition = value; }
        public double FrequencyFactor { get => frequencyFactor; set => frequencyFactor = value; }
        public bool Active { get => active; set => active = value; }
    }
}
