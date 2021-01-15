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
        }

        #region Buttons and controls
        private void Form1_Load(object sender, EventArgs e)
        {
            viewDropDown.SelectedItem = "Side By Side"; //Sets the default view of the program
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
            loadPics(); //Calls the method to refresh the picture box
        }

        private void openFileDialog1(object sender, CancelEventArgs e)
        {
        }

        private void printButton_Click(object sender, EventArgs e) //When print button is clicked
        {
/*            PrintDocument pd = new PrintDocument(); //create new instance of PrintDocument
            if (String.IsNullOrEmpty(filepath)==false) //Check if a file has been selected
            {
                pd.PrintPage += new PrintPageEventHandler(PrintPage); //Call PrintPage and add pages to be printed to the PrintDocument
                PrintPreviewDialog ppv = new PrintPreviewDialog(); //Create new instance of PrintPreview
                ppv.Document = pd; //Link PrintPreview to the document to be printed
                ppv.ShowDialog(); //Show the print preview dialog

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
                MessageBox.Show("No file has been selected.", "Error", MessageBoxButtons.OK);
            }*/

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
            if (viewDropDown.Text == "Vertical")
            {
                MessageBox.Show("Take your time.\n\nCreated by Drew Edgar.", "About", MessageBoxButtons.OK);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItem1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        #endregion
        #region Helper Code
        public string[] filepath { get; set; }
        private void loadPics() //This method loads the images into the table container
        {
            if (filepath!=null && filepath.Length != 0) //Checks to see if a file has been selected
            {
                if (viewDropDown.Text == "Side By Side")
                {


                    tableImagePanel.Controls.Clear(); //Clears table of all controls
                    tableImagePanel.ColumnStyles.Clear(); //Clears column styles
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
                        nextPic.MinimumSize = new Size(300, 300); //Assigns a minimum size to the picture box so that it cannot get to small
                        cs.SizeType = SizeType.Absolute; //Sets the sizetype of the column to a specific number of pixels
                        cs.Width = 500; //Assigns a minimum width to the column
                    }
                }
            }


        }



        private void PrintPage(object sender, PrintPageEventArgs e)
        {
/*            Image img = Image.FromFile(filepath);
            Point poi = new Point(100, 100);
            e.Graphics.DrawImage(img, poi);*/
        }





        #endregion


    }
}
