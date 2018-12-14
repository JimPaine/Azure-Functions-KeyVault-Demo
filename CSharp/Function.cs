using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace ImageProcessor
{
    public static class Function
    {     
        [FunctionName("KeyVaultDemoCSharp")]        
        public static IActionResult Check(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get")]HttpRequest request)
        {
            string secret = Environment.GetEnvironmentVariable("secret");
            return new OkObjectResult(secret);           
        }        
    }
}