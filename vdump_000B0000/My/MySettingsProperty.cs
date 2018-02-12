// Decompiled with JetBrains decompiler
// Type: g.My.MySettingsProperty
// Assembly: es, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4F5E42DF-7B78-45EB-8AAA-54929E9E72A7
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_000B0000.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace g.My
{
  [StandardModule]
  [HideModuleName]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings mySettings = MySettings.Default;
        return mySettings;
      }
    }
  }
}
