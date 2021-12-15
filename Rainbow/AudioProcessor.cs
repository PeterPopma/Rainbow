namespace Rainbow
{
    using Jacobi.Vst.Core;
    using Jacobi.Vst.Plugin.Framework;
    using Jacobi.Vst.Plugin.Framework.Plugin;
    using Rainbow.Synth;
    using System;

    /// <summary>
    /// A dummy audio processor only used for the timing of midi processing.
    /// </summary>
    internal sealed class AudioProcessor : VstPluginAudioProcessor
    {
        private MidiProcessor? _midiProcessor;
        private IVstMidiProcessor? _hostProcessor;
        private readonly SynthGenerator synthGenerator;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="plugin">Must not be null.</param>
        public AudioProcessor(/*IVstPluginEvents pluginEvents*/SynthGenerator synthGenerator)
            : base(0, 2, 0, noSoundInStop: false)
        {
            this.synthGenerator = synthGenerator ?? throw new ArgumentNullException(nameof(synthGenerator));
//            pluginEvents.Opened += Plugin_Opened;
        }

        private void Plugin_Opened(object? sender, System.EventArgs e)
        {
            var plugin = (VstPlugin?)sender;
            _midiProcessor = plugin?.GetInstance<MidiProcessor>();
            _hostProcessor = plugin?.Host?.GetInstance<IVstMidiProcessor>();
        }

        /// <inheritdoc />
        /// <remarks>This method is used to push midi events to the host.</remarks>
        public override void Process(VstAudioBuffer[] inChannels, VstAudioBuffer[] outChannels)
        {
            synthGenerator.Play(outChannels);

            // base.Process(inChannels, outChannels);      // audio thru
        }
    }
}
