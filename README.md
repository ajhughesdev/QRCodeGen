# QR Code Generator

QRCodeGen is the final project for the [Code Louisville](https://www.codelouisville.org) May 2022 Software Developer course 1 cohort. It is an Azure Function that runs locally and has been tested on a machine installed with Windows (64-bit) using [Visual Studio Code](https://visualstudio.microsoft.com/).
 
## Install Dependencies ##

- [.NET](https://download.visualstudio.microsoft.com/download/pr/c246f2b8-da39-4b12-b87d-bf89b6b51298/2d43d4ded4b6a0c4d1a0b52f0b9a3b30/dotnet-sdk-6.0.302-win-x64.exe ".NET 6.x.x Download")

- [Azure Functions Core Tools](https://go.microsoft.com/fwlink/?linkid=2174087 "Azure Functions Core Tools v4.x")

- [Azure CLI Tools](https://aka.ms/installazurecliwindows "Azure CLI Tools latest release")

Use the latest releases of these tools. You can check your current versions by running:

```bash
func --version
dotnet --version
az version
```

Clone the repo and move into the project folder:

```bash
git clone https://github.com/ajhughesdev/QRCodeGen
cd QRCodeGen
```

To start the generator, use the Azure CLI command:

```bash
func start
```

The first time will take a few moments to load so please be patient. Following a successful build, you should see a version of the following:

>
> ```bash
> Windows PowerShell
> Copyright (C) Microsoft Corporation. All rights reserved.
>
> Install the latest PowerShell for new features and improvements! https://aka.ms/PSWindows
>
> PS C:\Users\Andrew J Hughes\QRCodeGen> func start 
> MSBuild version 17.3.0-preview-22330-02+77c72dd0f for .NET
> Determining projects to restore...
> All projects are up-to-date for restore.
> C:\Users\Andrew J Hughes\QRCodeGen\QRCodeGen.cs(40,45): warning CS1998: This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread. [C:\Users\Andrew J Hughes\QRCodeGen\QRCodeGen.csproj]
> QRCodeGen -> C:\Users\Andrew J Hughes\QRCodeGen\bin\output\QRCodeGen.dll
>
> Build succeeded.
>
> C:\Users\Andrew J Hughes\QRCodeGen\QRCodeGen.cs(40,45): warning CS1998: This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread. [C:\Users\Andrew J Hughes\QRCodeGen\QRCodeGen.csproj]
>   1 Warning(s)
>   0 Error(s)
>
> Time Elapsed 00:00:04.07
>
>
>
> Azure Functions Core Tools
> Core Tools Version:       4.0.4653 Commit hash: N/A  (64-bit)
> Function Runtime Version: 4.6.1.18388
>
> [2022-07-29T11:44:57.328Z] Found C:\Users\Andrew J Hughes\QRCodeGen\QRCodeGen.csproj. Using for user secrets file configuration.
> 
> Functions:
>
>      Form: [GET] http://localhost:7071/api/Form
>
>      GenerateQRCode: [GET] http://localhost:7071/api/GenerateQRCode
>
> For detailed output, run func with --verbose flag.
> [2022-07-29T11:45:07.658Z] Executing 'Form' (Reason='This function was programmatically called via the host APIs.', Id=87867414-1380-45b4-bcd8-e321d7a7a499)
> [2022-07-29T11:45:07.696Z] Executed 'Form' (Succeeded, Id=87867414-1380-45b4-bcd8-e321d7a7a499, Duration=64ms)
> [2022-07-29T11:45:16.026Z] Executing 'GenerateQRCode' (Reason='This function was programmatically called via the host APIs.', Id=62af3e98-4f6c-46bb-a2cf-85a2a0f3cc8d)
> [2022-07-29T11:45:16.169Z] Generating QR Code for https://ajhughes.dev
> [2022-07-29T11:45:16.276Z] Executed 'GenerateQRCode' (Succeeded, Id=62af3e98-4f6c-46bb-a2cf-85a2a0f3cc8d, Duration=250ms)
> [2022-07-29T11:45:44.426Z] Executing 'GenerateQRCode' (Reason='This function was programmatically called via the host APIs.', Id=42a143ee-bd70-41d2-8c99-b48d025639f2)
> [2022-07-29T11:45:44.428Z] Generating QR Code for https://github.com/ajhughesdev
> [2022-07-29T11:45:44.434Z] Executed 'GenerateQRCode' (Succeeded, Id=42a143ee-bd70-41d2-8c99-b48d025639f2, Duration=7ms)
```

<p align="center">
<img src="./qr-code-generator.png" alt="screenshot of program" />
</p>
