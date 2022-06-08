namespace PaintVS
{
    partial class FormPaint
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
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.picBoxColor = new System.Windows.Forms.PictureBox();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.Bin = new System.Windows.Forms.PictureBox();
            this.panelFigure = new System.Windows.Forms.Panel();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.TriangleBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.panelAdditional = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bin)).BeginInit();
            this.panelFigure.SuspendLayout();
            this.panelAdditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Location = new System.Drawing.Point(0, 89);
            this.PicBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(1269, 733);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBox_Paint);
            this.PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseDown);
            this.PicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseMove);
            this.PicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseUp);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Settings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Load});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(103, 22);
            this.Load.Text = "Open";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(61, 20);
            this.Settings.Text = "Settings";
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // picBoxColor
            // 
            this.picBoxColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxColor.Location = new System.Drawing.Point(13, 13);
            this.picBoxColor.Name = "picBoxColor";
            this.picBoxColor.Size = new System.Drawing.Size(59, 38);
            this.picBoxColor.TabIndex = 26;
            this.picBoxColor.TabStop = false;
            this.picBoxColor.Click += new System.EventHandler(this.picBoxColor_Click);
            // 
            // sizeBar
            // 
            this.sizeBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sizeBar.LargeChange = 1;
            this.sizeBar.Location = new System.Drawing.Point(100, 13);
            this.sizeBar.Maximum = 15;
            this.sizeBar.Minimum = 1;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(165, 45);
            this.sizeBar.TabIndex = 27;
            this.sizeBar.Value = 3;
            this.sizeBar.Scroll += new System.EventHandler(this.sizeBar_Scroll);
            // 
            // Bin
            // 
            this.Bin.BackColor = System.Drawing.Color.Transparent;
            this.Bin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bin.Image = global::PaintVS.Properties.Resources.pngwing_com;
            this.Bin.Location = new System.Drawing.Point(357, 6);
            this.Bin.Name = "Bin";
            this.Bin.Size = new System.Drawing.Size(46, 45);
            this.Bin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bin.TabIndex = 28;
            this.Bin.TabStop = false;
            this.Bin.Click += new System.EventHandler(this.Bin_Click);
            // 
            // panelFigure
            // 
            this.panelFigure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFigure.BackColor = System.Drawing.Color.Transparent;
            this.panelFigure.Controls.Add(this.btnForward);
            this.panelFigure.Controls.Add(this.btnBack);
            this.panelFigure.Controls.Add(this.TriangleBtn);
            this.panelFigure.Controls.Add(this.RectangleBtn);
            this.panelFigure.Controls.Add(this.CircleBtn);
            this.panelFigure.Controls.Add(this.LineBtn);
            this.panelFigure.Location = new System.Drawing.Point(0, 27);
            this.panelFigure.Name = "panelFigure";
            this.panelFigure.Size = new System.Drawing.Size(432, 62);
            this.panelFigure.TabIndex = 29;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundImage = global::PaintVS.Properties.Resources.Forward2;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForward.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Font = new System.Drawing.Font("Adobe Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForward.Image = global::PaintVS.Properties.Resources.Circle;
            this.btnForward.Location = new System.Drawing.Point(64, 29);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(33, 33);
            this.btnForward.TabIndex = 38;
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::PaintVS.Properties.Resources.Back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Adobe Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Image = global::PaintVS.Properties.Resources.Circle;
            this.btnBack.Location = new System.Drawing.Point(24, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 33);
            this.btnBack.TabIndex = 36;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.BackColor = System.Drawing.Color.Transparent;
            this.TriangleBtn.BackgroundImage = global::PaintVS.Properties.Resources.Triangle2;
            this.TriangleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriangleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TriangleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TriangleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TriangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriangleBtn.Font = new System.Drawing.Font("Adobe Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TriangleBtn.Image = global::PaintVS.Properties.Resources.Circle;
            this.TriangleBtn.Location = new System.Drawing.Point(334, 3);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(54, 56);
            this.TriangleBtn.TabIndex = 37;
            this.TriangleBtn.UseVisualStyleBackColor = false;
            this.TriangleBtn.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.BackColor = System.Drawing.Color.Transparent;
            this.RectangleBtn.BackgroundImage = global::PaintVS.Properties.Resources.Rectangle;
            this.RectangleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RectangleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RectangleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RectangleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleBtn.Font = new System.Drawing.Font("Adobe Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RectangleBtn.Image = global::PaintVS.Properties.Resources.Circle;
            this.RectangleBtn.Location = new System.Drawing.Point(265, 3);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(54, 56);
            this.RectangleBtn.TabIndex = 36;
            this.RectangleBtn.UseVisualStyleBackColor = false;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.BackColor = System.Drawing.Color.Transparent;
            this.CircleBtn.BackgroundImage = global::PaintVS.Properties.Resources.Circle;
            this.CircleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CircleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CircleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CircleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CircleBtn.Font = new System.Drawing.Font("Adobe Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CircleBtn.Image = global::PaintVS.Properties.Resources.Circle;
            this.CircleBtn.Location = new System.Drawing.Point(196, 3);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(54, 56);
            this.CircleBtn.TabIndex = 35;
            this.CircleBtn.UseVisualStyleBackColor = false;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.BackColor = System.Drawing.Color.Transparent;
            this.LineBtn.BackgroundImage = global::PaintVS.Properties.Resources.Line;
            this.LineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LineBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LineBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.LineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineBtn.Font = new System.Drawing.Font("Adobe Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LineBtn.Image = global::PaintVS.Properties.Resources.Circle;
            this.LineBtn.Location = new System.Drawing.Point(127, 3);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(54, 56);
            this.LineBtn.TabIndex = 34;
            this.LineBtn.UseVisualStyleBackColor = false;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // panelAdditional
            // 
            this.panelAdditional.Controls.Add(this.picBoxColor);
            this.panelAdditional.Controls.Add(this.sizeBar);
            this.panelAdditional.Controls.Add(this.Bin);
            this.panelAdditional.Location = new System.Drawing.Point(851, 27);
            this.panelAdditional.Name = "panelAdditional";
            this.panelAdditional.Size = new System.Drawing.Size(406, 62);
            this.panelAdditional.TabIndex = 30;
            // 
            // FormPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1269, 822);
            this.Controls.Add(this.panelAdditional);
            this.Controls.Add(this.panelFigure);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Adobe Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Location = new System.Drawing.Point(15, 70);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1285, 861);
            this.Name = "FormPaint";
            this.Text = "PaintP";
            this.Resize += new System.EventHandler(this.FormPaint_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bin)).EndInit();
            this.panelFigure.ResumeLayout(false);
            this.panelAdditional.ResumeLayout(false);
            this.panelAdditional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox PicBox;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        private MenuStrip menuStrip;
        private ToolStripMenuItem File;
        private ToolStripMenuItem Save;
        private ToolStripMenuItem Load;
        private ToolStripMenuItem Settings;
        private ColorDialog colorDialog;
        private PictureBox picBoxColor;
        private TrackBar sizeBar;
        private PictureBox Bin;
        private Panel panelFigure;
        private Button LineBtn;
        private Button CircleBtn;
        private Button TriangleBtn;
        private Button RectangleBtn;
        private Panel panelAdditional;
        private Button btnForward;
        private Button btnBack;
    }
}