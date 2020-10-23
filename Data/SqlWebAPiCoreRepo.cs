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

        public IEnumerable<Command> GetAllCommands()
        {
            return _ctx.Commands.ToList();
        }

        public Command GetCommandById(int Id)
        {
            return _ctx.Commands.FirstOrDefault(p => p.Id == Id);
        }
    }
}