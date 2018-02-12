// Decompiled with JetBrains decompiler
// Type: My.MySettings
// Assembly: stub, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D061B43-92C3-47A8-A000-0E762F8D5CF4
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_00400000.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    public static MySettings Default
    {
      get
      {
        return MySettings.defaultInstance;
      }
    }
  }
}
