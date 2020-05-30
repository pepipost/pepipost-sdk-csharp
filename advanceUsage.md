#### Example of Advance Usage

```csharp
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
namespace Testing
{
  class Program {
    static void Main(string[] args){
      Configuration.ApiKey = "api_key";
      PepipostClient client = new PepipostClient();
      MailSendController mailSend = client.MailSend;
      Send body = new Send();
      body.ReplyTo = "reply-me-here@mydomain.name";
      body.From = new From();
      body.From.Email = "hello@your-registered-domain-with-pepipost";
      body.From.Name = "Pepipost";
      body.Subject = "Pepipost Test Mail from SDK";
      body.TemplateId = 123L;
      body.Content = new List<Content>();
      Content body_content_0 = new Content();
      body_content_0.Type = TypeEnum.AMP;
      body_content_0.Value = "<!doctype html><html ⚡4email><head><meta charset=\"utf-8\"><style amp4email-boilerplate>body{visibility:hidden}</style><script async src=\"https://cdn.ampproject.org/v0.js\"></script></head><body>Hello, world. This is amp mail 1. </body></html>";
      body.Content.Add(body_content_0);
      Content body_content_1 = new Content();
      body_content_1.Type = TypeEnum.HTML;
      body_content_1.Value = "<html><body>Hello, Welcome to Pepipost Family.<br>My name is [% name %].<br>my love is sending [% love %]</body> <br></html>";
      body.Content.Add(body_content_1);
      body.Attachments = new List<Attachments>();
      Attachments body_attachments_0 = new Attachments();
      body_attachments_0.Content = "SGVsbG8sIHRoaXMgZmlsZSBpcyBhbiBpbmZvcm1hdGlvbmFsIGZpbGU6OiBTZW5kaW5nIGVtYWlscyB0byB0aGUgaW5ib3ggaXMgd2hhdCB3ZSBkbywgYnV0IHRoYXTigJlzIG5vdCB0aGUgb25seSByZWFzb24gd2h5IGRldmVsb3BlcnMgYW5kIGVudGVycHJpc2VzIGxvdmUgdXMuIFdlIGFyZSB0aGUgb25seSBFU1AgdGhhdCBkb2VzbuKAmXQgY2hhcmdlIGZvciBlbWFpbHMgb3BlbmVkLg==";
      body_attachments_0.Name = "global-file.txt";
      body.Attachments.Add(body_attachments_0);
      body.Personalizations = new List<Personalizations>();
      Personalizations body_personalizations_0 = new Personalizations();
      body_personalizations_0.Attributes = APIHelper.JsonDeserialize<Object>("{\"name\":\"Pepi\",\"love\":\"Email\"}");
      body_personalizations_0.Headers = APIHelper.JsonDeserialize<Object>("{\"Cus-Header1\":\"Cus-Value1\"}");
      body_personalizations_0.Attachments = new List<Attachments>();
      Attachments body_personalizations_0_attachments_0 = new Attachments();
      body_personalizations_0_attachments_0.Content = "SGVsbG8sIHRoaXMgZmlsZSBpcyBhbiBpbmZvcm1hdGlvbmFsIGZpbGU6OiBTZW5kaW5nIGVtYWlscyB0byB0aGUgaW5ib3ggaXMgd2hhdCB3ZSBkbywgYnV0IHRoYXTigJlzIG5vdCB0aGUgb25seSByZWFzb24gd2h5IGRldmVsb3BlcnMgYW5kIGVudGVycHJpc2VzIGxvdmUgdXMuIFdlIGFyZSB0aGUgb25seSBFU1AgdGhhdCBkb2VzbuKAmXQgY2hhcmdlIGZvciBlbWFpbHMgb3BlbmVkLg==";
      body_personalizations_0_attachments_0.Name = "personalized-file.txt";
      body_personalizations_0.Attachments.Add(body_personalizations_0_attachments_0);
      body_personalizations_0.To = new List<EmailStruct>();
      EmailStruct body_personalizations_0_to_0 = new EmailStruct();
      body_personalizations_0_to_0.Name = "to-name";
      body_personalizations_0_to_0.Email = "to-name-address@mydomain.name";
      body_personalizations_0.To.Add(body_personalizations_0_to_0);
      body_personalizations_0.Cc = new List<EmailStruct>();
      EmailStruct body_personalizations_0_cc_0 = new EmailStruct();
      body_personalizations_0_cc_0.Name = "to-cc-name";
      body_personalizations_0_cc_0.Email = "to-cc-name-address@mydomain.name";
      body_personalizations_0.Cc.Add(body_personalizations_0_cc_0);
      body_personalizations_0.Bcc = new List<EmailStruct>();
      EmailStruct body_personalizations_0_bcc_0 = new EmailStruct();
      body_personalizations_0_bcc_0.Name = "to-bcc-name";
      body_personalizations_0_bcc_0.Email = "to-bcc-name-address@mydomain.name";
      body_personalizations_0.Bcc.Add(body_personalizations_0_bcc_0);
      body_personalizations_0.TokenTo = "{\"topic\":\"token-to\"}";
      body_personalizations_0.TokenCc = "{\"topic\":\"token-to-cc\"}";
      body_personalizations_0.TokenBcc = "{\"topic\":\"token-to-bcc\"}";
      body.Personalizations.Add(body_personalizations_0);
      body.Settings = new Settings();
      body.Settings.Footer = true;
      body.Settings.ClickTrack = true;
      body.Settings.OpenTrack = true;
      body.Settings.UnsubscribeTrack = true;
      body.Tags = new List<string>();
      body.Tags.Add("campaign-test");
      body.LintPayload = true;
      body.Schedule = 0L;
      body.Bcc = new List<EmailStruct>();
      EmailStruct body_bcc_0 = new EmailStruct();
      body_bcc_0.Name = "global-bcc";
      body_bcc_0.Email = "global-bcc-address@mydomain.name";
      body.Bcc.Add(body_bcc_0);
      try 
      {
        object result = mailSend.CreateGeneratethemailsendrequestAsync(body).Result;
      }
      catch (APIException e){};        
    }
  }
}

```
