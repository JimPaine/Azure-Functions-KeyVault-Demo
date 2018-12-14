using System;
using System.Net;

public static HttpResponseMessage Run(HttpRequestMessage request)
{
    string secret = Environment.GetEnvironmentVariable("secret");
    return request.CreateResponse(HttpStatusCode.OK, secret);           
} 