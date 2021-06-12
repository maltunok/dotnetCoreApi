using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Services
{
    public class CommandAPIService : ICommandAPIService
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{
                    Id=0, HowTo="How to generate a migration", 
                    CommandLine= "dotnet ef migrations add <name of migration>",
                    Platform=".net core ef"
                },
                new Command{
                    Id=1, HowTo="run migrations", 
                    CommandLine= "dotnet ef database update",
                    Platform=".net core ef"
                },
                  new Command{
                    Id=2, HowTo="list migrations", 
                    CommandLine= "dotnet ef migrations list",
                    Platform=".net core ef"
                },
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {
                  Id=2, HowTo="list migrations", 
                    CommandLine= "dotnet ef migrations list",
                    Platform=".net core ef"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}