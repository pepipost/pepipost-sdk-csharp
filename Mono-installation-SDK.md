# Steps to install C# SDK with Mono-Develop IDE using Git (without Nuget/Package Manager)

If you are using Mono for development and want to integrated with Pepipost directly by using Git, then below steps will help you in integrating this Pepipost C# code library in our IDE.

  
## Prerequisites
    
   * [dotnet SDK](https://www.microsoft.com/net/download/dotnet-core/2.0) (> 2.0)
   * [mono devel](https://www.mono-project.com/download/stable/)
   * [Mono-develop IDE](https://www.monodevelop.com/download/)
   * [NETStandard.Library](https://www.nuget.org/packages/NETStandard.Library/)(>= 1.6.1)
   * [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
   * A free account on [Pepipost](https://app.pepipost.com/index.php/signup/registeruser).If you don't have a one, click here to sign-up and get 30,000 emails free every month.

## How to Build

   1. Download [Pepipost SDK](https://github.com/pepipost/pepipost-sdk-csharp/archive/master.zip)
   
      Unzip the SDK on any Location of your choice (we will unzipped in directory named testSDK)
            
      OR ```git clone https://github.com/pepipost/pepipost-sdk-csharp.git```
      
      ![mygit](http://app1.falconide.com/integration_imgs/csharp-mono/1.png)
      
      
   2. Start Mono-Develop IDE
   
      Click **open**
      
      ![monoide](http://app1.falconide.com/integration_imgs/csharp-mono/2.png)
      
      
   3. Select **Pepipost.sln** from unzipped folder 
   
      **Open** the Solution once you have selected the sln file 
   
      ![mono](http://app1.falconide.com/integration_imgs/csharp-mono/3.png)
      
      
   4. Once you have opened the solution the few files will appear with respective SDK:
   
      Add new project to the main directory as shown below
      
      ![monoaddpro](http://app1.falconide.com/integration_imgs/csharp-mono/4.png)
      
      
   5. Choose template for new project will be prompted
   
      Select **App -> Console Application -> next**
      
      ![appconsole](http://app1.falconide.com/integration_imgs/csharp-mono/5.png)
      
      
   6. Configure new project
   
      Give a desired name to your project (testConsole recommended)
      
      ![makeconsole](http://app1.falconide.com/integration_imgs/csharp-mono/6.png)
      
      
   7. Resolving dependencies
   
      a. Adding reference 
      
      ![dep1](http://app1.falconide.com/integration_imgs/csharp-mono/7.png)
      
      Select **Edit Reference**
        
      ![dep2](http://app1.falconide.com/integration_imgs/csharp-mono/8.png)
        
      Select **Pepipost -> OK**
         
      ![dep3](http://app1.falconide.com/integration_imgs/csharp-mono/9.png)
         
       b. Adding packages
       
       ![dep4](http://app1.falconide.com/integration_imgs/csharp-mono/10.png)
          
       search **NewtonSoft.json -> Add packages**
          
       ![dep5](http://app1.falconide.com/integration_imgs/csharp-mono/11.png)
       
          
   8. Once all the packages are installed successfully 
   
      Just copy and paste the [simpleUsage.md](https://github.com/pepipost/pepipost-sdk-csharp/blob/master/simpleUsage.md) in your program.cs file present in your project.
      
      Build the project as shown below OR by just hit **F8** to build
      
      ![monol8](http://app1.falconide.com/integration_imgs/csharp-mono/l8.png)
      
        
   9.   Update the api_key and FromEmail parameters:

      * apikey: This will be available under: Login to your Pepipost account -> Settings -> Integration
      * FromEmail: If your fromemail address is e.g. info@mydomain.com, then the Sending Domain mydomain need to be verified and active under your Pepipost account. You can manage the Sending Domain under: Login to Pepipost -> Settings -> Sending Domains
       
      
   10. Change apiKey and FromEmail in your script: 
   
      ```string apiKey = "XXXXX-your-api-key-XXXX" ``` (near by line no 25 if your have copy the simpleUsage.md)
           
      ```body_personalizations_0.Recipient = "your recipient emailid here"``` (near by line no 31)
     
      ```body.From.FromEmail = "info@ your-verified-domain"``` (near by line no 37)
      
      
   11. Build the project to finally send your first test email Run the project.
   
       Run the project by hiting **Ctrl + F5**
      
       If your apikey and sending domain is proper, then response message will be success. 
      
        ![monol9](http://app1.falconide.com/integration_imgs/csharp-mono/l9.png)
      
       Hope, you have received your first test email 😃
      
       If there is some problem related with config, then you will receive error message as shown below:
      
        ![mono10](http://app1.falconide.com/integration_imgs/csharp-mono/l10.png)

      
