namespace Rainbow
{
    using Jacobi.Vst.Core;
    using Jacobi.Vst.Plugin.Framework;
    using System;
    using System.IO;
    using System.Text;

    internal sealed class PluginPersistence : IVstPluginPersistence
    {
        private readonly Encoding _encoding = Encoding.ASCII;

        public PluginPersistence()
        {
        }

        #region IVstPluginPersistence Members

        public bool CanLoadChunk(VstPatchChunkInfo chunkInfo)
        {
            return true;
        }

        public void ReadPrograms(Stream stream, VstProgramCollection programs)
        {
            var reader = new BinaryReader(stream, _encoding);

            int count = reader.ReadInt32();
        }

        public void WritePrograms(Stream stream, VstProgramCollection programs)
        {
            var writer = new BinaryWriter(stream, _encoding);

//            writer.Write(_noteMap.Count);
        }

        #endregion
    }
}
