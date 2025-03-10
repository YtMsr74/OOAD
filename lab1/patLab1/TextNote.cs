using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace patLab1
{
    internal class TextNote : Note
    {
        public string Content;

        public TextNote()
        {
            Title = "Title";
            Content = "Content";
        }
        public TextNote(string title, string content)
        {
            Title = title;
            Content = content;
        }
        /*public override Note Clone()
        {
            return new TextNote(this.Title, this.Content);
        }
        */
    }
}
