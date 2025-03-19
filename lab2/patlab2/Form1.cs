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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string path = edPath.Text;
            if (Directory.Exists(path))
            {
                labelError.Visible = false;
                string line = "";
                gridResult.Rows.Clear();
                CompFolder root = new CompFolder(path);
                ShowFiles(root,line);
            }
            else
            {
                labelError.Visible = true;
            }
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
            gridResult.Rows.Add(line + c.Name, size.ToString() + " KB");
            if (c is CompFolder)
            {
                CompFolder folder = (CompFolder)c;
                foreach (Component child in folder.GetChildren())
                {
                    ShowFiles(child, line + '-');
                }
            }
        }
    }
}
