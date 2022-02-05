using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Comands
{
    class CreateFolder : AllCommands
    {
        public CreateFolder()
        {
            Name = "cd";
            Description = "создание дирректории";
        }
        public override void Execute()
        {
            var path = Directory.GetCurrentDirectory();          

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
