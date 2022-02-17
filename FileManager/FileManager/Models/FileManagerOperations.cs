using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Functions
{
    internal abstract class FileSystemItemModel
    {

    }

    internal class DirectoryModel : FileSystemItemModel
    {
        private readonly DirectoryInfo _Directory;

        public string Name => _Directory.Name;

        public string Extension => _Directory.Extension;

        public bool Exist => _Directory.Exists;

        public DirectoryModel(string DirectoryPath) : this(new DirectoryInfo(DirectoryPath))
        {

        }

        public DirectoryModel(DirectoryInfo Directory) => _Directory = Directory;

        public DirectoryInfo[] GetDirectories(string? Mask = null)
        {
            if (Mask is null)
                return _Directory.GetDirectories();

            return _Directory.GetDirectories(Mask);
        }

        public FileInfo[] GetFiles(string? Mask = null)
        {
            if (Mask is null)
                return _Directory.GetFiles();

            return _Directory.GetFiles(Mask);
        }

        public IEnumerable<DirectoryModel> EnumerateDirectories(string? Mask = null)
        {
            var files = Mask is null
                ? _Directory.EnumerateDirectories()
                : _Directory.EnumerateDirectories(Mask);

            foreach (var directory in files)
                yield return (DirectoryModel)directory;
        }

        public IEnumerable<FileModel> EnumerateFiles(string? Mask = null)
        {
            if (Mask is null)
                return _Directory.EnumerateFiles().Select(file => new FileModel(file));

            return _Directory.EnumerateFiles(Mask).Select(file => new FileModel(file));
        }

        public IEnumerable<FileSystemItemModel> EnumerateContent(string? Mask = null)
        {
            var items = Mask is null
                ? _Directory.EnumerateFileSystemInfos()
                : _Directory.EnumerateFileSystemInfos(Mask);

            return items.Select<FileSystemInfo, FileSystemItemModel>(item => item switch
            {
                FileInfo file => new FileModel(file),
                DirectoryInfo dir => new DirectoryModel(dir),
                _ => throw new InvalidOperationException("Неподдерживаемый тип данных " + item.GetType())
            });
        }

        public static implicit operator DirectoryInfo(DirectoryModel model) => model._Directory;

        public static explicit operator DirectoryModel(DirectoryInfo dir) => new DirectoryModel(dir);
    }

    internal class FileModel : FileSystemItemModel
    {
        private readonly FileInfo _File;

        public string Name => _File.Name;

        public string Extension => _File.Extension;

        public bool Exist => _File.Exists;

        public FileModel(string FilePath) : this(new FileInfo(FilePath))
        {

        }

        public FileModel(FileInfo File)
        {
            _File = File;
        }

        public IEnumerable<string> EnumerateLines()
        {
            if (!_File.Exists)
                throw new FileNotFoundException("Файл не найден", _File.FullName);

            using var reader = _File.OpenText();
            while (!reader.EndOfStream)
                yield return reader.ReadLine()!;
        }
    }
}
