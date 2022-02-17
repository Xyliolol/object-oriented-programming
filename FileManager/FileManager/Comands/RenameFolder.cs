using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Comands
{
    class FolderRename:AllCommands
    {
        public FolderRename()
        {
            Name = "rdir";
            Description = "переименование директории";
        }

        public override void Execute()
        {
            var path = Directory.GetCurrentDirectory();

            Console.WriteLine("какой фаил переименовать?");
            var vvod = Console.ReadLine();
            var a = $@"{path}\{vvod}";
            Console.WriteLine("как его назвать?");
            var b = Console.ReadLine();

            Microsoft.VisualBasic.FileIO.FileSystem.RenameDirectory(a, b);
        }
    }
}
