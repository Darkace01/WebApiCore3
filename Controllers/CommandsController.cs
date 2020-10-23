using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApiCore3.Data;
using WebApiCore3.Models;

namespace WebApiCore3.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IWebApiRepo _repository;

        public CommandsController(IWebApiRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockWebApiRepo _repository = new MockWebApiRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int Id)
        {
            var commandItem = _repository.GetCommandById(Id);

            return Ok(commandItem);
        }
    }
}