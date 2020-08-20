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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
            nextButton.Enabled = false;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void SelectFormDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(SelectFormDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            string MFG = SelectFormDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string model = SelectFormDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string price = String.Format("{0:C}", decimal.Parse(SelectFormDataGridView.SelectedRows[0].Cells[1].Value.ToString()));
            selectResultTextBox.Text = $"{MFG} {model} Priced at: {price}";
            nextButton.Enabled = true;
        }

        private void SelectFormDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex < 0)
            {
                return;
            }
            SelectFormDataGridView.Rows[rowIndex].Selected = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            product selectedProduct = new product();
            selectedProduct.productID = short.Parse(SelectFormDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            selectedProduct.cost = decimal.Parse(SelectFormDataGridView.SelectedRows[0].Cells[1].Value.ToString());
            selectedProduct.manufacturer = SelectFormDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            selectedProduct.model = SelectFormDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            selectedProduct.RAM_type = SelectFormDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            selectedProduct.RAM_size = SelectFormDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            selectedProduct.displaytype = SelectFormDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            selectedProduct.screensize = SelectFormDataGridView.SelectedRows[0].Cells[7].Value.ToString();
           
            selectedProduct.resolution = SelectFormDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            selectedProduct.CPU_Class = SelectFormDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            selectedProduct.CPU_brand = SelectFormDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            selectedProduct.CPU_type = SelectFormDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            selectedProduct.CPU_speed = SelectFormDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            selectedProduct.CPU_number = SelectFormDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            selectedProduct.condition = SelectFormDataGridView.SelectedRows[0].Cells[14].Value.ToString();
            selectedProduct.OS = SelectFormDataGridView.SelectedRows[0].Cells[15].Value.ToString();
            selectedProduct.platform = SelectFormDataGridView.SelectedRows[0].Cells[16].Value.ToString();
            selectedProduct.HDD_size = SelectFormDataGridView.SelectedRows[0].Cells[17].Value.ToString();
            selectedProduct.HDD_speed = SelectFormDataGridView.SelectedRows[0].Cells[18].Value.ToString();
            selectedProduct.GPU_Type = SelectFormDataGridView.SelectedRows[0].Cells[19].Value.ToString();
            selectedProduct.optical_drive = SelectFormDataGridView.SelectedRows[0].Cells[20].Value.ToString();
            selectedProduct.Audio_type = SelectFormDataGridView.SelectedRows[0].Cells[21].Value.ToString();
            selectedProduct.LAN = SelectFormDataGridView.SelectedRows[0].Cells[22].Value.ToString();
            selectedProduct.WIFI = SelectFormDataGridView.SelectedRows[0].Cells[23].Value.ToString();
            selectedProduct.width = SelectFormDataGridView.SelectedRows[0].Cells[24].Value.ToString();
            selectedProduct.height = SelectFormDataGridView.SelectedRows[0].Cells[25].Value.ToString();
            selectedProduct.depth = SelectFormDataGridView.SelectedRows[0].Cells[26].Value.ToString();
            selectedProduct.weight = SelectFormDataGridView.SelectedRows[0].Cells[27].Value.ToString();
            selectedProduct.moust_type = SelectFormDataGridView.SelectedRows[0].Cells[28].Value.ToString();
            selectedProduct.power = SelectFormDataGridView.SelectedRows[0].Cells[29].Value.ToString();
            selectedProduct.webcam = SelectFormDataGridView.SelectedRows[0].Cells[30].Value.ToString();
            Program.product = selectedProduct;
            Program.productInfoForm.Show();
            Hide();
        }
    }
}
