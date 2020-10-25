using System.Collections.Generic;
using WebApiCore3.Models;

namespace WebApiCore3.Data
{
    public class MockWebApiRepo : IWebApiRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

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

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}