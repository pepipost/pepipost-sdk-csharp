# Simple Usage in C# to send email

```csharp
using System;
using System.Collections.Generic;
using Pepipost.Controllers;
using Pepipost.Models;
using Pepipost.Exceptions;
using Pepipost.Utilities;
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

            string apiKey = "Your api key here"; //Add your Pepipost APIkey from panel here

            body.Personalizations = new List<Personalizations>();

            Personalizations body_personalizations_0 = new Personalizations();
	    
	    // List of Email Recipients
            body_personalizations_0.Recipient = "recipient@exampledomain.com"; //To/Recipient email address
            body_personalizations_0.Attributes = APIHelper.JsonDeserialize<Object>("{}");
            body.Personalizations.Add(body_personalizations_0);

            body.From = new From();
            
	    // Email Header
            body.From.FromEmail = "sender@exampledomain.com"; //Sender Email Address. Please note that the sender domain @exampledomain.com should be verified and active under your Pepipost account.
            body.From.FromName = "Pepi"; //Sender/From name
	    
	    //Email Body Content
            body.Subject = "Pepipost Test Email"; //Subject of email
            body.Content = "<html><body>Hey,<br><br>Congratulations, Integration is Successfully Completed.<br>This is your first email from Pepipost C# library.<br>Happy Emailing<br><br>Thanks,<br>Pepipost";
            body.Settings = new Settings();

            body.Settings.Footer = 0;
            body.Settings.Clicktrack = 1; //Clicktrack for emails enable=1 | disable=0
            body.Settings.Opentrack = 1; //Opentrack for emails enable=1 | disable=0
            body.Settings.Unsubscribe = 1; //Unsubscribe for emails enable=1 | disable=0
			SendEmailResponse result = email.CreateSendEmailAsync(apiKey, body).Result;

            try
            {
				if(result.Message.Contains("Error")){
					Console.WriteLine("\n" + "Message ::" + result.Message + "\n" + "Error Code :: " + result.ErrorInfo.ErrorCode + "\n" + "Error Message ::" + result.ErrorInfo.ErrorMessage + "\n");
				}else{
					Console.WriteLine("\n" + "Message ::" + result.Message);
				}
                
            }
            catch (APIException) { };

            Console.WriteLine("Happy Mailing !");
        }
    }
}
```
