using System.Collections.Generic;
using CommandAPI.Database;
using CommandAPI.Models;
using CommandAPI.Services;
using System.Linq;

namespace CommandAPI.Services
{
    public class CommandAPIService : ICommandAPIService
    {
        private readonly CommandContext _context;
        public CommandAPIService (CommandContext context)
        {
            _context = context;
        }
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is CommandAPIService service &&
                   EqualityComparer<CommandContext>.Default.Equals(_context, service._context);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }
        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p=>p.Id==id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}