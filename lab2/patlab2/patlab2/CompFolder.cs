using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab2
{
    internal class CompFolder : Component
    {
        private List<Component> Children = new List<Component>();

        public CompFolder(string path)
        {
            Path = path;
            Name = new FileInfo(path).Name;
            foreach (string i in Directory.GetDirectories(path))
            {
                Children.Add(new CompFolder(i));
            }
            foreach (string i in Directory.GetFiles(path))
            {
                Children.Add(new CompFile(i));
            }
        }
        public void Add(Component child)
        {
            Children.Add(child);
        }
        public List<Component> GetChildren()
        {
            return Children;
        }
        public override long GetSize()
        {
            long size = 0;
            foreach (var i in Children)
            {
                size += i.GetSize();
            }
            return size;
        }
    }
}
