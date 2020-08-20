using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is printing");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Hide();
        }

        private void cancelOrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OrderForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for ordering. \n\nYour order will be processed in 7-10 business days");
            Application.Exit();
        }

        private void PopulateTextBoxes()
        {
            conditionTextBox.Text = Program.product.condition;
            costTextBox.Text = String.Format("{0:C2}", Program.product.cost);
            salesTaxTextBox.Text = String.Format("{0:C2}", decimal.Multiply(Program.product.cost ?? 0, (decimal)0.13));
            totalPriceTextBox.Text = String.Format("{0:C2}", decimal.Multiply(Program.product.cost ?? 0, (decimal)1.13));
            platformTextBox.Text = Program.product.platform;
            osTextBox.Text = Program.product.OS;
            manufacturerTextBox.Text = Program.product.manufacturer;
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
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            PopulateTextBoxes();
        }

    
    }
}
