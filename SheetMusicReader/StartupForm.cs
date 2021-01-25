using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetMusicReader
{
    public partial class StartupForm : Form
    {

        public StartupForm()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; //Sets size mode of previeww box
            string[] splitFile;
            string[] splitPath;
            int count = 0;

            foreach (string file in fileList)
            {

                splitFile = file.Split(',');
                string temp = splitFile[0];
                splitPath = temp.Split('\\');
                listView1.Items[count].Text = splitPath[splitPath.Count() - 2];
                count++;
            }
        }

        string[] fileList = System.IO.File.ReadAllLines("recentFiles.ini"); //Sets global variable to path of the recent file log

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {;
            openFileTool.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png"; //Only allows the user to open image files
            openFileTool.Multiselect = true;
            if (openFileTool.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileTool.FileNames;
                loadForm();
            }



        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            if (listView1.FocusedItem.Text!= "-------------")
            {
                string[] hoveredFile = fileList[listView1.FocusedItem.Index].Split(',');
                loadPreview(hoveredFile[0]);
            }

        }

        private void loadPreview(string file)
        {
            pictureBox1.Image = Image.FromFile(file);
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.FocusedItem.Text != "-------------")
            {
                ListViewItem selectedItem = listView1.FocusedItem;
                string combinedPath;
                combinedPath = fileList[selectedItem.Index];
                filepath = combinedPath.Split(',');
                loadForm();
            }

        }
        string[] filepath;

        private void loadForm()
        {
            this.Hide();
            Form1.filepath = filepath;
            Form f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
