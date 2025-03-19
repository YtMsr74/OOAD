﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace patlab2
{
    internal class CompFile : Component
    {
        long Size;
        public CompFile(string path)
        {
            FileInfo file = new FileInfo(path);
            Name = file.Name;
            Size = file.Length;
        }
        public override long GetSize()
        {
            return Size;
        }
    }
}
