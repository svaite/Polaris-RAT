// Decompiled with JetBrains decompiler
// Type: g.My.MySettings
// Assembly: es, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4F5E42DF-7B78-45EB-8AAA-54929E9E72A7
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_000B0000.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace g.My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    public static MySettings Default
    {
      get
      {
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
