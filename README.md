# QR Code Generator

<p style="font-size: 20px; font-weight: 300">
QRCodeGen is the final project for the <a href="https://www.codelouisville.org">Code Louisville</a> May 2022 Software Developer course 1 cohort. It is an Azure Function that runs locally and has been tested on a machine installed with Windows 64-bit using Visual Studio.
<p>

## Install Dependencies ##

- [.NET](https://download.visualstudio.microsoft.com/download/pr/c246f2b8-da39-4b12-b87d-bf89b6b51298/2d43d4ded4b6a0c4d1a0b52f0b9a3b30/dotnet-sdk-6.0.302-win-x64.exe ".NET 6.x.x Download")

- [Azure Functions Core Tools](https://go.microsoft.com/fwlink/?linkid=2174087 "Azure Functions Core Tools v4.x")

- [Azure CLI Tools](https://aka.ms/installazurecliwindows "Azure CLI Tools latest release")

<p style="font-size: 20px; font-weight: 300">
Check your current versions by running

```
func --version

dotnet --version

az version
```

</p>

```bash
func start --csharp
```

<p align="center">
<img src="./qr-code-generator.png" alt="screenshot of program" />
</p>
