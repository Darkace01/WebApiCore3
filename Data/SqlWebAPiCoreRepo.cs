using System;
using System.Collections.Generic;
using System.Linq;
using WebApiCore3.Models;

namespace WebApiCore3.Data
{
    public class SqlWebApiCoreRepo : IWebApiRepo
    {
        private readonly WebApiCoreContext _ctx;

        public SqlWebApiCoreRepo(WebApiCoreContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateCommand(Command command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            _ctx.Commands.Add(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _ctx.Commands.ToList();
        }

        public Command GetCommandById(int Id)
        {
            return _ctx.Commands.FirstOrDefault(p => p.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command command)
        {
            //Do Nothing for update
        }
    }
}