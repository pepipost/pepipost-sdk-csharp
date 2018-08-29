# Step to integrate Pepipost C# .Net library with Visual Studio 2017 using Git (Without any package manager/Nuget)

If you are using Visual Studio for development and want to integrated with Pepipost directly by using Git, then below steps will help you in integrating this Pepipost C# code library in our IDE.

## Prerequisites

   * [Microsoft visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
   * [NETStandard.Library](https://www.nuget.org/packages/NETStandard.Library/)(>= 1.6.1)
   * [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
   * A free account on [Pepipost](https://app.pepipost.com/index.php/signup/registeruser).If you don't have a one, click here to sign-up and get 30,000 emails free every month.


## How to Build

 1. Download [Pepipost SDK](https://github.com/pepipost/pepipost-sdk-csharp/archive/master.zip)
   
    Unzip the SDK on any Location of your choice (we will unzipped in directory named testSDK)
            
    OR ```git clone https://github.com/pepipost/pepipost-sdk-csharp.git```
    
 2. For starting a new project, right click on the current solution from the *Solution Explorer* 
 
    Choose  *Add -> New Project*.
    
    ![s1](http://app1.falconide.com/integration_imgs/csharp-vs/final-1.png)
    
    ![s2](http://app1.falconide.com/integration_imgs/csharp-vs/final-2.png)
    
    ![s3](http://app1.falconide.com/integration_imgs/csharp-vs/final-3.png)
    
    ![s4](http://app1.falconide.com/integration_imgs/csharp-vs/final-4.png)
    
    ![s5](http://app1.falconide.com/integration_imgs/csharp-vs/final-5.png)

 3. Next, choose "Console Application", provide a *TestConsoleProject* as the project name and click *OK*.

    ![Set the new cosole project as the start up project](http://app1.falconide.com/integration_imgs/csharp-vs/final-6.png)

 4. **Set as startup project**

    The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project.
    
    To do this, right-click on the  *TestConsoleProject*
    
    Choose  *Set as StartUp Project* from the context menu.
    
    ![s7](http://app1.falconide.com/integration_imgs/csharp-vs/final-7.png)


 5. **Add reference of the library project**

    In order to use the Pepipost C# library in the new project, first we need to add a projet reference to the *TestConsoleProject*. 
    
    First, right click on the *References* node in the *Solution Explorer*
    
    Click *Add Reference*.

    ![This Opens the references for the TestConsoleProject](http://app1.falconide.com/integration_imgs/csharp-vs/final-8.png)

    Next, a window will be displayed where we must set the *Checkbox* on *PepipostAPI.Standard* 
    
    Click *OK*. 
    
    By doing this, we have added a reference of the *PepipostAPI.Standard* project into the new *TestConsoleProject*.

    ![Add a reference to the TestConsoleProject](http://app1.falconide.com/integration_imgs/csharp-vs/final-9.png)
 
 6. Once all the packages are installed and **TestConsoleProject** is created, a file named *Program.cs* will be visible in the *Solution Explorer* with an empty *Main* method.
 
   This is the entry point for the execution of the entire solution.

   Here, you can add [simpleUsage.md code](https://github.com/pepipost/pepipost-sdk-csharp/blob/master/simpleUsage.md) 

  ![Add a reference to the TestConsoleProject](http://app1.falconide.com/integration_imgs/csharp-vs/final-10.png)

 7. Update the api_key and FromEmail parameters:

      * apikey: This will be available under: Login to your Pepipost account -> Settings -> Integration
      * FromEmail: If your fromemail address is e.g. info@mydomain.com, then the Sending Domain mydomain need to be verified and active under your Pepipost account. You can manage the Sending Domain under: Login to Pepipost -> Settings -> Sending Domains
      
 8. Change apiKey and FromEmail in your script: 
   
      ```string apiKey = "XXXXX-your-api-key-XXXX" ``` (near by line no 25 if your have copy the simpleUsage.md)
           
      ```body_personalizations_0.Recipient = "your recipient emailid here"``` (near by line no 31)
     
      ```body.From.FromEmail = "info@ your-verified-domain"``` (near by line no 37)
     
  9.  Build the project to finally send your first test email Run the project.
  
      ![build](http://app1.falconide.com/integration_imgs/csharp-vs/final-11.png)
   
      Run the project by hiting **Ctrl + F5**
      
      If your apikey and sending domain is proper, then response message will be success.
  
      ![s7](http://app1.falconide.com/integration_imgs/csharp-vs/screen-15.png)

      
      Hope, you have received your first test email 😃
      
      If there is some problem related with config, then you will receive error message as shown below:
      
      ![mono10](http://app1.falconide.com/integration_imgs/csharp-mono/l10.png)
