![pepipostlogo](https://pepipost.com/assets/img/pepipost-footLogo.png)

[![NuGet](https://img.shields.io/nuget/v/Pepipost.svg)](https://www.nuget.org/packages/Pepipost)
[![Open Source Helpers](https://www.codetriage.com/pepipost/pepipost-sdk-csharp/badges/users.svg)](https://www.codetriage.com/pepipost/pepipost-sdk-csharp)
[![MIT licensed](https://img.shields.io/badge/license-MIT-blue.svg)](./LICENSE.txt)
[![Twitter Follow](https://img.shields.io/twitter/follow/pepi_post.svg?style=social&label=Follow)](https://twitter.com/pepi_post)


# Official C# Code library for [Pepipost](http://www.pepipost.com/?utm_campaign=GitHubSDK&utm_medium=GithubSDK&utm_source=GithubSDK)

## Overview

This library contains methods for easily interacting with the Pepipost Email Sending API to send emails within few seconds.

We are trying to make our libraries Community Driven- which means we need your help in building the right things in proper order we would request you to help us by sharing comments, creating new [issues](https://github.com/pepipost/pepipost-sdk-csharp/issues) or [pull requests](https://github.com/pepipost/pepipost-sdk-csharp/pulls).

We welcome any sort of contribution to this library.

The latest 2.5.0 version of this library provides is fully compatible with the latest Pepipost v2.0 API.

For any update of this library check [Releases](https://github.com/pepipost/pepipost-sdk-csharp/releases).

# Table of Content
  
* [Installation](#installation)
* [Quick Start](#quick-start)
* [Usage](#usage)
* [Announcements](#announcements)
* [Roadmap](#roadmap)
* [About](#about)
* [License](#license)

<a name="installation"></a>
# Installation

## Prerequisites

   * [Microsoft visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
   * [NETStandard.Library](https://www.nuget.org/packages/NETStandard.Library/)(>= 1.6.1)
   * [Pepipost](https://www.nuget.org/packages/Pepipost/)
   * A free account on [Pepipost](https://app.pepipost.com/index.php/signup/registeruser). If you don't have a one, click here to sign-up and get 30,000 emails free every month.
   
## IDE Specific installation

In order to use Pepipost C# library you can either directly download [Pepipost C# .NET library from our GIT Repo]() or if you have Nuget Package manager installed, you can search and download Pepipost from the package manager.
  
Pepipost C# .NET library is compatible with Windows Forms, Windows RT, Windows Phone 8, Silverlight 5, Xamarin iOS, Xamarin Android and Mono.
  
We have demonstrated the installation with two IDEs which consists of Mono-Develop and Visual Studio 2017. We welcome contribution for other IDEs.
  
1. Installation using Mono-Develop
  
    * [Using Nuget package manager](https://github.com/pepipost/pepipost-sdk-csharp/blob/master/Mono-installation-nuget.md). 
  
    * [Using Github Repository](https://github.com/pepipost/pepipost-sdk-csharp/blob/master/Mono-installation-SDK.md)

1. Installation using Microsoft Visual Studio
  
    * [Using Nuget Package manager](#quick-start)
    
    * [Using GitHub Reposistory](https://github.com/pepipost/pepipost-sdk-csharp/blob/master/visual-studio-installation.md)
    
<a name="quick-start"></a>
# Quick Start

## How to Build- Using Nuget Package Manager on MS Visual Studio
  
  1. Start Microsoft Visual Studio 2017
  
     **File -> New -> Project**
  
     ![s1](http://app1.falconide.com/integration_imgs/csharp-vs/screen-1.png)
     
     
  2. Give desired name to your project:
    
     *TestConsoleProject recommended* 
  
     ![s2](http://app1.falconide.com/integration_imgs/csharp-vs/screen-2.png)
     
     
  3. Installing dependencies through Nuget Package installer:
  
     ![s3](http://app1.falconide.com/integration_imgs/csharp-vs/screen-3.png)
     
     Browse and Search for **Pepipost - The Official C# library**
     
     ![s4](http://app1.falconide.com/integration_imgs/csharp-vs/screen-4.png)
     
   
  4. Install the selected package:
    
     ![s5](http://app1.falconide.com/integration_imgs/csharp-vs/screen-5.png)
     
     
  5. Once all packages are install the solution explorer will look like below:
  
     ![s6](http://app1.falconide.com/integration_imgs/csharp-vs/screen-6.png)

     Just copy and paste the simpleUsage.md in your program.cs file present in your project.

     build the project shown below OR by clicking **ctrl + shift + F5**
     
  
  6. Update the **api_key** and **FromEmail** parameters
  
      * apikey: This will be available under: Login to your Pepipost account -> Settings -> Integration
      * FromEmail: If your fromemail address is e.g. info@mydomain.com, then the Sending Domain mydomain need to be verified and active under your Pepipost account. You can manage the Sending Domain under: Login to Pepipost -> Settings -> Sending Domains
   
     ```string apiKey = "XXXXX-your-api-key-XXXX" ``` (near by line no 25 if you have copied the simpleUsage.md)
           
     ```body_personalizations_0.Recipient = "your recipient emailid here"``` (near by line no 31)
     
     ```body.From.FromEmail = "info@ your-verified-domain"``` (near by line no 37)
     
     
   7. Build the project to finally send your first test email
      Run the project.

      If your apikey and sending domain is proper response message will be success
      
      ![s7](http://app1.falconide.com/integration_imgs/csharp-vs/screen-15.png)
     
     
    
<a name="announcements"></a>
# Announcements

v2.5.0 has been released! Please see the [release notes](https://github.com/pepipost/pepipost-sdk-csharp/releases/tag/v2.5.0) for details.

All updates to this library are documented in our [releases](https://github.com/pepipost/pepipost-sdk-csharp/releases). For any queries, feel free to reach out us at dx@pepipost.com

<a name="roadmap"></a>
## Roadmap

If you are interested in the future direction of this project, please take a look at our open [issues](https://github.com/pepipost/pepipost-sdk-csharp/issues) and [pull requests](https://github.com/pepipost/pepipost-sdk-csharp/pulls). We would love to hear your feedback.

<a name="about"></a>
## About
pepipost-csharp-sdk library is guided and supported by the Pepipost Developer Experience Team.
This pepipost-csharp-sdk library is maintained and funded by Pepipost Ltd. The names and logos for pepipost-csharp-sdk are trademarks of Pepipost Ltd.

<a name="license"></a>
## License
This code library was semi-automatically generated by APIMATIC v2.0 and licensed under The MIT License (MIT). 

