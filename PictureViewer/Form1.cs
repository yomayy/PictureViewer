using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        List<string> pathes;

        public Form1()
        {
            InitializeComponent();
            pathes = new List<string>();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///dz
            int i = FileListBox.SelectedIndex;
            if(i == -1)
                MessageBox.Show("Вы не выбрали изображение", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int N = pathes.Count;
                if (i == 0)
                    i = N - 1;
                else
                    i--;
                FileListBox.SelectedIndex = i;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Open_item_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] fi1 = di.GetFiles("*.jpg");
                FileInfo[] fi2 = di.GetFiles("*.png");
                FileInfo[] fi3 = di.GetFiles("*.gif");

                FileListBox.Items.Clear();
                pathes.Clear();


                foreach (FileInfo f in fi1)
                {
                    FileListBox.Items.Add(f.Name);
                    pathes.Add(f.FullName);
                }
                foreach (FileInfo f in fi2)
                {
                    FileListBox.Items.Add(f.Name);
                    pathes.Add(f.FullName);
                }
                foreach (FileInfo f in fi3)
                {
                    FileListBox.Items.Add(f.Name);
                    pathes.Add(f.FullName);
                }

                //MessageBox.Show(path);
            }

            //MessageBox.Show("Open", "Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Canvas_Click(object sender, EventArgs e)
        {

        }

        private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = FileListBox.SelectedIndex;
            Image img = Image.FromFile(pathes[k]);
            Canvas.Image = img;
        }

        private void Forw_button_Click(object sender, EventArgs e)
        {
            int k = FileListBox.SelectedIndex;
            if (k == -1)
                MessageBox.Show("Вы не выбрали изображение", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int N = pathes.Count;
                if (k == N - 1)
                    k = 0;
                else
                    k++;
                FileListBox.SelectedIndex = k;
            }
        }

        private void Start_but_Click(object sender, EventArgs e)
        {
            int k = FileListBox.SelectedIndex;
            if (k == -1)
            {
                MessageBox.Show("Вы не выбрали изображение", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Stop();
            }
            else
            {
                timer1.Start();
                timer1.Interval = (int)Delay.Value * 1000;
            }  
        }

        private void Stop_but_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int k = FileListBox.SelectedIndex;
                int N = pathes.Count;
                if (k == N - 1)
                    k = 0;
                else
                    k++;
                FileListBox.SelectedIndex = k;
        }

        private void Close_item_Click(object sender, EventArgs e)
        {
            FileListBox.Items.Clear();
            Canvas.Image = Image.FromFile(@"..\..\Images\image.png");
        }

        private void Exit_item_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_but_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                FileListBox.SelectedIndex = 0;
                Canvas.Image = Image.FromFile(@"..\..\Images\image.png");
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex);
            }
        }
    }
}
