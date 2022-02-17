using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Comands
{
    class CreateFile:AllCommands
    {
        public CreateFile()
        {
            Name = "cf";
            Description = "создание файла";
        }
        public override void Execute()
        {
            var path = Directory.GetCurrentDirectory();

           
                File.Create(path);
            
        }
    }
}
