namespace Rainbow
{
    using Jacobi.Vst.Core;
    using Jacobi.Vst.Plugin.Framework;
    using Jacobi.Vst.Plugin.Framework.Common;
    using System;

    /// <summary>
    /// Implements the custom UI editor for the plugin.
    /// </summary>
    internal sealed class PluginEditor : IVstPluginEditor
    {
        private readonly MidiProcessor _midiProcessor;
        private readonly WinFormsControlWrapper<UI.FormMain> _uiWrapper =
            new WinFormsControlWrapper<UI.FormMain>();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="plugin">Must not be null.</param>
        public PluginEditor(MidiProcessor midiProcessor)
        {
            _midiProcessor = midiProcessor ?? throw new ArgumentNullException(nameof(midiProcessor));
        }

        #region IVstPluginEditor Members

        public System.Drawing.Rectangle Bounds
        {
            get { return _uiWrapper.Bounds; }
        }

        /// <summary>
        /// Updates the UI with the <see cref="NoteOnEvents"/>.
        /// </summary>
        public void ProcessIdle()
        {
        }


        public void Close()
        {
            _uiWrapper.Close();
        }

        public bool KeyDown(byte ascii, VstVirtualKey virtualKey, VstModifierKeys modifers)
        {
            // no-op
            return false;
        }

        public bool KeyUp(byte ascii, VstVirtualKey virtualKey, VstModifierKeys modifers)
        {
            // no-op
            return false;
        }

        public VstKnobMode KnobMode { get; set; }

        public void Open(IntPtr hWnd)
        {
            _uiWrapper.SafeInstance.SynthGenerator = _midiProcessor.SynthGenerator;
            _midiProcessor.SynthGenerator.MainView = _uiWrapper.Instance;
            _uiWrapper.SafeInstance.Initialize();
            _uiWrapper.Open(hWnd);
        }

        #endregion
    }
}
