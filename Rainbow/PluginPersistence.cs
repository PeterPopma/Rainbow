namespace Rainbow
{
    using Jacobi.Vst.Core;
    using Jacobi.Vst.Plugin.Framework;
    using Rainbow.Synth;
    using System;
    using System.IO;
    using System.Text;

    internal sealed class PluginPersistence : IVstPluginPersistence
    {
        private SynthGenerator synthGenerator;
        private readonly Encoding _encoding = Encoding.ASCII;

        public PluginPersistence(SynthGenerator synthGenerator)
        {
            this.synthGenerator = synthGenerator ?? throw new ArgumentNullException(nameof(synthGenerator));
        }

        #region IVstPluginPersistence Members

        public bool CanLoadChunk(VstPatchChunkInfo chunkInfo)
        {
            return true;
        }

        public void ReadPrograms(Stream stream, VstProgramCollection programs)
        {
            var reader = new BinaryReader(stream, _encoding);

            synthGenerator.SavedPreset = reader.ReadString();
        }

        public void WritePrograms(Stream stream, VstProgramCollection programs)
        {
            var writer = new BinaryWriter(stream, _encoding);
            if (synthGenerator.SavedPreset != null)
            {
                writer.Write(synthGenerator.SavedPreset);
            }
        }

        #endregion
    }
}
