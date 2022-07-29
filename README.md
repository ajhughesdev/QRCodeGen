# QR Code Generator

QRCodeGen is the final project for the [Code Louisville](https://www.codelouisville.org) May 2022 Software Developer course 1 cohort. It is an Azure Function that runs locally and has been tested on a machine installed with Windows (64-bit) using [Visual Studio Code](https://visualstudio.microsoft.com/).
 
## Install Dependencies ##

- [.NET](https://download.visualstudio.microsoft.com/download/pr/c246f2b8-da39-4b12-b87d-bf89b6b51298/2d43d4ded4b6a0c4d1a0b52f0b9a3b30/dotnet-sdk-6.0.302-win-x64.exe ".NET 6.x.x Download")

- [Azure Functions Core Tools](https://go.microsoft.com/fwlink/?linkid=2174087 "Azure Functions Core Tools v4.x")

- [Azure CLI Tools](https://aka.ms/installazurecliwindows "Azure CLI Tools latest release")

Use the latest releases of these tools. You can check your current versions by running:

```powershell
func --version
dotnet --version
az version
```

Clone the repo and move into the project folder:

```powershell
git clone https://github.com/ajhughesdev/QRCodeGen
cd QRCodeGen
```

To start the generator, use the Azure CLI command:

```powershell
func start
```

The first time will take a few moments to load so please be patient. Following a successful build, you should see a version of the following:


>```powershell
>Azure Functions Core Tools
>Core Tools Version:       4.0.4653 Commit hash: N/A  (64-bit)
>Function Runtime Version: 4.6.1.18388
>
>[2022-07-29T11:44:57.328Z] Found C:\Users\Andrew J Hughes\QRCodeGen\QRCodeGen.csproj. Using for user secrets file configuration.
>
>Functions:
>
>       Form: [GET] http://localhost:7071/api/Form
>
>       GenerateQRCode: [GET] http://localhost:7071/api/GenerateQRCode
>
>For detailed output, run func with --verbose flag.
>```

Navigate to 

```powershell
http://localhost:{PORT}/api/Form
```

`{PORT}` being replaced with the port number randomly assigned by Azure.


## Project Requirements ##

1. "Read data from an external file, such as text, JSON, CSV, etc and use that data in your application."
  

```cs
string indexPage = File.ReadAllText(context.FunctionAppDirectory + "/www/index.html");
```

The `ReadAllText` method opens a text file, reads all the text in the file, and then closes the file. It returns a string containing all the text in the `index.html` file which we then add to the content section of our `HttpResponseMessage`'s header. 

<br />

2. "Build a conversion tool that converts user input to another type and displays it (ex: converts cups to grams)."

```cs
// get QR text from query string 
string qrtext = req.Query["qrtext"];
log.LogInformation("Generating QR Code for {0}", qrtext);

var qr = QrCode.EncodeText(qrtext, QrCode.Ecc.Medium);
// convert it into a byte array for PNG output
var pngout = qr.ToPng(10, 1, SkiaSharp.SKColors.Black, SkiaSharp.SKColors.White);
```

There are two conversions happening here. 1) using the `EncodeText` method of the `QrCode` class, we encode the text from the query string into a QR code. We then convert the QR code into a PNG image using the `ToPng` method. 2) the byte array returned for the PNG output is converted to a base64 string and added to the `ReturnObject`.

<br />

3. see above!
   
<br />

4. "Visualize data in a graph, chart, or other visual representation of data."

 The `ToPng` method returns a bitmap representing this QR code.



<br /><br />


<p align="center">
<img src="./qr-code-generator.png" alt="screenshot of program" />
</p>
