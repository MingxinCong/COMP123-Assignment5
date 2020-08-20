namespace COMP123_Assignment5
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpuGroupBox = new System.Windows.Forms.GroupBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.lcdLabel = new System.Windows.Forms.Label();
            this.cpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.cpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.cpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.otherSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.gpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.webCamLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.webCamTextBox = new System.Windows.Forms.TextBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.orderFormPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.cpuGroupBox.SuspendLayout();
            this.otherSpecsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cpuGroupBox
            // 
            this.cpuGroupBox.Controls.Add(this.cpuSpeedTextBox);
            this.cpuGroupBox.Controls.Add(this.cpuSpeedLabel);
            this.cpuGroupBox.Controls.Add(this.cpuTypeTextBox);
            this.cpuGroupBox.Controls.Add(this.cpuNumberTextBox);
            this.cpuGroupBox.Controls.Add(this.cpuBrandTextBox);
            this.cpuGroupBox.Controls.Add(this.cpuTypeLabel);
            this.cpuGroupBox.Controls.Add(this.cpuNumberLabel);
            this.cpuGroupBox.Controls.Add(this.cpuBrandLabel);
            this.cpuGroupBox.Location = new System.Drawing.Point(28, 66);
            this.cpuGroupBox.Name = "cpuGroupBox";
            this.cpuGroupBox.Size = new System.Drawing.Size(424, 103);
            this.cpuGroupBox.TabIndex = 1;
            this.cpuGroupBox.TabStop = false;
            this.cpuGroupBox.Text = "CPU Specs";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(217, 37);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(67, 17);
            this.conditionLabel.TabIndex = 0;
            this.conditionLabel.Text = "Condition";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(25, 67);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 17);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Location = new System.Drawing.Point(216, 72);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(60, 17);
            this.platformLabel.TabIndex = 2;
            this.platformLabel.Text = "Platform";
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(-3, 102);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(92, 17);
            this.manufacturerLabel.TabIndex = 3;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(90, 67);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 22);
            this.modelTextBox.TabIndex = 4;
            // 
            // platformTextBox
            // 
            this.platformTextBox.Location = new System.Drawing.Point(311, 67);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.Size = new System.Drawing.Size(100, 22);
            this.platformTextBox.TabIndex = 5;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(90, 34);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.memoryTextBox.TabIndex = 6;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(311, 34);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 22);
            this.conditionTextBox.TabIndex = 7;
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(25, 34);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(58, 17);
            this.memoryLabel.TabIndex = 8;
            this.memoryLabel.Text = "Memory";
            // 
            // hddLabel
            // 
            this.hddLabel.AutoSize = true;
            this.hddLabel.Location = new System.Drawing.Point(25, 131);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(38, 17);
            this.hddLabel.TabIndex = 9;
            this.hddLabel.Text = "HDD";
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.AutoSize = true;
            this.cpuBrandLabel.Location = new System.Drawing.Point(6, 31);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(78, 17);
            this.cpuBrandLabel.TabIndex = 10;
            this.cpuBrandLabel.Text = "CPU Brand";
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.AutoSize = true;
            this.gpuTypeLabel.Location = new System.Drawing.Point(217, 136);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(74, 17);
            this.gpuTypeLabel.TabIndex = 11;
            this.gpuTypeLabel.Text = "GPU Type";
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.AutoSize = true;
            this.cpuNumberLabel.Location = new System.Drawing.Point(216, 31);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.cpuNumberLabel.TabIndex = 12;
            this.cpuNumberLabel.Text = "CPU Number";
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.AutoSize = true;
            this.cpuTypeLabel.Location = new System.Drawing.Point(6, 62);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(72, 17);
            this.cpuTypeLabel.TabIndex = 13;
            this.cpuTypeLabel.Text = "CPU Type";
            // 
            // lcdLabel
            // 
            this.lcdLabel.AutoSize = true;
            this.lcdLabel.Location = new System.Drawing.Point(216, 105);
            this.lcdLabel.Name = "lcdLabel";
            this.lcdLabel.Size = new System.Drawing.Size(66, 17);
            this.lcdLabel.TabIndex = 14;
            this.lcdLabel.Text = "LCD Size";
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Location = new System.Drawing.Point(90, 28);
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuBrandTextBox.TabIndex = 15;
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Location = new System.Drawing.Point(311, 28);
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuNumberTextBox.TabIndex = 16;
            // 
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Location = new System.Drawing.Point(90, 62);
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuTypeTextBox.TabIndex = 17;
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Location = new System.Drawing.Point(217, 62);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(81, 17);
            this.cpuSpeedLabel.TabIndex = 18;
            this.cpuSpeedLabel.Text = "CPU Speed";
            // 
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(311, 62);
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuSpeedTextBox.TabIndex = 19;
            // 
            // otherSpecsGroupBox
            // 
            this.otherSpecsGroupBox.Controls.Add(this.osTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.webCamTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.osLabel);
            this.otherSpecsGroupBox.Controls.Add(this.webCamLabel);
            this.otherSpecsGroupBox.Controls.Add(this.gpuTypeTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.hddTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.lcdSizeTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.manufacturerTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.memoryLabel);
            this.otherSpecsGroupBox.Controls.Add(this.modelLabel);
            this.otherSpecsGroupBox.Controls.Add(this.hddLabel);
            this.otherSpecsGroupBox.Controls.Add(this.gpuTypeLabel);
            this.otherSpecsGroupBox.Controls.Add(this.conditionLabel);
            this.otherSpecsGroupBox.Controls.Add(this.lcdLabel);
            this.otherSpecsGroupBox.Controls.Add(this.platformLabel);
            this.otherSpecsGroupBox.Controls.Add(this.memoryTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.manufacturerLabel);
            this.otherSpecsGroupBox.Controls.Add(this.conditionTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.modelTextBox);
            this.otherSpecsGroupBox.Controls.Add(this.platformTextBox);
            this.otherSpecsGroupBox.Location = new System.Drawing.Point(28, 190);
            this.otherSpecsGroupBox.Name = "otherSpecsGroupBox";
            this.otherSpecsGroupBox.Size = new System.Drawing.Size(424, 205);
            this.otherSpecsGroupBox.TabIndex = 2;
            this.otherSpecsGroupBox.TabStop = false;
            this.otherSpecsGroupBox.Text = "Other Specs";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(90, 102);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturerTextBox.TabIndex = 15;
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Location = new System.Drawing.Point(311, 102);
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.lcdSizeTextBox.TabIndex = 16;
            // 
            // hddTextBox
            // 
            this.hddTextBox.Location = new System.Drawing.Point(90, 131);
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.Size = new System.Drawing.Size(100, 22);
            this.hddTextBox.TabIndex = 17;
            // 
            // gpuTypeTextBox
            // 
            this.gpuTypeTextBox.Location = new System.Drawing.Point(311, 136);
            this.gpuTypeTextBox.Name = "gpuTypeTextBox";
            this.gpuTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.gpuTypeTextBox.TabIndex = 18;
            // 
            // webCamLabel
            // 
            this.webCamLabel.AutoSize = true;
            this.webCamLabel.Location = new System.Drawing.Point(14, 168);
            this.webCamLabel.Name = "webCamLabel";
            this.webCamLabel.Size = new System.Drawing.Size(69, 17);
            this.webCamLabel.TabIndex = 19;
            this.webCamLabel.Text = "Web Cam";
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(217, 168);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(28, 17);
            this.osLabel.TabIndex = 20;
            this.osLabel.Text = "OS";
            // 
            // webCamTextBox
            // 
            this.webCamTextBox.Location = new System.Drawing.Point(90, 168);
            this.webCamTextBox.Name = "webCamTextBox";
            this.webCamTextBox.Size = new System.Drawing.Size(100, 22);
            this.webCamTextBox.TabIndex = 21;
            // 
            // osTextBox
            // 
            this.osTextBox.Location = new System.Drawing.Point(311, 168);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(100, 22);
            this.osTextBox.TabIndex = 22;
            // 
            // orderFormPictureBox
            // 
            this.orderFormPictureBox.Location = new System.Drawing.Point(515, 76);
            this.orderFormPictureBox.Name = "orderFormPictureBox";
            this.orderFormPictureBox.Size = new System.Drawing.Size(100, 50);
            this.orderFormPictureBox.TabIndex = 3;
            this.orderFormPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderFormPictureBox);
            this.Controls.Add(this.otherSpecsGroupBox);
            this.Controls.Add(this.cpuGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cpuGroupBox.ResumeLayout(false);
            this.cpuGroupBox.PerformLayout();
            this.otherSpecsGroupBox.ResumeLayout(false);
            this.otherSpecsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox cpuGroupBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label lcdLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.TextBox cpuSpeedTextBox;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.TextBox cpuTypeTextBox;
        private System.Windows.Forms.TextBox cpuNumberTextBox;
        private System.Windows.Forms.TextBox cpuBrandTextBox;
        private System.Windows.Forms.GroupBox otherSpecsGroupBox;
        private System.Windows.Forms.TextBox lcdSizeTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox hddTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.TextBox webCamTextBox;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label webCamLabel;
        private System.Windows.Forms.TextBox gpuTypeTextBox;
        private System.Windows.Forms.PictureBox orderFormPictureBox;
    }
}