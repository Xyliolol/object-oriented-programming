using FileManager.Comands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{

    public class HelpCommand : AllCommands
    {
        public HelpCommand()
        {
            Name = "help";
            Description = "Помощь";
        }
        public override void Execute()
        {
            foreach (var (name, command) in Program.Commands)
            {
                Console.WriteLine("\t{0}\t-\t{1}", name, command.Description);
            }

        }
    }
}
