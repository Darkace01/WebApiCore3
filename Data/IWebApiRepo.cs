using System.Collections.Generic;
using WebApiCore3.Models;

namespace WebApiCore3.Data
{
    public interface IWebApiRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int Id);
        void CreateCommand(Command command);
    }
}