using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace LibraryManagementSystem.FunctionApp;

public static class Function1
{
    [FunctionName("Function1")]
    public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# in-process HTTP trigger function processed a request.");
        return new OkObjectResult("Hello from In-Process!");
    }
}
