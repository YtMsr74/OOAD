using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patLab1
{
    internal class CheckNote : Note
    {
        public List<bool> TaskDone;
        public List<string> TaskName;

        public CheckNote()
        {
            Title = "Title";
            TaskName = new List<string>();
            TaskDone = new List<bool>();
        }

        public CheckNote(string title, List<string> name, List<bool> done)
        {
            Title = title;
            TaskName = name.ToList();
            TaskDone = done.ToList();
        }

        /*public override Note Clone()
        {
            List<bool> blank = new List<bool>();
            for (int i = 0; i < TaskName.Count; i++)
            {
                blank.Add(false);
            }
            return new CheckNote(this.Title, this.TaskName, blank);
        }*/
    }
}
