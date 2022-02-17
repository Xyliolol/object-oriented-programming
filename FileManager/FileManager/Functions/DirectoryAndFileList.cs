using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Functions
{
    class DirectoryAndFileList
    {
        public DirectoryAndFileList()
        {
            string path = @"C:\";
            string[] root_folder = Directory.GetDirectories(path);
            foreach (string fn in root_folder)
            {
                Console.WriteLine(fn);
            }

        }
    }
}
