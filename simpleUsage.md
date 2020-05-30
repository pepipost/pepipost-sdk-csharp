# Simple Usage in C# to send email

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
      body.From = new From();
      body.From.Email = "hello@your-registered-domain-with-pepipost";
      body.From.Name = "Pepipost";
      body.Subject = "Pepipost Test Mail from SDK";
      body.Content = new List<Content>();
      Content body_content_0 = new Content();
      body_content_0.Type = Type.HTML;
      body_content_0.Value = "<html><body>Hello, Welcome to Pepipost Family.<br>My name is [% name %].<br>my love is sending [% love %]</body> <br></html>";
      body.Content.Add(body_content_0);
      body.Personalizations = new List<Personalizations>();
      Personalizations body_personalizations_0 = new Personalizations();
      body_personalizations_0.Attributes = APIHelper.JsonDeserialize<Object>("{\"name\":\"Pepi\",\"love\":\"Email\"}");
      body_personalizations_0.To = new List<EmailStruct>();
      EmailStruct body_personalizations_0_to_0 = new EmailStruct();
      body_personalizations_0_to_0.Name = "to-address";
      body_personalizations_0_to_0.Email = "to-address@mydomain.name";
      body_personalizations_0.To.Add(body_personalizations_0_to_0);
      body_personalizations_0.Cc = new List<EmailStruct>();
      EmailStruct body_personalizations_0_cc_0 = new EmailStruct();
      body_personalizations_0_cc_0.Name = "to-cc-name";
      body_personalizations_0_cc_0.Email = "to-bcc-name";
      body_personalizations_0.Cc.Add(body_personalizations_0_cc_0);
      body_personalizations_0.Bcc = new List<EmailStruct>();
      EmailStruct body_personalizations_0_bcc_0 = new EmailStruct();
      body_personalizations_0_bcc_0.Name = "to-bcc-name";
      body_personalizations_0_bcc_0.Email = "to-bcc-name@mydomain.name";
      body_personalizations_0.Bcc.Add(body_personalizations_0_bcc_0);
      body.Personalizations.Add(body_personalizations_0);
      body.Settings = new Settings();
      body.Settings.Footer = true;
      body.Settings.ClickTrack = true;
      body.Settings.OpenTrack = true;
      body.Settings.UnsubscribeTrack = true;
      try 
      {
        object result = mailSend.CreateGeneratethemailsendrequestAsync(body).Result;
      }
      catch (APIException e){};        
    }
  }
}
```
