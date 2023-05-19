// See https://aka.ms/new-console-template for more information
using System.Net.Mime;
using Flurl.Http;
using Flurl.Http.Testing;

//using var httpTest = new HttpTest();

//httpTest.RespondWith("hello", 500);

var http = new HttpClient();
var flurl = new FlurlClient(http);

var ret = await flurl.Request("https://postman-echo.com/post")
                     .PostJsonAsync(new
                     {
                         A = true,
                         B = "Hello",
                         C = new[]
                         {
                             "What"
                         }
                     });


