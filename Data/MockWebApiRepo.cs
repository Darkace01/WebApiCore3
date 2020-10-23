using System.Collections.Generic;
using WebApiCore3.Models;

namespace WebApiCore3.Data
{
    public class MockWebApiRepo : IWebApiRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kattle & Pan"},
                new Command{Id = 1, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kattle & Pan"},
                new Command{Id = 2, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kattle & Pan"},
            };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kattle & Pan" };
        }
    }
}