using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patLab1
{
    public partial class Form1 : Form
    {
        private BindingList<Note> notes = new BindingList<Note>();

        public Form1()
        {
            InitializeComponent();
            listNotes.DataSource = notes;
            edContent.Visible = false;
            panelCheck.Visible = false;
        }

        private void btnNewText_Click(object sender, EventArgs e)
        {
            notes.Add(new TextNote());
            showNote(listNotes.SelectedItem as Note);
        }

        private void btnNewCheck_Click(object sender, EventArgs e)
        {
            notes.Add(new CheckNote());
            showNote(listNotes.SelectedItem as Note);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Pattern
            //Note copy = listNotes.SelectedItem as Note;
            //notes.Add(copy.Clone());

            //No Pattern
            if (listNotes.SelectedItem is TextNote)
            {
                TextNote copy = listNotes.SelectedItem as TextNote;
                notes.Add(new TextNote(copy.Title, copy.Content));
            }
            else if (listNotes.SelectedItem is CheckNote)
            {
                CheckNote copy = listNotes.SelectedItem as CheckNote;
                List<bool> blank = new List<bool>();
                for (int i = 0; i < copy.TaskName.Count; i++)
                {
                    blank.Add(false);
                }
                notes.Add(new CheckNote(copy.Title, copy.TaskName, blank));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            notes.RemoveAt(listNotes.SelectedIndex);
            showNote(listNotes.SelectedItem as Note);
        }

        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            showNote(listNotes.SelectedItem as Note);
        }

        private void edContent_Leave(object sender, EventArgs e)
        {
            TextNote selected = listNotes.SelectedItem as TextNote;
            selected.Content = edContent.Text;
        }

        private void edTitle_Leave(object sender, EventArgs e)
        {
            if (listNotes.SelectedItem != null)
            {
                Note selected = notes[listNotes.SelectedIndex];
                selected.Title = edTitle.Text;
                notes.Add(new TextNote());
                notes.RemoveAt(notes.Count - 1);
            }
        }

        private void showNote(Note note)
        {
            if (listNotes.SelectedItem is TextNote)
            {
                TextNote selected = listNotes.SelectedItem as TextNote;
                edTitle.Text = selected.Title;
                panelCheck.Visible = false;
                edContent.Visible = true;
                edContent.Text = selected.Content;
            }
            if (listNotes.SelectedItem is CheckNote)
            {
                CheckNote selected = listNotes.SelectedItem as CheckNote;
                edTitle.Text = selected.Title;
                edContent.Visible = false;
                panelCheck.Visible = true;
                listDone.Items.Clear();
                for (int i = 0; i < selected.TaskName.Count; i++)
                    listDone.Items.Add(selected.TaskName[i], selected.TaskDone[i]);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (edTaskName.Text != "")
            {
                CheckNote selected = listNotes.SelectedItem as CheckNote;
                selected.TaskName.Add(edTaskName.Text);
                selected.TaskDone.Add(false);
                listDone.Items.Add(edTaskName.Text, false);
                edTaskName.Text = "";
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listDone.SelectedIndex >= 0)
            {
                CheckNote selected = listNotes.SelectedItem as CheckNote;
                selected.TaskName.RemoveAt(listDone.SelectedIndex);
                selected.TaskDone.RemoveAt(listDone.SelectedIndex);
                listDone.Items.Remove(listDone.SelectedItem);
            }
        }

        private void listDone_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (listDone.SelectedIndex >= 0)
            {
                CheckNote selected = listNotes.SelectedItem as CheckNote;
                selected.TaskDone[listDone.SelectedIndex] = !selected.TaskDone[listDone.SelectedIndex];
            }
        }
    }
}
