
using Microsoft.AspNetCore.Mvc;

namespace JoelStore.Controller;

public class ErrorsController : ControllerBase
{
   [Route("/error")]
   public IActionResult Error()
   {
        return Problem();
   }
}