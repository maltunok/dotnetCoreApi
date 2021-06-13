

using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Database
{
    public class CommandContext: DbContext
    {
       public CommandContext(DbContextOptions<CommandContext> options):base(options)
       {

       }
       public DbSet<Command> CommandItems{get; set;}
    }
}