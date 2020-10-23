using System.Collections.Generic;
using WebApiCore3.Models;

namespace WebApiCore3.Data
{
    public interface IWebApiRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int Id);
    }
}