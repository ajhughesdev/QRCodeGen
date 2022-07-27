using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace QRCodeGen
{
  public static class QRCodeGen
  {
    [FunctionName("GenerateQRCode")]
    public static async Task<string> Generate(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req, ILogger log)
    {
      // get QR text from query string 
      string qrtext = req.Query["qrtext"];
      log.LogInformation("Generating QR Code for {0}", qrtext);
    }

  }
}
