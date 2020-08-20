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
            this.cpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.cpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.cpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
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
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.lcdLabel = new System.Windows.Forms.Label();
            this.otherSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.webCamTextBox = new System.Windows.Forms.TextBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.webCamLabel = new System.Windows.Forms.Label();
            this.gpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.orderFormPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.cpuGroupBox.SuspendLayout();
            this.otherSpecsGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cancelOrExit_Click);
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back_Click);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(311, 62);
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuSpeedTextBox.TabIndex = 19;
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
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Location = new System.Drawing.Point(90, 62);
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuTypeTextBox.TabIndex = 17;
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Location = new System.Drawing.Point(311, 28);
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuNumberTextBox.TabIndex = 16;
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Location = new System.Drawing.Point(90, 28);
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuBrandTextBox.TabIndex = 15;
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
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.AutoSize = true;
            this.cpuNumberLabel.Location = new System.Drawing.Point(216, 31);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.cpuNumberLabel.TabIndex = 12;
            this.cpuNumberLabel.Text = "CPU Number";
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
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.AutoSize = true;
            this.gpuTypeLabel.Location = new System.Drawing.Point(217, 136);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(74, 17);
            this.gpuTypeLabel.TabIndex = 11;
            this.gpuTypeLabel.Text = "GPU Type";
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
            // osTextBox
            // 
            this.osTextBox.Location = new System.Drawing.Point(311, 168);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(100, 22);
            this.osTextBox.TabIndex = 22;
            // 
            // webCamTextBox
            // 
            this.webCamTextBox.Location = new System.Drawing.Point(90, 168);
            this.webCamTextBox.Name = "webCamTextBox";
            this.webCamTextBox.Size = new System.Drawing.Size(100, 22);
            this.webCamTextBox.TabIndex = 21;
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
            // webCamLabel
            // 
            this.webCamLabel.AutoSize = true;
            this.webCamLabel.Location = new System.Drawing.Point(14, 168);
            this.webCamLabel.Name = "webCamLabel";
            this.webCamLabel.Size = new System.Drawing.Size(69, 17);
            this.webCamLabel.TabIndex = 19;
            this.webCamLabel.Text = "Web Cam";
            // 
            // gpuTypeTextBox
            // 
            this.gpuTypeTextBox.Location = new System.Drawing.Point(311, 136);
            this.gpuTypeTextBox.Name = "gpuTypeTextBox";
            this.gpuTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.gpuTypeTextBox.TabIndex = 18;
            // 
            // hddTextBox
            // 
            this.hddTextBox.Location = new System.Drawing.Point(90, 131);
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.Size = new System.Drawing.Size(100, 22);
            this.hddTextBox.TabIndex = 17;
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Location = new System.Drawing.Point(311, 102);
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.lcdSizeTextBox.TabIndex = 16;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(90, 102);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturerTextBox.TabIndex = 15;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.totalPriceTextBox);
            this.priceGroupBox.Controls.Add(this.salesTaxTextBox);
            this.priceGroupBox.Controls.Add(this.costTextBox);
            this.priceGroupBox.Controls.Add(this.totalPriceLabel);
            this.priceGroupBox.Controls.Add(this.salesTaxLabel);
            this.priceGroupBox.Controls.Add(this.priceLabel);
            this.priceGroupBox.Location = new System.Drawing.Point(515, 174);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(259, 174);
            this.priceGroupBox.TabIndex = 4;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Your Price";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(140, 115);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalPriceTextBox.TabIndex = 25;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(140, 85);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.salesTaxTextBox.TabIndex = 24;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(140, 47);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 23;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(22, 118);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(40, 17);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Total";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(22, 83);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(112, 17);
            this.salesTaxLabel.TabIndex = 1;
            this.salesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(22, 49);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(485, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.back_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(680, 372);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(583, 371);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelOrExit_Click);
            // 
            // orderFormPictureBox
            // 
            this.orderFormPictureBox.Image = global::COMP123_Assignment5.Properties.Resources.laptop;
            this.orderFormPictureBox.Location = new System.Drawing.Point(494, 42);
            this.orderFormPictureBox.Name = "orderFormPictureBox";
            this.orderFormPictureBox.Size = new System.Drawing.Size(261, 126);
            this.orderFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderFormPictureBox.TabIndex = 3;
            this.orderFormPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.orderFormPictureBox);
            this.Controls.Add(this.otherSpecsGroupBox);
            this.Controls.Add(this.cpuGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.Shown += new System.EventHandler(this.OrderForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cpuGroupBox.ResumeLayout(false);
            this.cpuGroupBox.PerformLayout();
            this.otherSpecsGroupBox.ResumeLayout(false);
            this.otherSpecsGroupBox.PerformLayout();
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button cancelButton;
    }
}