using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Services
{
    public interface ICommandAPIService
    {
        
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        
    }
}