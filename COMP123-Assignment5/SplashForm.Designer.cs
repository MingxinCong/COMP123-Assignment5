namespace COMP123_Assignment5
{
    partial class SplashForm
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
            this.splashFormLabel = new System.Windows.Forms.Label();
            this.splashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashFormLabel
            // 
            this.splashFormLabel.AutoSize = true;
            this.splashFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashFormLabel.Location = new System.Drawing.Point(219, 44);
            this.splashFormLabel.Name = "splashFormLabel";
            this.splashFormLabel.Size = new System.Drawing.Size(374, 31);
            this.splashFormLabel.TabIndex = 0;
            this.splashFormLabel.Text = "Welcome to Dollar Computers";
            // 
            // splashFormTimer
            // 
            this.splashFormTimer.Interval = 3000;
            this.splashFormTimer.Tick += new System.EventHandler(this.splashFormTimer_Tick);
            // 
            // SplashFormPictureBox
            // 
            this.SplashFormPictureBox.Image = global::COMP123_Assignment5.Properties.Resources.logo;
            this.SplashFormPictureBox.ImageLocation = "";
            this.SplashFormPictureBox.Location = new System.Drawing.Point(168, 111);
            this.SplashFormPictureBox.Name = "SplashFormPictureBox";
            this.SplashFormPictureBox.Size = new System.Drawing.Size(483, 270);
            this.SplashFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SplashFormPictureBox.TabIndex = 1;
            this.SplashFormPictureBox.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SplashFormPictureBox);
            this.Controls.Add(this.splashFormLabel);
            this.Name = "SplashForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label splashFormLabel;
        private System.Windows.Forms.Timer splashFormTimer;
        private System.Windows.Forms.PictureBox SplashFormPictureBox;
    }
}