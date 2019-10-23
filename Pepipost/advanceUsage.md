#### Example of Advance Usage

```csharp
using System;
using System.Collections.Generic;
using Pepipost.Controllers;
using Pepipost.Models;
using Pepipost.Exceptions;
using Pepipost.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace TestConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //initialization of library
            Pepipost.PepipostClient client = new Pepipost.PepipostClient();
            EmailController email = client.Email;
            EmailBody body = new EmailBody();

            string apiKey = "pass api-key here"; //Add your Pepipost APIkey from panel here

            body.Personalizations = new List<Personalizations>();

            Personalizations body_personalizations_0 = new Personalizations();

            // List of Email Recipients
            body_personalizations_0.Recipient = "my-email-id@domain.com"; //To/Recipient email address
            //body_personalizations_0.Attributes = APIHelper.JsonDeserialize<Object>("{'name':'pepi'}");
           // body_personalizations_0.RecipientCc = new List<string>() {"hitesh@pepipost.com"};
            body_personalizations_0.XApiheaderCc = "x api header cc content python";
            body_personalizations_0.XApiheader = "xapi header for emails python";
            //body_personalizations_0.RecipientBcc = new List<string>() { "hiteshkumar.pandey@netcore.co.in" };

            body_personalizations_0.Attachments = new List<Attachments>();
            Attachments body_personalizations_0_attachments_0 = new Attachments();
            body_personalizations_0_attachments_0.FileContent = "SGVsbG8sIHRoaXMgZmlsZSBpcyBhbiBpbmZvcm1hdGlvbmFsIGZpbGU6OiBTZW5kaW5nIGVtYWlscyB0byB0aGUgaW5ib3ggaXMgd2hhdCB3ZSBkbywgYnV0IHRoYXTigJlzIG5vdCB0aGUgb25seSByZWFzb24gd2h5IGRldmVsb3BlcnMgYW5kIGVudGVycHJpc2VzIGxvdmUgdXMuIFdlIGFyZSB0aGUgb25seSBFU1AgdGhhdCBkb2VzbuKAmXQgY2hhcmdlIGZvciBlbWFpbHMgb3BlbmVkLg==";
            body_personalizations_0_attachments_0.FileName = "pepipost3.txt";
            body_personalizations_0.Attachments.Add(body_personalizations_0_attachments_0);

            body_personalizations_0.Attributes = new Attributes("{'name':'pepi','love':'mail'}").GetAttributes();
            body_personalizations_0.XHeaders = new Xheaders("{'arg1':'value1','arg2':'value2'}").GetXheaders();
            body.Personalizations.Add(body_personalizations_0);

            body.Tags = "Csharp";

            /*Console.WriteLine(body_personalizations_0.Attributes.GetType());
            return;*/
            body.From = new From();

            // Email Header
            body.From.FromEmail = "pepi@net.xyz"; //Sender Email Address. Please note that the sender domain @exampledomain.com should be verified and active under your Pepipost account.
            body.From.FromName = "Pepi"; //Sender/From name

            //Email Body Content
            body.Subject = "Pepipost Test Email Csharp"; //Subject of email
            body.Content = "<html><body>Hello, Welcome to Pepipost Family.<br>My name is [% name %].<br>my love is sending [% love %]</body> <br></html>";
            body.AmpContent = "<!doctype html><html ⚡4email><head><meta charset=\"utf-8\"><style amp4email-boilerplate>body{visibility:hidden}</style><script async src=\"https://cdn.ampproject.org/v0.js\"></script></head><body>Hello, AMP.</body></html>";

            body.Attachments = new List<EmailBodyAttachments>();
            EmailBodyAttachments body_attachments_0 = new EmailBodyAttachments();
            body_attachments_0.FileContent = "SGVsbG8sIHRoaXMgZmlsZSBpcyBhbiBpbmZvcm1hdGlvbmFsIGZpbGU6OiBTZW5kaW5nIGVtYWlscyB0byB0aGUgaW5ib3ggaXMgd2hhdCB3ZSBkbywgYnV0IHRoYXTigJlzIG5vdCB0aGUgb25seSByZWFzb24gd2h5IGRldmVsb3BlcnMgYW5kIGVudGVycHJpc2VzIGxvdmUgdXMuIFdlIGFyZSB0aGUgb25seSBFU1AgdGhhdCBkb2VzbuKAmXQgY2hhcmdlIGZvciBlbWFpbHMgb3BlbmVkLg==";
            body_attachments_0.FileName = "pepipost3.txt";
            body.Attachments.Add(body_attachments_0);

            body.Settings = new Settings();
            body.Settings.Footer = 0;
            body.Settings.Clicktrack = 1; //Clicktrack for emails enable=1 | disable=0
            body.Settings.Opentrack = 1; //Opentrack for emails enable=1 | disable=0
            body.Settings.Unsubscribe = 1; //Unsubscribe for emails enable=1 | disable=0
            body.Settings.Bcc = "mybcc-email@email.in";

            body.ReplyToId = "replyto@gmail.com";

            const string url = "https://<url-endpoint>";

            SendEmailResponse result = email.CreateSendEmailAsync(apiKey, body, url).Result;

            try
            {
                if (result.Message.Contains("Error"))
                {
                    Console.WriteLine("\n" + "Message ::" + result.Message + "\n" + "Error Code :: " + result.ErrorInfo.ErrorCode + "\n" + "Error Message ::" + result.ErrorInfo.ErrorMessage + "\n");
                }
                else
                {
                    Console.WriteLine("\n" + "Message ::" + result.Message);
                }

            }
            catch (APIException) { };

            Console.WriteLine("Happy Mailing !");
        }
    }
}