namespace Rainbow
{
    using Jacobi.Vst.Core;
    using Jacobi.Vst.Plugin.Framework;
    using Rainbow.Synth;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Implements the incoming Midi event handling for the plugin.
    /// </summary>
    internal sealed class MidiProcessor : IVstMidiProcessor, IVstPluginMidiSource
    {
        private readonly SynthGenerator synthGenerator;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="plugin">Must not be null.</param>
        public MidiProcessor(SynthGenerator synthGenerator)
        {
            this.synthGenerator = synthGenerator ?? throw new ArgumentNullException(nameof(synthGenerator));
            synthGenerator.Initialize();
        }

        /// <summary>
        /// Gets the midi events that should be processed in the current cycle.
        /// </summary>
        public VstEventCollection Events { get; } = new VstEventCollection();

        /// <summary>
        /// Gets or sets a value indicating wether non-mapped midi events should be passed to the output.
        /// </summary>
        public bool MidiThru { get; set; }

        /// <summary>
        /// The raw note on note numbers.
        /// </summary>
        public Queue<byte> NoteOnEvents { get; } = new Queue<byte>();

        #region IVstMidiProcessor Members

        public int ChannelCount
        {
            get { return 16; }
        }

        internal SynthGenerator SynthGenerator => synthGenerator;

        public void Process(VstEventCollection events)
        {
            foreach (VstEvent evnt in events)
            {
                if (evnt.EventType != VstEventTypes.MidiEvent)
                    continue;

                var midiEvent = (VstMidiEvent)evnt;

                if ((midiEvent.Data[0] & 0xF0) == 0x80 || ((midiEvent.Data[0] & 0xF0) == 0x90 && midiEvent.Data[2] == 0))     // note off event  (note on with velocity = 0 is a note off)
                {
                    SynthGenerator.NoteOff(midiEvent.Data[1]);
                }

                if ((midiEvent.Data[0] & 0xF0) == 0x90 && midiEvent.Data[2] != 0)     // note on event  (note on with velocity = 0 is a note off)
                {
                    SynthGenerator.NoteOn(midiEvent.Data[1], midiEvent.Data[2]);
                }
                else if (MidiThru)
                {
                    // add original (non-note) event
                    Events.Add(evnt);
                }
            }
        }

        #endregion
    }
}
