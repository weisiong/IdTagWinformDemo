namespace CamearCalibration
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Read_Corners = new System.Windows.Forms.Button();
            this.Start_Calibrate = new System.Windows.Forms.Button();
            this.Exit_Calibrate = new System.Windows.Forms.Button();
            this.Rectify = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Image_Count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Square_Size = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radio_local = new System.Windows.Forms.RadioButton();
            this.radio_camera = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Corners_Ny = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Corners_Nx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 270);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Read_Corners
            // 
            this.Read_Corners.Location = new System.Drawing.Point(416, 58);
            this.Read_Corners.Name = "Read_Corners";
            this.Read_Corners.Size = new System.Drawing.Size(71, 40);
            this.Read_Corners.TabIndex = 4;
            this.Read_Corners.Text = "Read Coners";
            this.Read_Corners.UseVisualStyleBackColor = true;
            this.Read_Corners.Click += new System.EventHandler(this.Read_Corners_Click);
            // 
            // Start_Calibrate
            // 
            this.Start_Calibrate.Location = new System.Drawing.Point(416, 104);
            this.Start_Calibrate.Name = "Start_Calibrate";
            this.Start_Calibrate.Size = new System.Drawing.Size(71, 40);
            this.Start_Calibrate.TabIndex = 5;
            this.Start_Calibrate.Text = "Start Calibrate";
            this.Start_Calibrate.UseVisualStyleBackColor = true;
            this.Start_Calibrate.Click += new System.EventHandler(this.Start_Calibrate_Click);
            // 
            // Exit_Calibrate
            // 
            this.Exit_Calibrate.Location = new System.Drawing.Point(416, 150);
            this.Exit_Calibrate.Name = "Exit_Calibrate";
            this.Exit_Calibrate.Size = new System.Drawing.Size(71, 40);
            this.Exit_Calibrate.TabIndex = 6;
            this.Exit_Calibrate.Text = "Exit Calibrate";
            this.Exit_Calibrate.UseVisualStyleBackColor = true;
            this.Exit_Calibrate.Click += new System.EventHandler(this.Exit_Calibrate_Click);
            // 
            // Rectify
            // 
            this.Rectify.Location = new System.Drawing.Point(416, 196);
            this.Rectify.Name = "Rectify";
            this.Rectify.Size = new System.Drawing.Size(71, 40);
            this.Rectify.TabIndex = 7;
            this.Rectify.Text = "Rectify";
            this.Rectify.UseVisualStyleBackColor = true;
            this.Rectify.Click += new System.EventHandler(this.Rectify_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(416, 242);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 40);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 181);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intrinisic Params";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(32, 132);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(72, 23);
            this.textBox8.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(165, 132);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(73, 23);
            this.textBox9.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "p:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(178, 96);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(60, 23);
            this.textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(105, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 23);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(32, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(60, 23);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "k:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 23);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "cy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "cx:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "fy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "fx:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Image_Count);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Square_Size);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(269, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 184);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ChessBoard Params";
            // 
            // Image_Count
            // 
            this.Image_Count.Location = new System.Drawing.Point(102, 108);
            this.Image_Count.Name = "Image_Count";
            this.Image_Count.Size = new System.Drawing.Size(50, 23);
            this.Image_Count.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Images:";
            // 
            // Square_Size
            // 
            this.Square_Size.Location = new System.Drawing.Point(102, 77);
            this.Square_Size.Name = "Square_Size";
            this.Square_Size.Size = new System.Drawing.Size(50, 23);
            this.Square_Size.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Square Size:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_local);
            this.groupBox4.Controls.Add(this.radio_camera);
            this.groupBox4.Location = new System.Drawing.Point(6, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 44);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Source";
            // 
            // radio_local
            // 
            this.radio_local.AutoSize = true;
            this.radio_local.Location = new System.Drawing.Point(96, 19);
            this.radio_local.Name = "radio_local";
            this.radio_local.Size = new System.Drawing.Size(50, 19);
            this.radio_local.TabIndex = 1;
            this.radio_local.TabStop = true;
            this.radio_local.Text = "local";
            this.radio_local.UseVisualStyleBackColor = true;
            // 
            // radio_camera
            // 
            this.radio_camera.AutoSize = true;
            this.radio_camera.Location = new System.Drawing.Point(8, 19);
            this.radio_camera.Name = "radio_camera";
            this.radio_camera.Size = new System.Drawing.Size(64, 19);
            this.radio_camera.TabIndex = 0;
            this.radio_camera.TabStop = true;
            this.radio_camera.Text = "camera";
            this.radio_camera.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Corners_Ny);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Corners_Nx);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 49);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number of Corners";
            // 
            // Corners_Ny
            // 
            this.Corners_Ny.Location = new System.Drawing.Point(107, 20);
            this.Corners_Ny.Name = "Corners_Ny";
            this.Corners_Ny.Size = new System.Drawing.Size(39, 23);
            this.Corners_Ny.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ny:";
            // 
            // Corners_Nx
            // 
            this.Corners_Nx.Location = new System.Drawing.Point(34, 20);
            this.Corners_Nx.Name = "Corners_Nx";
            this.Corners_Nx.Size = new System.Drawing.Size(43, 23);
            this.Corners_Nx.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nx:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Rectify);
            this.Controls.Add(this.Exit_Calibrate);
            this.Controls.Add(this.Start_Calibrate);
            this.Controls.Add(this.Read_Corners);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox pictureBox1;
        private Button button1;
        private Button Read_Corners;
        private Button Start_Calibrate;
        private Button Exit_Calibrate;
        private Button Rectify;
        private Button Exit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox Image_Count;
        private Label label10;
        private TextBox Square_Size;
        private Label label9;
        private GroupBox groupBox4;
        private RadioButton radio_local;
        private RadioButton radio_camera;
        private GroupBox groupBox3;
        private TextBox Corners_Ny;
        private Label label8;
        private TextBox Corners_Nx;
        private Label label1;
    }
}