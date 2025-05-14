using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab4
{
    internal class Vehicle
    {
        public int id;
        public string name;
        public int year;
        public string country;
        public string engine;
        public string layout;
        public string weight;
        public Image image; 

        public Vehicle(int id, string name, int year, string country, string engine, string layout, string weight, string path)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.country = country;
            this.engine = engine;
            this.layout = layout;
            this.weight = weight;
            this.image = Image.FromFile(path);
        }
    }
}
