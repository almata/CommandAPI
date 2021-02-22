using System;
using System.Collections.Generic;
using System.Linq;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext context;

        public SqlCommandAPIRepo(CommandContext context)
        {
            this.context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            context.CommandItems.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            context.CommandItems.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return context.CommandItems.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() >= 0;
        }

        public void UpdateCommand(Command cmd)
        {
            // We don't need to do anything here thanks to EF Core.
        }
    }
}