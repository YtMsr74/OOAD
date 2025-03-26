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

        private long ShowFiles(CompFolder c, string line)
        {
            long size = 0;
            gridResult.Rows.Add(line + c.Name, "", c);
            int row_ind = gridResult.Rows.Count - 1;
            foreach (CompFile i in c.Files)
            {
                size += i.Size;
            }
            foreach(CompFolder i in c.Folders)
            {
                size += ShowFiles(i, line + "-");
            }
            size = size / 1024 + 1;
            foreach (CompFile i in c.Files)
            {
                gridResult.Rows.Add(line + "-" + i.Name, (i.Size / 1024 + 1).ToString() + " KB", i);
            }
            gridResult.Rows[row_ind].Cells[1].Value = size.ToString() + " KB";
            return size;
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
                    folder.Files.Add(new CompFile(path));
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
                gridResult.Rows.Clear();
                CompFolder root = new CompFolder(path);
                CreateFolders(root, path);
                foreach (string i in Directory.GetFiles(path))
                {
                    root.Files.Add(new CompFile(i));
                }
                ShowFiles(root, "");
                curPath = path;
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void CreateFolders(CompFolder f, string path)
        {
            foreach(string i in Directory.GetDirectories(path))
            {
                CompFolder newfolder = new CompFolder(i);
                f.Folders.Add(newfolder);
                CreateFolders(newfolder, i);
            }
            foreach (string i in Directory.GetFiles(path))
            {
                f.Files.Add(new CompFile(i));
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            labelFile.Visible = false;
        }
    }
}
