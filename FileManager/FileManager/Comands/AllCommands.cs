using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Comands
{
   public abstract class AllCommands
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public abstract void Execute();
    }
}
