using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Comands
{
    class DriveInfoFileManager : AllCommands
    {
        public DriveInfoFileManager()
        {
            Name = "di";
            Description = "свойства диска";
        }
        public override void Execute()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                {
                    try
                    {
                        Console.WriteLine("Имя диска: " + drive.Name);
                        Console.WriteLine("Файловая система: " + drive.DriveFormat);
                        Console.WriteLine("Тип диска: " + drive.DriveType);
                        Console.WriteLine("Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
                        Console.WriteLine("Готов ли диск: " + drive.IsReady);
                        Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
                        Console.WriteLine("Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
                        Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);
                        Console.WriteLine("Метка тома диска: " + drive.VolumeLabel);
                    }
                    catch { }

                    Console.WriteLine();
                }
            }
        }
    }
}
