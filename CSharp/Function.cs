using System;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace ImageProcessor
{
    public static class Function
    {     
        [FunctionName("CSharp")]        
        public static HttpResponseMessage Check(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get")]HttpRequestMessage request)
        {
            string secret = Environment.GetEnvironmentVariable("secret");
            return request.CreateResponse(HttpStatusCode.OK, secret);           
        }   
    }
}