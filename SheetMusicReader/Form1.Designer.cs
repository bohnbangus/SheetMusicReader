
namespace SheetMusicReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuTutorial = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomButton = new System.Windows.Forms.ToolStripButton();
            this.viewDropDown = new System.Windows.Forms.ToolStripComboBox();
            this.openFileTool = new System.Windows.Forms.OpenFileDialog();
            this.printMusic = new System.Windows.Forms.PrintDialog();
            this.tableImagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuHelp});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOpen,
            this.menuItem1});
            this.menuItemFile.Text = "File";
            this.menuItemFile.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = 0;
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "Exit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 1;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuTutorial,
            this.menuAbout});
            this.menuHelp.Text = "Help";
            // 
            // menuTutorial
            // 
            this.menuTutorial.Index = 0;
            this.menuTutorial.Text = "Tutorial";
            // 
            // menuAbout
            // 
            this.menuAbout.Index = 1;
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printButton,
            this.toolStripSeparator1,
            this.zoomButton,
            this.viewDropDown});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(828, 45);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // printButton
            // 
            this.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printButton.Name = "printButton";
            this.printButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.printButton.Size = new System.Drawing.Size(54, 42);
            this.printButton.Text = "toolStripButton1";
            this.printButton.ToolTipText = "Print";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // zoomButton
            // 
            this.zoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomButton.Image")));
            this.zoomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.zoomButton.Size = new System.Drawing.Size(44, 42);
            this.zoomButton.Text = "toolStripButton1";
            this.zoomButton.ToolTipText = "Zoom";
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            // 
            // viewDropDown
            // 
            this.viewDropDown.AutoSize = false;
            this.viewDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.viewDropDown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.viewDropDown.Items.AddRange(new object[] {
            "Side By Side",
            "Vertical"});
            this.viewDropDown.Name = "viewDropDown";
            this.viewDropDown.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.viewDropDown.Size = new System.Drawing.Size(150, 23);
            this.viewDropDown.DropDownClosed += new System.EventHandler(this.viewDropDown_Change);
            this.viewDropDown.Click += new System.EventHandler(this.viewDropDown_Click);
            // 
            // openFileTool
            // 
            this.openFileTool.FileName = "openFileDialog2";
            // 
            // printMusic
            // 
            this.printMusic.UseEXDialog = true;
            // 
            // tableImagePanel
            // 
            this.tableImagePanel.AutoScroll = true;
            this.tableImagePanel.AutoSize = true;
            this.tableImagePanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableImagePanel.ColumnCount = 1;
            this.tableImagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.71623F));
            this.tableImagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.28377F));
            this.tableImagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableImagePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableImagePanel.Location = new System.Drawing.Point(0, 45);
            this.tableImagePanel.Name = "tableImagePanel";
            this.tableImagePanel.Padding = new System.Windows.Forms.Padding(15);
            this.tableImagePanel.RowCount = 1;
            this.tableImagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableImagePanel.Size = new System.Drawing.Size(828, 532);
            this.tableImagePanel.TabIndex = 2;
            this.tableImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 577);
            this.Controls.Add(this.tableImagePanel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sheet Music Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton printButton;
        private System.Windows.Forms.ToolStripButton zoomButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileTool;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MenuItem menuTutorial;
        private System.Windows.Forms.MenuItem menuAbout;
        private System.Windows.Forms.PrintDialog printMusic;
        private System.Windows.Forms.ToolStripComboBox viewDropDown;
        private System.Windows.Forms.TableLayoutPanel tableImagePanel;
        private System.Windows.Forms.MenuItem menuItem1;
    }
}

