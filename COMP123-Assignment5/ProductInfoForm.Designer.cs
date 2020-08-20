namespace COMP123_Assignment5
{
    partial class ProductInfoForm
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
            this.productInfoSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.productInfoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.productInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufactuerTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.techSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.gpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.webCamTextBox = new System.Windows.Forms.TextBox();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.cpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.cpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.hddLabel = new System.Windows.Forms.Label();
            this.lcdSizeLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.cpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.selectAnotherButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.productInfoMenuStrip.SuspendLayout();
            this.productInfoGroupBox.SuspendLayout();
            this.techSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productInfoSaveFileDialog
            // 
            this.productInfoSaveFileDialog.DefaultExt = "txt";
            this.productInfoSaveFileDialog.FileName = "Product";
            this.productInfoSaveFileDialog.Filter = "Text files|*.txt|All Files|\".\"";
            // 
            // productInfoOpenFileDialog
            // 
            this.productInfoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // productInfoMenuStrip
            // 
            this.productInfoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.productInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.productInfoMenuStrip.Name = "productInfoMenuStrip";
            this.productInfoMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.productInfoMenuStrip.TabIndex = 0;
            this.productInfoMenuStrip.Text = "menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProduct_Click);
            // 
            // productInfoGroupBox
            // 
            this.productInfoGroupBox.Controls.Add(this.modelTextBox);
            this.productInfoGroupBox.Controls.Add(this.manufactuerTextBox);
            this.productInfoGroupBox.Controls.Add(this.manufacturerLabel);
            this.productInfoGroupBox.Controls.Add(this.modelLabel);
            this.productInfoGroupBox.Controls.Add(this.osTextBox);
            this.productInfoGroupBox.Controls.Add(this.osLabel);
            this.productInfoGroupBox.Controls.Add(this.platformLabel);
            this.productInfoGroupBox.Controls.Add(this.platformTextBox);
            this.productInfoGroupBox.Location = new System.Drawing.Point(47, 106);
            this.productInfoGroupBox.Name = "productInfoGroupBox";
            this.productInfoGroupBox.Size = new System.Drawing.Size(702, 100);
            this.productInfoGroupBox.TabIndex = 1;
            this.productInfoGroupBox.TabStop = false;
            this.productInfoGroupBox.Text = "Product Info";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(323, 63);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(358, 22);
            this.modelTextBox.TabIndex = 15;
            // 
            // manufactuerTextBox
            // 
            this.manufactuerTextBox.Location = new System.Drawing.Point(119, 63);
            this.manufactuerTextBox.Name = "manufactuerTextBox";
            this.manufactuerTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufactuerTextBox.TabIndex = 14;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(21, 66);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(92, 17);
            this.manufacturerLabel.TabIndex = 13;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(260, 66);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 17);
            this.modelLabel.TabIndex = 12;
            this.modelLabel.Text = "Model";
            // 
            // osTextBox
            // 
            this.osTextBox.Location = new System.Drawing.Point(323, 21);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(358, 22);
            this.osTextBox.TabIndex = 10;
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(267, 26);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(28, 17);
            this.osLabel.TabIndex = 11;
            this.osLabel.Text = "OS";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Location = new System.Drawing.Point(21, 26);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(60, 17);
            this.platformLabel.TabIndex = 10;
            this.platformLabel.Text = "Platform";
            // 
            // platformTextBox
            // 
            this.platformTextBox.Location = new System.Drawing.Point(119, 23);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.Size = new System.Drawing.Size(100, 22);
            this.platformTextBox.TabIndex = 10;
            // 
            // hddTextBox
            // 
            this.hddTextBox.Location = new System.Drawing.Point(565, 42);
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.Size = new System.Drawing.Size(131, 22);
            this.hddTextBox.TabIndex = 16;
            // 
            // techSpecsGroupBox
            // 
            this.techSpecsGroupBox.Controls.Add(this.gpuTypeTextBox);
            this.techSpecsGroupBox.Controls.Add(this.webCamTextBox);
            this.techSpecsGroupBox.Controls.Add(this.gpuTypeLabel);
            this.techSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.techSpecsGroupBox.Controls.Add(this.hddTextBox);
            this.techSpecsGroupBox.Controls.Add(this.lcdSizeTextBox);
            this.techSpecsGroupBox.Controls.Add(this.cpuSpeedTextBox);
            this.techSpecsGroupBox.Controls.Add(this.cpuNumberTextBox);
            this.techSpecsGroupBox.Controls.Add(this.hddLabel);
            this.techSpecsGroupBox.Controls.Add(this.lcdSizeLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuNumberLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuSpeedLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuTypeTextBox);
            this.techSpecsGroupBox.Controls.Add(this.cpuBrandTextBox);
            this.techSpecsGroupBox.Controls.Add(this.memoryTextBox);
            this.techSpecsGroupBox.Controls.Add(this.memoryLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuBrandLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuTypeLabel);
            this.techSpecsGroupBox.Location = new System.Drawing.Point(47, 228);
            this.techSpecsGroupBox.Name = "techSpecsGroupBox";
            this.techSpecsGroupBox.Size = new System.Drawing.Size(702, 165);
            this.techSpecsGroupBox.TabIndex = 2;
            this.techSpecsGroupBox.TabStop = false;
            this.techSpecsGroupBox.Text = "Tech Specs";
            // 
            // gpuTypeTextBox
            // 
            this.gpuTypeTextBox.Location = new System.Drawing.Point(564, 85);
            this.gpuTypeTextBox.Name = "gpuTypeTextBox";
            this.gpuTypeTextBox.Size = new System.Drawing.Size(131, 22);
            this.gpuTypeTextBox.TabIndex = 30;
            // 
            // webCamTextBox
            // 
            this.webCamTextBox.Location = new System.Drawing.Point(564, 135);
            this.webCamTextBox.Name = "webCamTextBox";
            this.webCamTextBox.Size = new System.Drawing.Size(131, 22);
            this.webCamTextBox.TabIndex = 29;
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.AutoSize = true;
            this.gpuTypeLabel.Location = new System.Drawing.Point(484, 90);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(74, 17);
            this.gpuTypeLabel.TabIndex = 28;
            this.gpuTypeLabel.Text = "GPU Type";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(484, 135);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(65, 17);
            this.WebCamLabel.TabIndex = 27;
            this.WebCamLabel.Text = "WebCam";
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Location = new System.Drawing.Point(357, 47);
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.lcdSizeTextBox.TabIndex = 26;
            // 
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(357, 137);
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuSpeedTextBox.TabIndex = 25;
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Location = new System.Drawing.Point(357, 92);
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuNumberTextBox.TabIndex = 24;
            // 
            // hddLabel
            // 
            this.hddLabel.AutoSize = true;
            this.hddLabel.Location = new System.Drawing.Point(484, 47);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(38, 17);
            this.hddLabel.TabIndex = 23;
            this.hddLabel.Text = "HDD";
            // 
            // lcdSizeLabel
            // 
            this.lcdSizeLabel.AutoSize = true;
            this.lcdSizeLabel.Location = new System.Drawing.Point(260, 45);
            this.lcdSizeLabel.Name = "lcdSizeLabel";
            this.lcdSizeLabel.Size = new System.Drawing.Size(66, 17);
            this.lcdSizeLabel.TabIndex = 22;
            this.lcdSizeLabel.Text = "LCD Size";
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.AutoSize = true;
            this.cpuNumberLabel.Location = new System.Drawing.Point(260, 95);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.cpuNumberLabel.TabIndex = 21;
            this.cpuNumberLabel.Text = "CPU Number";
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.AutoSize = true;
            this.cpuSpeedLabel.Location = new System.Drawing.Point(260, 135);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(81, 17);
            this.cpuSpeedLabel.TabIndex = 20;
            this.cpuSpeedLabel.Text = "CPU Speed";
            // 
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Location = new System.Drawing.Point(119, 137);
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuTypeTextBox.TabIndex = 17;
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Location = new System.Drawing.Point(119, 90);
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.Size = new System.Drawing.Size(100, 22);
            this.cpuBrandTextBox.TabIndex = 18;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(119, 42);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.memoryTextBox.TabIndex = 19;
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(21, 42);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(58, 17);
            this.memoryLabel.TabIndex = 13;
            this.memoryLabel.Text = "Memory";
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.AutoSize = true;
            this.cpuBrandLabel.Location = new System.Drawing.Point(21, 90);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(78, 17);
            this.cpuBrandLabel.TabIndex = 12;
            this.cpuBrandLabel.Text = "CPU Brand";
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.AutoSize = true;
            this.cpuTypeLabel.Location = new System.Drawing.Point(21, 135);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(72, 17);
            this.cpuTypeLabel.TabIndex = 11;
            this.cpuTypeLabel.Text = "CPU Type";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(12, 425);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(326, 25);
            this.confirmLabel.TabIndex = 3;
            this.confirmLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product ID";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(307, 49);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(67, 17);
            this.conditionLabel.TabIndex = 5;
            this.conditionLabel.Text = "Condition";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(166, 49);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.productIdTextBox.TabIndex = 6;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(416, 48);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 22);
            this.conditionTextBox.TabIndex = 7;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(561, 48);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(36, 17);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Cost";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(628, 46);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 9;
            // 
            // selectAnotherButton
            // 
            this.selectAnotherButton.Location = new System.Drawing.Point(382, 425);
            this.selectAnotherButton.Name = "selectAnotherButton";
            this.selectAnotherButton.Size = new System.Drawing.Size(176, 23);
            this.selectAnotherButton.TabIndex = 10;
            this.selectAnotherButton.Text = "Select Another Product";
            this.selectAnotherButton.UseVisualStyleBackColor = true;
            this.selectAnotherButton.Click += new System.EventHandler(this.selectAnotherProduct_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(593, 425);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(696, 425);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectAnotherButton);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.techSpecsGroupBox);
            this.Controls.Add(this.productInfoGroupBox);
            this.Controls.Add(this.productInfoMenuStrip);
            this.MainMenuStrip = this.productInfoMenuStrip;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.productInfoMenuStrip.ResumeLayout(false);
            this.productInfoMenuStrip.PerformLayout();
            this.productInfoGroupBox.ResumeLayout(false);
            this.productInfoGroupBox.PerformLayout();
            this.techSpecsGroupBox.ResumeLayout(false);
            this.techSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog productInfoSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog productInfoOpenFileDialog;
        private System.Windows.Forms.MenuStrip productInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.GroupBox productInfoGroupBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.GroupBox techSpecsGroupBox;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox hddTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufactuerTextBox;
        private System.Windows.Forms.Label lcdSizeLabel;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.TextBox cpuTypeTextBox;
        private System.Windows.Forms.TextBox cpuBrandTextBox;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.TextBox gpuTypeTextBox;
        private System.Windows.Forms.TextBox webCamTextBox;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.TextBox lcdSizeTextBox;
        private System.Windows.Forms.TextBox cpuSpeedTextBox;
        private System.Windows.Forms.TextBox cpuNumberTextBox;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Button selectAnotherButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
    }
}