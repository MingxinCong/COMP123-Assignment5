using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
            nextButton.Enabled = false;
            PopulateTextBoxes();
        }

        private void PopulateTextBoxes()
        {
            if(Program.product == null)
            {
                return;
            }
            productIdTextBox.Text = Program.product.productID.ToString();
            conditionTextBox.Text = Program.product.condition;
            costTextBox.Text = Program.product.cost.ToString();
            platformTextBox.Text = Program.product.platform;
            osTextBox.Text = Program.product.OS;
            manufactuerTextBox.Text = Program.product.manufacturer;
            modelTextBox.Text = Program.product.model;
            memoryTextBox.Text = Program.product.RAM_size;
            lcdSizeTextBox.Text = Program.product.screensize;
            hddTextBox.Text = Program.product.HDD_size;
            cpuBrandTextBox.Text = Program.product.CPU_brand;
            cpuNumberTextBox.Text = Program.product.CPU_number;
            gpuTypeTextBox.Text = Program.product.GPU_Type;
            cpuTypeTextBox.Text = Program.product.CPU_type;
            cpuSpeedTextBox.Text = Program.product.CPU_speed;
            webCamTextBox.Text = Program.product.webcam;
            nextButton.Enabled = true;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productInfoOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult openFileDialogResult = productInfoOpenFileDialog.ShowDialog();

            if (openFileDialogResult != DialogResult.Cancel)
            {
                StreamReader streamReader = new StreamReader(productInfoOpenFileDialog.FileName);
                productIdTextBox.Text = streamReader.ReadLine();
                conditionTextBox.Text = streamReader.ReadLine();
                costTextBox.Text = streamReader.ReadLine();
                platformTextBox.Text = streamReader.ReadLine();
                osTextBox.Text = streamReader.ReadLine();
                manufactuerTextBox.Text = streamReader.ReadLine();
                modelTextBox.Text = streamReader.ReadLine();
                memoryTextBox.Text = streamReader.ReadLine();
                lcdSizeTextBox.Text = streamReader.ReadLine();
                hddTextBox.Text = streamReader.ReadLine();
                cpuBrandTextBox.Text = streamReader.ReadLine();
                cpuNumberTextBox.Text = streamReader.ReadLine();
                gpuTypeTextBox.Text = streamReader.ReadLine();
                cpuTypeTextBox.Text = streamReader.ReadLine();
                cpuSpeedTextBox.Text = streamReader.ReadLine();
                webCamTextBox.Text = streamReader.ReadLine();
                streamReader.Close();
                nextButton.Enabled = true;
                var context = new ProductModel();
                var loadedProduct = from p in context.products
                                    where p.productID.Equals(productIdTextBox.Text)
                                    select p;
                Program.product = loadedProduct.First();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productInfoSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            var saveFileDialogResult = productInfoSaveFileDialog.ShowDialog();
            if (saveFileDialogResult != DialogResult.Cancel)
            {
                StreamWriter streamWriter = new StreamWriter(productInfoSaveFileDialog.FileName);
                streamWriter.WriteLine(productIdTextBox.Text);
                streamWriter.WriteLine(conditionTextBox.Text);
                streamWriter.WriteLine(costTextBox.Text);
                streamWriter.WriteLine(platformTextBox.Text);
                streamWriter.WriteLine(osTextBox.Text);
                streamWriter.WriteLine(manufactuerTextBox.Text);
                streamWriter.WriteLine(modelTextBox.Text);
                streamWriter.WriteLine(memoryTextBox.Text);
                streamWriter.WriteLine(lcdSizeTextBox.Text);
                streamWriter.WriteLine(hddTextBox.Text);
                streamWriter.WriteLine(cpuBrandTextBox.Text);
                streamWriter.WriteLine(cpuNumberTextBox.Text);
                streamWriter.WriteLine(gpuTypeTextBox.Text);
                streamWriter.WriteLine(cpuTypeTextBox.Text);
                streamWriter.WriteLine(cpuSpeedTextBox.Text);
                streamWriter.WriteLine(webCamTextBox.Text);
                streamWriter.Flush();
                streamWriter.Close();
            }

        }

        private void selectAnotherProduct_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            Hide();
        }

        private void ProductInfoForm_Shown(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }
    }
}
