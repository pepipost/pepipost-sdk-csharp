## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later 

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] compile-mono.sh
- [Windows] compile.bat

Then include the DLL (under the `bin` folder) in the C# project

## USAGE Example
```csharp
using System;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;

namespace youconsoleapp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Prepare the data
			Emailv1 data = new Emailv1 ();
			data.ApiKey = "yoursecretapikey";


			//email_details Model
			EmailDetails email_details = new EmailDetails ();
			email_details.Fromname = "sender name";
			email_details.From = "from@example.com";
			email_details.Subject = "Test email sent using Pepiopst Csharp SDK";
			email_details.Content = "<p>This email is sent using Pepipost CSharp SDK</p>";

			System.Collections.Generic.List<string>	recipients = new System.Collections.Generic.List<string> {"recipient@example.com"};

			//Combine all
			data.Recipients = recipients;
			data.EmailDetails = email_details;

			//Call the API method
			EmailApi email = new EmailApi ();

			//For debug print outgoing json
			//String data_json = JsonConvert.SerializeObject (data);
			//System.Console.WriteLine ("Data JSON "+ data_json);

			var response = email.CreateApiWebSendJson (data);
			System.Console.WriteLine ("response"+response.ToString());
		}
	}
}
```

