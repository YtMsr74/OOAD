using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patlab2
{
    public partial class Form1 : Form
    {
        string curPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            Analyze();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                edPath.Text = fbd.SelectedPath;
            }
        }

        private void ShowFiles(Component c, string line)
        {
            long size = c.GetSize() / 1024 + 1;
            gridResult.Rows.Add(line + c.Name, size.ToString() + " KB", c);

            if (c is CompFolder)
            {
                CompFolder folder = (CompFolder)c;
                foreach (Component child in folder.GetChildren())
                {
                    ShowFiles(child, line + '-');
                }
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string filename = edFileName.Text;
            if (gridResult.CurrentRow != null && gridResult.CurrentRow.Cells[2].Value is CompFolder)
            {
                CompFolder folder = gridResult.CurrentRow.Cells[2].Value as CompFolder;
                string path = folder.Path + "\\" + filename;
                try
                {
                    File.Create(path);
                    folder.Add(new CompFile(path));
                    Analyze();
                    labelFile.Visible = false;
                }
                catch(Exception er)
                {
                    labelFile.Text = "Ошибка: " + er.Message;
                    labelFile.Visible = true;
                }
            }
            else
            {
                labelFile.Text = "Ошибка: Папка не выбрана";
                labelFile.Visible = true;
            }
        }

        private void Analyze()
        {
            string path = edPath.Text;
            if (Directory.Exists(path))
            {
                labelError.Visible = false;
                string line = "";
                gridResult.Rows.Clear();
                CompFolder root = new CompFolder(path);
                ShowFiles(root, line);
                curPath = path;
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            labelFile.Visible = false;
        }
    }
}
