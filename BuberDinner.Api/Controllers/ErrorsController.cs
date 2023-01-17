using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>();
        var exception = exceptionHandlerFeature?.Error;
        var path = exceptionHandlerFeature?.Path;

        var problemResult = Problem(
            instance: path,
            statusCode: StatusCodes.Status500InternalServerError,
            title: "An unexpected error occured.");

        var problemDetails = problemResult.Value as ProblemDetails;
        //problemDetails.Extensions.Add("customProperty2", "customValue2");

        return problemResult;
    }
}