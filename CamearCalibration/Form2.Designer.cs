namespace CamearCalibration
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Main_Picturebox = new Emgu.CV.UI.ImageBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.numSquareSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numChessHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numChessWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numFrameBuffer = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Sub_PicturBox = new Emgu.CV.UI.ImageBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picturebox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSquareSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameBuffer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sub_PicturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Main_Picturebox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Undistort";
            // 
            // Main_Picturebox
            // 
            this.Main_Picturebox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main_Picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Picturebox.Location = new System.Drawing.Point(6, 22);
            this.Main_Picturebox.Name = "Main_Picturebox";
            this.Main_Picturebox.Size = new System.Drawing.Size(502, 463);
            this.Main_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_Picturebox.TabIndex = 2;
            this.Main_Picturebox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Start_BTN);
            this.groupBox2.Controls.Add(this.numSquareSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numChessHeight);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numChessWidth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numFrameBuffer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(532, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config";
            // 
            // Start_BTN
            // 
            this.Start_BTN.Location = new System.Drawing.Point(179, 25);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(109, 34);
            this.Start_BTN.TabIndex = 8;
            this.Start_BTN.Text = "Go...";
            this.Start_BTN.UseVisualStyleBackColor = true;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            // 
            // numSquareSize
            // 
            this.numSquareSize.DecimalPlaces = 2;
            this.numSquareSize.Location = new System.Drawing.Point(102, 157);
            this.numSquareSize.Name = "numSquareSize";
            this.numSquareSize.Size = new System.Drawing.Size(58, 23);
            this.numSquareSize.TabIndex = 7;
            this.numSquareSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Square Size";
            // 
            // numChessHeight
            // 
            this.numChessHeight.Location = new System.Drawing.Point(102, 117);
            this.numChessHeight.Name = "numChessHeight";
            this.numChessHeight.Size = new System.Drawing.Size(58, 23);
            this.numChessHeight.TabIndex = 5;
            this.numChessHeight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chess Height";
            // 
            // numChessWidth
            // 
            this.numChessWidth.Location = new System.Drawing.Point(102, 74);
            this.numChessWidth.Name = "numChessWidth";
            this.numChessWidth.Size = new System.Drawing.Size(58, 23);
            this.numChessWidth.TabIndex = 3;
            this.numChessWidth.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chess Width";
            // 
            // numFrameBuffer
            // 
            this.numFrameBuffer.Location = new System.Drawing.Point(102, 33);
            this.numFrameBuffer.Name = "numFrameBuffer";
            this.numFrameBuffer.Size = new System.Drawing.Size(58, 23);
            this.numFrameBuffer.TabIndex = 1;
            this.numFrameBuffer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frame Buffer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Sub_PicturBox);
            this.groupBox3.Location = new System.Drawing.Point(532, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Original";
            // 
            // Sub_PicturBox
            // 
            this.Sub_PicturBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sub_PicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sub_PicturBox.Location = new System.Drawing.Point(6, 22);
            this.Sub_PicturBox.Name = "Sub_PicturBox";
            this.Sub_PicturBox.Size = new System.Drawing.Size(294, 261);
            this.Sub_PicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sub_PicturBox.TabIndex = 3;
            this.Sub_PicturBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picturebox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSquareSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChessWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameBuffer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sub_PicturBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox Main_Picturebox;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Emgu.CV.UI.ImageBox Sub_PicturBox;
        private NumericUpDown numSquareSize;
        private Label label4;
        private NumericUpDown numChessHeight;
        private Label label3;
        private NumericUpDown numChessWidth;
        private Label label2;
        private NumericUpDown numFrameBuffer;
        private Label label1;
        private Button Start_BTN;
    }
}