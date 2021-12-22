using Jacobi.Vst.Host.Interop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RainbowHost
{
    partial class MainForm : Form
    {
        private List<VstPluginContext> _plugins = new List<VstPluginContext>();

        public MainForm()
        {
            InitializeComponent();
        }

        private VstPluginContext OpenPlugin(string pluginPath)
        {
            try
            {
                HostCommandStub hostCmdStub = new HostCommandStub();
                hostCmdStub.PluginCalled += new EventHandler<PluginCalledEventArgs>(HostCmdStub_PluginCalled);

                VstPluginContext ctx = VstPluginContext.Create(pluginPath, hostCmdStub);

                // add custom data to the context
                ctx.Set("PluginPath", pluginPath);
                ctx.Set("HostCmdStub", hostCmdStub);

                // actually open the plugin itself
                ctx.PluginCommandStub.Commands.Open();

                return ctx;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void ReleaseAllPlugins()
        {
            foreach (VstPluginContext ctx in _plugins)
            {
                // dispose of all (unmanaged) resources
                ctx.Dispose();
            }

            _plugins.Clear();
        }

        private void HostCmdStub_PluginCalled(object sender, PluginCalledEventArgs e)
        {
            HostCommandStub hostCmdStub = (HostCommandStub)sender;

            // can be null when called from inside the plugin main entry point.
            if (hostCmdStub.PluginContext.PluginInfo != null)
            {
                Debug.WriteLine("Plugin " + hostCmdStub.PluginContext.PluginInfo.PluginID + " called:" + e.Message);
            }
            else
            {
                Debug.WriteLine("The loading Plugin called:" + e.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReleaseAllPlugins();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            /*
            PluginPathTxt.Text = @"E:\Projects\Rainbow\Rainbow\bin\x64\Debug\net5.0-windows\deploy\Rainbow.dll";
            AddBtn.PerformClick();
            PluginListVw.Items[0].Focused = true;
            PluginListVw.Items[0].Selected = true;
            PluginListVw.Items[0].EnsureVisible();
            ViewPluginBtn.PerformClick();
            */
            String pluginPath = @"C:\Projects\Rainbow\Rainbow\bin\x64\Debug\net5.0-windows\deploy\Rainbow.dll";
            VstPluginContext ctx = OpenPlugin(Directory.GetCurrentDirectory() + "\\Rainbow.dll");

            if (ctx != null)
            {
                EditorFrame dlg = new EditorFrame
                {
                    PluginCommandStub = ctx.PluginCommandStub
                };

                ctx.PluginCommandStub.Commands.MainsChanged(true);
                dlg.ShowDialog(this);
                ctx.PluginCommandStub.Commands.MainsChanged(false);
            }

            Close();

        }
    }
}
