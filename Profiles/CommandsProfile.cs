using AutoMapper;
using WebApiCore3.DTOs;
using WebApiCore3.Models;

namespace WebApiCore3.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDTO>();
        }
    }
}