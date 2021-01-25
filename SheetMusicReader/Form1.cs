using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetMusicReader
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Default Form Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            tableImagePanel.AutoScroll = true;
            tableImagePanel.AutoSize = false;
            viewDropDown.Width = 150;
            zoomValue = 0;
            viewDropDown.SelectedItem = "Side By Side"; //Sets the default view of the program
            loadPrefs();
            updateFiles();

            if (filepath != null && filepath.Length != 0 && filepath[0] != "openFileDialog2")
            {
                loadPics(zoomValue);
            }

        }

        #region Buttons and controls
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }


        private void menuItem3_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// The 'Open' button in the menu bar
            /// Calls the Open File Dialog function, so that the user can open pick a file
            /// </summary>
            openFileTool.Filter = "Image Files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png"; //Only allows the user to open image files
            openFileTool.Multiselect = true;
            openFileTool.ShowDialog(); //Opens the file picker dialog
            filepath = openFileTool.FileNames;
            string[] fileList;
            updateFiles();
            loadPics(zoomValue); //Calls the method to refresh the picture box

        }

        private void openFileDialog1(object sender, CancelEventArgs e)
        {
        }

        private void printButton_Click(object sender, EventArgs e) //When print button is clicked
        {
            PrintDocument pd = new PrintDocument(); //create new instance of PrintDocument
            if (filepath != null && filepath.Length != 0 && filepath[0] != "openFileDialog2") //Check if a file has been selected
            {
                _page = 0;
                pd.PrintPage += new PrintPageEventHandler(PrintPage); //Call PrintPage and add pages to be printed to the PrintDocument

/*                PrintPreviewDialog ppv = new PrintPreviewDialog(); //Create new instance of PrintPreview
                ppv.Document = pd; //Link PrintPreview to the document to be printed
                ppv.ShowDialog(); //Show the print preview dialog
*/
                _page = 0;
                PrintDialog pdlg = new PrintDialog(); //Create new instance of the PrintDialog
                pdlg.Document = pd; //Link PrintDialog to the document
                DialogResult result = pdlg.ShowDialog(); //Show the print dialog and store whether the user clicks 'OK' or not
                if (result == DialogResult.OK) //The user clicked 'OK' then print the document 
                {
                    pd.Print();
                }
            }
            else
            {
                MessageBox.Show("No file has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int _page;
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Image img = Image.FromFile(filepath[_page]);

            e.Graphics.DrawImage(img, new Rectangle(0,0,img.Width,img.Height));
            e.HasMorePages = ++_page < filepath.Length;
            e.Graphics.Dispose();
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //When the about button is clicked
        private void menuAbout_Click(object sender, EventArgs e)
        {
            //A message box pops up with information about the program
            MessageBox.Show("Take your time.\n\nCreated by Drew Edgar.", "About", MessageBoxButtons.OK);
        }

        private void viewDropDown_Click(object sender, EventArgs e)
        {

        }

        private void viewDropDown_Change(object sender, EventArgs e) //Event fires if the drop down box is opened then closed
        {
            loadPics(zoomValue);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItem1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            zoomValue = trackBar1.Value;
            loadPics(zoomValue);
        }

        private void menuItem3_Click_1(object sender, EventArgs e)
        {
            ColorDialog bgDialog = new ColorDialog(); //Create new instance of colour picker box
            bgDialog.AllowFullOpen = true; //Allow custom colours to be used
            bgDialog.FullOpen = true; //Show cutom colour tab when box is opened
            bgDialog.Color = tableImagePanel.BackColor;
            if (bgDialog.ShowDialog() == DialogResult.OK)
            {
                tableImagePanel.BackColor = bgDialog.Color;
                prefList[1] = Convert.ToString(bgDialog.Color.ToArgb());
                writePrefs();
            }
        }
        #endregion
        #region Helper Code
        public static string[] filepath { get; set; }
        public int zoomValue { get; set; }
        public string prefPath { get; set; }
        public string[] prefList { get; set; } = new string[8];
        private void loadPics(int zoomPass) //This method loads the images into the table container
        {
            if (filepath != null && filepath.Length != 0 && filepath[0] != "openFileDialog2") //Checks to see if a file has been selected
            {
                if (viewDropDown.Text == "Side By Side") //If side by side view is selected
                {


                    tableImagePanel.Controls.Clear(); //Clears table of all controls
                    tableImagePanel.ColumnStyles.Clear(); //Clears column styles
                    tableImagePanel.RowStyles.Clear();
                    tableImagePanel.RowCount = 1;
                    tableImagePanel.ColumnCount = 0; //Sets number of columns to 1
                    for (int i = 0; i < filepath.Length; i++) //Loop through all paths in the filepath array
                    {
                        tableImagePanel.ColumnCount++; //Adds a column to the table
                        ColumnStyle cs = new ColumnStyle(); //Creates a new column style
                        tableImagePanel.ColumnStyles.Add(cs); //Adds new column style to the collection of styles
                        PictureBox nextPic = new PictureBox(); //Creates a new picture box
                        tableImagePanel.Controls.Add(nextPic, i, 0); //Places the picture box in the next column
                        nextPic.Image = Image.FromFile(filepath[i]); //Loads next image into the picture box
                        nextPic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; //Anchors the picture box to all sides of the cell so that it resizes with the window
                        nextPic.SizeMode = PictureBoxSizeMode.Zoom; //Resizes the image to fit the cell while maintaining the correct aspect ratio/proportions
                        switch (zoomPass)
                        {
                            case 0:
                                nextPic.MinimumSize = new Size(300, 300); //Assigns a minimum size to the picture box so that it cannot get to small
                                cs.Width = 500; //Assigns a minimum width to the column
                                break;
                            case 1:
                                nextPic.MinimumSize = new Size(500, 500); //Assigns a minimum size to the picture box so that it cannot get to small
                                cs.Width = 600; //Assigns a minimum width to the column
                                break;
                            case 2:
                                nextPic.MinimumSize = new Size(700, 700); //Assigns a minimum size to the picture box so that it cannot get to small
                                cs.Width = 710; //Assigns a minimum width to the column
                                break;
                        }

                        cs.SizeType = SizeType.Absolute; //Sets the sizetype of the column to a specific number of pixels

                    }
                }
                else if (viewDropDown.Text == "Vertical")
                {
                    tableImagePanel.Controls.Clear(); //Clears table of all controls
                    tableImagePanel.ColumnStyles.Clear(); //Clears column styles
                    tableImagePanel.RowStyles.Clear();
                    tableImagePanel.RowCount = 0;
                    tableImagePanel.ColumnCount = 1; //Sets number of columns to 1
                    for (int i = 0; i < filepath.Length; i++) //Loop through all paths in the filepath array
                    {
                        tableImagePanel.RowCount++; //Adds a column to the table
                        RowStyle rs = new RowStyle(); //Creates a new column style
                        tableImagePanel.RowStyles.Add(rs); //Adds new column style to the collection of styles
                        PictureBox nextPic = new PictureBox(); //Creates a new picture box
                        tableImagePanel.Controls.Add(nextPic, 0, i); //Places the picture box in the next column
                        nextPic.Image = Image.FromFile(filepath[i]); //Loads next image into the picture box
                        nextPic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; //Anchors the picture box to all sides of the cell so that it resizes with the window
                        nextPic.SizeMode = PictureBoxSizeMode.Zoom; //Resizes the image to fit the cell while maintaining the correct aspect ratio/proportions
                        switch (zoomPass)
                        {
                            case 0:
                                nextPic.MinimumSize = new Size(500, 500); //Assigns a minimum size to the picture box so that it cannot get to small
                                rs.Height = 600; //Assigns a minimum width to the column
                                break;
                            case 1:
                                nextPic.MinimumSize = new Size(800, 800); //Assigns a minimum size to the picture box so that it cannot get to small
                                rs.Height = 810; //Assigns a minimum width to the column
                                break;
                            case 2:
                                nextPic.MinimumSize = new Size(1200, 1200); //Assigns a minimum size to the picture box so that it cannot get to small
                                rs.Height = 1210; //Assigns a minimum width to the column
                                break;
                        }

                        rs.SizeType = SizeType.Absolute; //Sets the sizetype of the column to a specific number of pixels

                    }
                }
            }


        }

        private void loadPrefs()
        {
            prefPath = "userPref.ini";
            prefList = System.IO.File.ReadAllLines(prefPath);
            tableImagePanel.BackColor = Color.FromArgb(Convert.ToInt32(prefList[1]));

        }

        private void writePrefs()
        {
            prefList[0] = "[Background Colour]";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(prefPath))
            {
                foreach (string line in prefList)
                {
                    file.WriteLine(line);
                }
            }
        }


        private void updateFiles()
        {
            string[] recentFiles = System.IO.File.ReadAllLines("recentFiles.ini");
            string combinedPath = "";
            int fileCount = 0;
            foreach(string file in filepath)
            {
                combinedPath += file;
                if (fileCount < filepath.Length - 1)
                {

                    combinedPath += ",";
                }
                fileCount++;
            }
            Console.WriteLine(combinedPath);

            Queue<string> fileQueue = new Queue<string>();
            foreach(string file in recentFiles)
            {
                fileQueue.Enqueue(file);
            }

            bool duplicateCheck = false;
            foreach(string file in fileQueue)
            {
                if (file == combinedPath)
                {
                    Queue<string> tempQueue = new Queue<string>();
                    foreach(string tempfile in fileQueue)
                    {
                        if (file != tempfile)
                        {
                            tempQueue.Enqueue(tempfile);
                        }
                    }
                    tempQueue.Enqueue(file);
                    fileQueue = tempQueue;
                    duplicateCheck = true;
                }
            }
            if (duplicateCheck == false)
            {
                if (fileQueue.Count == 5)
                {
                    fileQueue.Dequeue();
                    fileQueue.Enqueue(combinedPath);
                }
                else
                {
                    fileQueue.Enqueue(combinedPath);
                }
            }
            foreach (string path in fileQueue)
            {
                Console.WriteLine(path);
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("recentFiles.ini"))
            {

                foreach (string path in fileQueue)
                {
                    file.Write(path+Environment.NewLine);
                }
            }
        }




        #endregion


    }
}
