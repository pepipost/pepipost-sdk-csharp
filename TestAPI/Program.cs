using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Pepipost;
using Pepipost.Utilities;
using Pepipost.Models;
using Pepipost.Controllers;
using Pepipost.Exceptions;
using System.IO;

namespace TestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration.ApiKey = "api_key";
            PepipostClient client = new PepipostClient();
            MailSendController mailSend = client.MailSend;
            Send body = new Send();
            body.From = new From();
            body.From.Email = "hello@registered-domain.in";
            body.From.Name = "Pepipost";
            body.Subject = "Pepipost Test Mail from SDK";
            body.Content = new List<Content>();
            Content body_content_0 = new Content();
            body_content_0.Type = TypeEnum.HTML;
            body_content_0.Value = "<html><body>Hello, Welcome to Pepipost Family.<br>My name is [% name %].<br>my love is sending [% love %]</body> <br></html>";
            body.Content.Add(body_content_0);
            body.Personalizations = new List<Personalizations>();
            Personalizations body_personalizations_0 = new Personalizations();
            body_personalizations_0.Attributes = APIHelper.JsonDeserialize<Object>("{\"name\":\"Pepi\",\"love\":\"Email\"}");
            body_personalizations_0.Attachments = new List<Attachments>();
            Attachments body_personalizations_0_attachments_0 = new Attachments();
            body_personalizations_0_attachments_0.Content = "SGVsbG8sIHRoaXMgZmlsZSBpcyBhbiBpbmZvcm1hdGlvbmFsIGZpbGU6OiBTZW5kaW5nIGVtYWlscyB0byB0aGUgaW5ib3ggaXMgd2hhdCB3ZSBkbywgYnV0IHRoYXTigJlzIG5vdCB0aGUgb25seSByZWFzb24gd2h5IGRldmVsb3BlcnMgYW5kIGVudGVycHJpc2VzIGxvdmUgdXMuIFdlIGFyZSB0aGUgb25seSBFU1AgdGhhdCBkb2VzbuKAmXQgY2hhcmdlIGZvciBlbWFpbHMgb3BlbmVkLg==";
            body_personalizations_0_attachments_0.Name = "personalized-file.txt";
            body_personalizations_0.Attachments.Add(body_personalizations_0_attachments_0);
            body_personalizations_0.To = new List<EmailStruct>();
            EmailStruct body_personalizations_0_to_0 = new EmailStruct();
            body_personalizations_0_to_0.Name = "Vikram Sahu";
            body_personalizations_0_to_0.Email = "to-address@gmail.com";
            body_personalizations_0.To.Add(body_personalizations_0_to_0);
            body_personalizations_0.Cc = new List<EmailStruct>();
            body_personalizations_0.Bcc = new List<EmailStruct>();
            body.Personalizations.Add(body_personalizations_0);
            body.Tags = new List<string>();
            body.Tags.Add("campaign");
            const string dynamicURL = "https://api.pepipost.com"; //(pass if any other url is suggested)
            try
            {
                object result = mailSend.CreateGeneratethemailsendrequestAsync(body,dynamicURL).Result;
                Console.WriteLine(result);
            }
            catch (APIException e) { };
        }
    }
}