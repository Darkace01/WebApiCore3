using System.Collections.Generic;
using WebApiCore3.Models;

namespace WebApiCore3.Data
{
    public interface IWebApiRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int Id);
    }
}