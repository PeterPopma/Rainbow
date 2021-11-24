# Rainbow Vst Sound Generator

VST plugin that can be used to create sounds in any DAW.


** KNOWN ISSUES **
After updating the UI with Visual Studio designer, the assembly in formXXX.resx is changed.
This causes the plugin to fail to start.
The assembly should be something like this:

  <assembly alias="System.Drawing.Common" name="System.Drawing.Common, Version=5.0.0.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51" />
