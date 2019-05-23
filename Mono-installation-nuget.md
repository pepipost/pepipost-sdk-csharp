# Step to install C# Library using Mono-Develop IDE

If you are using Mono for development, then below steps will help you in integrating this Pepipost C# code library in our IDE.

## Prerequisites

   * [dotnet SDK](https://www.microsoft.com/net/download/dotnet-core/2.0) (> 2.0)
   * [mono devel](https://www.mono-project.com/download/stable/)
   * [Mono-develop IDE](https://www.monodevelop.com/download/)
   * [NETStandard.Library](https://www.nuget.org/packages/NETStandard.Library/)(>= 1.6.1)
   * [Pepipost](https://www.nuget.org/packages/Pepipost/)
   * A free account on [Pepipost](https://app.pepipost.com/index.php/signup/registeruser). If you don't have a one, click here to sign-up and get 30,000 emails free every month.
 
## How to build

   1. Start mono-develop IDE 
      
      ![Monol1](http://app1.falconide.com/integration_imgs/csharp-mono/l1.png)
      
   
   2. Select **File -> New Solution** Or Simply **Ctrl+shift+N**
   
      Template for new project prompt will appear **App -> console application -> Next**
      
      ![monol2](http://app1.falconide.com/integration_imgs/csharp-mono/l2.png)
      
      
   3. Give a name to your project 
   
      ```testConsole```
      
      Once you have named your project simply click create
      
      ![monol3](http://app1.falconide.com/integration_imgs/csharp-mono/l3.png)
      
      
   4. After Project is successfully created 
   
      ![monol4](http://app1.falconide.com/integration_imgs/csharp-mono/l4.png)
      

   5. Let's add Nuget package dependencies as described earlier
   
      ![mono15](http://app1.falconide.com/integration_imgs/csharp-mono/l5.png)
          
      Select **official C# library Pepipost**
      
      ![monol7](https://app1.falconide.com/integration_imgs/csharp-mono/l7.png)
      
     
   6. Once all the packages are installed successfully, just copy and paste the [simpleUsage.md](https://github.com/pepipost/pepipost-sdk-csharp/blob/master/simpleUsage.md) in your program.cs file present in your project.
      
      Build the project as shown below OR by simply hit **F8**
      
      ![monol8](http://app1.falconide.com/integration_imgs/csharp-mono/l8.png)
      
   7. Update the api_key and FromEmail parameters:

      * apikey: This will be available under: Login to your Pepipost account -> Settings -> Integration
      * FromEmail: If your fromemail address is e.g. info@mydomain.com, then the Sending Domain mydomain need to be verified and active under your Pepipost account. You can manage the Sending Domain under: Login to Pepipost -> Settings -> Sending Domains
      
   8. Change apiKey and FromEmail in your script: 
   
      ```string apiKey = "XXXXX-your-api-key-XXXX" ``` (near by line no 25 if your have copy the simpleUsage.md)
           
      ```body_personalizations_0.Recipient = "your recipient emailid here"``` (near by line no 31)
     
      ```body.From.FromEmail = "info@ your-verified-domain"``` (near by line no 37)
     
   9. Build the project to finally send your first test email Run the project.
   
      Run the project by hiting **Ctrl + F5**
      
      If your apikey and sending domain is proper, then response message will be success. 
      
      ![monol9](http://app1.falconide.com/integration_imgs/csharp-mono/l9.png)
      
      Hope, you have received your first test email 😃
      
      If there is some problem related with config, then you will receive error message as shown below:
      
      ![mono10](http://app1.falconide.com/integration_imgs/csharp-mono/l10.png)
      
      
