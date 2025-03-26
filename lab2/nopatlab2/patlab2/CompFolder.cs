using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab2
{
    internal class CompFolder
    {
        public string Name;
        public string Path;
        public List<CompFolder> Folders = new List<CompFolder>();
        public List<CompFile> Files = new List<CompFile>();

        public CompFolder(string path)
        {
            Path = path;
            Name = new FileInfo(path).Name;
        }
    }
}
