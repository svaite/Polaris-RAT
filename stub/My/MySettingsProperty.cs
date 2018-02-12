// Decompiled with JetBrains decompiler
// Type: My.MySettingsProperty
// Assembly: stub, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D061B43-92C3-47A8-A000-0E762F8D5CF4
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_00400000.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace My
{
  [StandardModule]
  [DebuggerNonUserCode]
  [HideModuleName]
  [CompilerGenerated]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        return MySettings.Default;
      }
    }
  }
}
