namespace ProjectMicrosoftWord
{
    partial class MicrosoftWord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicrosoftWord));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            restartProgramToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            fontTypeToolStripMenuItem = new ToolStripMenuItem();
            boldFontToolStripMenuItem = new ToolStripMenuItem();
            underlineFontToolStripMenuItem = new ToolStripMenuItem();
            italicFontToolStripMenuItem = new ToolStripMenuItem();
            colorTypeToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            insertPictureToolStripMenuItem = new ToolStripMenuItem();
            drawFigureToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            ovalToolStripMenuItem = new ToolStripMenuItem();
            designToolStripMenuItem = new ToolStripMenuItem();
            fontTypefaceToolStripMenuItem = new ToolStripMenuItem();
            fontSizeToolStripMenuItem = new ToolStripMenuItem();
            WriteTxtB = new RichTextBox();
            SaveBttn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            RestartBttn = new Button();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, homeToolStripMenuItem, insertToolStripMenuItem, designToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileToolStripMenuItem, openFileToolStripMenuItem, restartProgramToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(224, 26);
            saveFileToolStripMenuItem.Text = "Save  file";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(224, 26);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // restartProgramToolStripMenuItem
            // 
            restartProgramToolStripMenuItem.Name = "restartProgramToolStripMenuItem";
            restartProgramToolStripMenuItem.Size = new Size(224, 26);
            restartProgramToolStripMenuItem.Text = "Restart program";
            restartProgramToolStripMenuItem.Click += restartProgramToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontTypeToolStripMenuItem, colorTypeToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // fontTypeToolStripMenuItem
            // 
            fontTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldFontToolStripMenuItem, underlineFontToolStripMenuItem, italicFontToolStripMenuItem });
            fontTypeToolStripMenuItem.Name = "fontTypeToolStripMenuItem";
            fontTypeToolStripMenuItem.Size = new Size(161, 26);
            fontTypeToolStripMenuItem.Text = "Font type";
            // 
            // boldFontToolStripMenuItem
            // 
            boldFontToolStripMenuItem.Name = "boldFontToolStripMenuItem";
            boldFontToolStripMenuItem.Size = new Size(187, 26);
            boldFontToolStripMenuItem.Text = "Bold font";
            // 
            // underlineFontToolStripMenuItem
            // 
            underlineFontToolStripMenuItem.Name = "underlineFontToolStripMenuItem";
            underlineFontToolStripMenuItem.Size = new Size(187, 26);
            underlineFontToolStripMenuItem.Text = "Underline font";
            // 
            // italicFontToolStripMenuItem
            // 
            italicFontToolStripMenuItem.Name = "italicFontToolStripMenuItem";
            italicFontToolStripMenuItem.Size = new Size(187, 26);
            italicFontToolStripMenuItem.Text = "Italic font";
            // 
            // colorTypeToolStripMenuItem
            // 
            colorTypeToolStripMenuItem.Name = "colorTypeToolStripMenuItem";
            colorTypeToolStripMenuItem.Size = new Size(161, 26);
            colorTypeToolStripMenuItem.Text = "Color type";
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { insertPictureToolStripMenuItem, drawFigureToolStripMenuItem });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(59, 24);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // insertPictureToolStripMenuItem
            // 
            insertPictureToolStripMenuItem.Name = "insertPictureToolStripMenuItem";
            insertPictureToolStripMenuItem.Size = new Size(178, 26);
            insertPictureToolStripMenuItem.Text = "Insert picture";
            // 
            // drawFigureToolStripMenuItem
            // 
            drawFigureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { squareToolStripMenuItem, rectangleToolStripMenuItem, circleToolStripMenuItem, ovalToolStripMenuItem });
            drawFigureToolStripMenuItem.Name = "drawFigureToolStripMenuItem";
            drawFigureToolStripMenuItem.Size = new Size(178, 26);
            drawFigureToolStripMenuItem.Text = "Draw figure";
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(158, 26);
            squareToolStripMenuItem.Text = "Square";
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(158, 26);
            rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(158, 26);
            circleToolStripMenuItem.Text = "Circle";
            // 
            // ovalToolStripMenuItem
            // 
            ovalToolStripMenuItem.Name = "ovalToolStripMenuItem";
            ovalToolStripMenuItem.Size = new Size(158, 26);
            ovalToolStripMenuItem.Text = "Oval";
            // 
            // designToolStripMenuItem
            // 
            designToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontTypefaceToolStripMenuItem, fontSizeToolStripMenuItem });
            designToolStripMenuItem.Name = "designToolStripMenuItem";
            designToolStripMenuItem.Size = new Size(69, 24);
            designToolStripMenuItem.Text = "Design";
            // 
            // fontTypefaceToolStripMenuItem
            // 
            fontTypefaceToolStripMenuItem.Name = "fontTypefaceToolStripMenuItem";
            fontTypefaceToolStripMenuItem.Size = new Size(182, 26);
            fontTypefaceToolStripMenuItem.Text = "Font typeface";
            // 
            // fontSizeToolStripMenuItem
            // 
            fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            fontSizeToolStripMenuItem.Size = new Size(182, 26);
            fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // WriteTxtB
            // 
            WriteTxtB.Location = new Point(0, 62);
            WriteTxtB.Name = "WriteTxtB";
            WriteTxtB.Size = new Size(800, 389);
            WriteTxtB.TabIndex = 1;
            WriteTxtB.Text = "";
            // 
            // SaveBttn
            // 
            SaveBttn.Image = (Image)resources.GetObject("SaveBttn.Image");
            SaveBttn.Location = new Point(673, 31);
            SaveBttn.Name = "SaveBttn";
            SaveBttn.Size = new Size(31, 31);
            SaveBttn.TabIndex = 2;
            SaveBttn.UseVisualStyleBackColor = true;
            SaveBttn.Click += SaveBttn_Click;
            // 
            // RestartBttn
            // 
            RestartBttn.Image = (Image)resources.GetObject("RestartBttn.Image");
            RestartBttn.Location = new Point(723, 31);
            RestartBttn.Name = "RestartBttn";
            RestartBttn.Size = new Size(28, 31);
            RestartBttn.TabIndex = 3;
            RestartBttn.UseVisualStyleBackColor = true;
            RestartBttn.Click += RestartBttn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MicrosoftWord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RestartBttn);
            Controls.Add(SaveBttn);
            Controls.Add(WriteTxtB);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MicrosoftWord";
            Text = "Microsoft Word";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem designToolStripMenuItem;
        private RichTextBox WriteTxtB;
        private Button SaveBttn;
        private SaveFileDialog saveFileDialog1;
        private Button RestartBttn;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem restartProgramToolStripMenuItem;
        private ToolStripMenuItem insertPictureToolStripMenuItem;
        private ToolStripMenuItem drawFigureToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem ovalToolStripMenuItem;
        private ToolStripMenuItem fontTypeToolStripMenuItem;
        private ToolStripMenuItem boldFontToolStripMenuItem;
        private ToolStripMenuItem underlineFontToolStripMenuItem;
        private ToolStripMenuItem italicFontToolStripMenuItem;
        private ToolStripMenuItem colorTypeToolStripMenuItem;
        private ToolStripMenuItem fontTypefaceToolStripMenuItem;
        private ToolStripMenuItem fontSizeToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
    }
}