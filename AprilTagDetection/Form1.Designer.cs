namespace WaferProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        public static string password;
        
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Video_MainPannel = new System.Windows.Forms.Panel();
            this.Video_UpdateResource = new System.Windows.Forms.Button();
            this.AprilTag_Y = new System.Windows.Forms.Label();
            this.AprilTag_X = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.Video_StartRecord = new System.Windows.Forms.CheckBox();
            this.Video_ListOfResource = new System.Windows.Forms.ComboBox();
            this.Video_PictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Video_MainPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Video_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Video_MainPannel
            // 
            this.Video_MainPannel.Controls.Add(this.button1);
            this.Video_MainPannel.Controls.Add(this.Video_UpdateResource);
            this.Video_MainPannel.Controls.Add(this.AprilTag_Y);
            this.Video_MainPannel.Controls.Add(this.AprilTag_X);
            this.Video_MainPannel.Controls.Add(this.label64);
            this.Video_MainPannel.Controls.Add(this.label63);
            this.Video_MainPannel.Controls.Add(this.label61);
            this.Video_MainPannel.Controls.Add(this.Video_StartRecord);
            this.Video_MainPannel.Controls.Add(this.Video_ListOfResource);
            this.Video_MainPannel.Controls.Add(this.Video_PictureBox);
            this.Video_MainPannel.Location = new System.Drawing.Point(12, 12);
            this.Video_MainPannel.Name = "Video_MainPannel";
            this.Video_MainPannel.Size = new System.Drawing.Size(583, 516);
            this.Video_MainPannel.TabIndex = 92;
            // 
            // Video_UpdateResource
            // 
            this.Video_UpdateResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Video_UpdateResource.ForeColor = System.Drawing.Color.Black;
            this.Video_UpdateResource.Location = new System.Drawing.Point(87, 461);
            this.Video_UpdateResource.Name = "Video_UpdateResource";
            this.Video_UpdateResource.Size = new System.Drawing.Size(108, 22);
            this.Video_UpdateResource.TabIndex = 100;
            this.Video_UpdateResource.Text = "Update Resource";
            this.Video_UpdateResource.UseVisualStyleBackColor = true;
            this.Video_UpdateResource.Click += new System.EventHandler(this.Video_UpdateResource_Click);
            // 
            // AprilTag_Y
            // 
            this.AprilTag_Y.AutoSize = true;
            this.AprilTag_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AprilTag_Y.ForeColor = System.Drawing.Color.Blue;
            this.AprilTag_Y.Location = new System.Drawing.Point(417, 473);
            this.AprilTag_Y.Name = "AprilTag_Y";
            this.AprilTag_Y.Size = new System.Drawing.Size(29, 31);
            this.AprilTag_Y.TabIndex = 99;
            this.AprilTag_Y.Text = "0";
            // 
            // AprilTag_X
            // 
            this.AprilTag_X.AutoSize = true;
            this.AprilTag_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AprilTag_X.ForeColor = System.Drawing.Color.Blue;
            this.AprilTag_X.Location = new System.Drawing.Point(338, 472);
            this.AprilTag_X.Name = "AprilTag_X";
            this.AprilTag_X.Size = new System.Drawing.Size(29, 31);
            this.AprilTag_X.TabIndex = 98;
            this.AprilTag_X.Text = "0";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(369, 487);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(54, 17);
            this.label64.TabIndex = 97;
            this.label64.Text = "Tag ID:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(260, 486);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(83, 17);
            this.label63.TabIndex = 6;
            this.label63.Text = "Is Detected:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 465);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(71, 13);
            this.label61.TabIndex = 96;
            this.label61.Text = "Video Source";
            // 
            // Video_StartRecord
            // 
            this.Video_StartRecord.AutoSize = true;
            this.Video_StartRecord.Location = new System.Drawing.Point(207, 463);
            this.Video_StartRecord.Name = "Video_StartRecord";
            this.Video_StartRecord.Size = new System.Drawing.Size(86, 17);
            this.Video_StartRecord.TabIndex = 95;
            this.Video_StartRecord.Text = "Start Record";
            this.Video_StartRecord.UseVisualStyleBackColor = true;
            this.Video_StartRecord.CheckedChanged += new System.EventHandler(this.Video_StartRecord_CheckedChanged);
            // 
            // Video_ListOfResource
            // 
            this.Video_ListOfResource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Video_ListOfResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Video_ListOfResource.FormattingEnabled = true;
            this.Video_ListOfResource.Location = new System.Drawing.Point(5, 486);
            this.Video_ListOfResource.Margin = new System.Windows.Forms.Padding(2);
            this.Video_ListOfResource.Name = "Video_ListOfResource";
            this.Video_ListOfResource.Size = new System.Drawing.Size(236, 21);
            this.Video_ListOfResource.TabIndex = 94;
            // 
            // Video_PictureBox
            // 
            this.Video_PictureBox.Location = new System.Drawing.Point(9, 6);
            this.Video_PictureBox.Name = "Video_PictureBox";
            this.Video_PictureBox.Size = new System.Drawing.Size(563, 449);
            this.Video_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Video_PictureBox.TabIndex = 93;
            this.Video_PictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 101;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(604, 535);
            this.Controls.Add(this.Video_MainPannel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AprilTag Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Video_MainPannel.ResumeLayout(false);
            this.Video_MainPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Video_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Video_MainPannel;
        private System.Windows.Forms.Label AprilTag_Y;
        private System.Windows.Forms.Label AprilTag_X;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.CheckBox Video_StartRecord;
        private System.Windows.Forms.ComboBox Video_ListOfResource;
        private System.Windows.Forms.PictureBox Video_PictureBox;
        private System.Windows.Forms.Button Video_UpdateResource;
        private System.Windows.Forms.Button button1;
    }
}

