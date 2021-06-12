using  System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Models;
using CommandAPI.Services;




namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
      private readonly ICommandAPIService _commandAPIService;

        public CommandsController (ICommandAPIService commandAPIService)
      {
        _commandAPIService = commandAPIService;
      }


      [HttpGet]
      public ActionResult<IEnumerable<Command>> GetAllCommands()
      {
          var allCommands = _commandAPIService.GetAllCommands();
          return Ok (allCommands);
      }
     
    }
}