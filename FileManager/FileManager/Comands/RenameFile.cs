using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileManager.Comands
{
    class FileRename : AllCommands
    {
        public FileRename()
        {
            Name = "rfile";
            Description = "переименование файла";
        }

        public override void Execute()
        {
              
              var path =  Directory.GetCurrentDirectory();

              Console.WriteLine("какой фаил переименовать?");
              var vvod = Console.ReadLine();
              var a = $@"{path}\{vvod}";

              Console.WriteLine("как его назвать?");
              var b = Console.ReadLine();

            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(a, b);
         
        }
    }
}