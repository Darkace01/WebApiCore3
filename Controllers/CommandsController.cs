using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApiCore3.Data;
using WebApiCore3.DTOs;
using WebApiCore3.Models;

namespace WebApiCore3.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IWebApiRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(IWebApiRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDTO>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(commandItems));
        }

        //GET api/commands/{id}
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDTO> GetCommandById(int Id)
        {
            var commandItem = _repository.GetCommandById(Id);

            if (commandItem != null)
                return Ok(_mapper.Map<CommandReadDTO>(commandItem));
            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<CommandReadDTO> CreateCommand([FromBody] CommandCreateDTO commandCreateDTO)
        {
            var commandModal = _mapper.Map<Command>(commandCreateDTO);
            _repository.CreateCommand(commandModal);
            _repository.SaveChanges();

            var commandReadDTO = _mapper.Map<CommandReadDTO>(commandModal);

            return CreatedAtRoute(nameof(GetCommandById), new { Id = commandReadDTO.Id }, commandReadDTO);
        }

        //PUT api/commands/{Id}
        [HttpPut("{Id}")]
        public ActionResult UpdateCommand(int Id, CommandUpdateDTO commandUpdateDTO)
        {
            var commandModalFromRepo = _repository.GetCommandById(Id);
            if (commandModalFromRepo == null)
                return NotFound();

            _mapper.Map(commandUpdateDTO, commandModalFromRepo);

            _repository.UpdateCommand(commandModalFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/commands/{Id}
        [HttpPatch("{Id}")]
        public ActionResult PartialCommandUpdate(int Id, JsonPatchDocument<CommandUpdateDTO> patchDoc)
        {
            var commandModalFromRepo = _repository.GetCommandById(Id);
            if (commandModalFromRepo == null)
                return NotFound();

            var commandToPatch = _mapper.Map<CommandUpdateDTO>(commandModalFromRepo);
            patchDoc.ApplyTo(commandToPatch, ModelState);
            if (!TryValidateModel(commandToPatch))
                return ValidationProblem(ModelState);

            _mapper.Map(commandToPatch, commandModalFromRepo);
            _repository.UpdateCommand(commandModalFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}