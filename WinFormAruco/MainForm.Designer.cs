namespace WinFormAruco
{
    partial class MainForm
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
            this.cameraImageBox = new Emgu.CV.UI.ImageBox();
            this.useThisFrameButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraImageBox
            // 
            this.cameraImageBox.Location = new System.Drawing.Point(12, 57);
            this.cameraImageBox.Name = "cameraImageBox";
            this.cameraImageBox.Size = new System.Drawing.Size(970, 434);
            this.cameraImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraImageBox.TabIndex = 2;
            this.cameraImageBox.TabStop = false;
            // 
            // useThisFrameButton
            // 
            this.useThisFrameButton.Location = new System.Drawing.Point(377, 12);
            this.useThisFrameButton.Name = "useThisFrameButton";
            this.useThisFrameButton.Size = new System.Drawing.Size(160, 30);
            this.useThisFrameButton.TabIndex = 3;
            this.useThisFrameButton.Text = "Use This frame";
            this.useThisFrameButton.UseVisualStyleBackColor = true;
            this.useThisFrameButton.Click += new System.EventHandler(this.useThisFrameButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 39);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(38, 15);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 503);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.useThisFrameButton);
            this.Controls.Add(this.cameraImageBox);
            this.Name = "MainForm";
            this.Text = "Aruco demo";
            ((System.ComponentModel.ISupportInitialize)(this.cameraImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraImageBox;
        private Button useThisFrameButton;
        private Label messageLabel;
    }
}