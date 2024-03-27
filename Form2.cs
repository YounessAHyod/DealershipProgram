using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 infoForm = new Form1();
            infoForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedProductType = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedProductType))
            {
                MessageBox.Show("Please select a product type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] lines = File.ReadAllLines("Products.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length >= 4 && parts[0].Equals(selectedProductType, StringComparison.OrdinalIgnoreCase))
                {
                    // Assuming the format is "ProductType;Model;Brand;..."
                    string brand = parts[3];
                    string model = parts[2];
                    listBox1.Items.Add($"{brand}  {model}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = listBox1.SelectedItem.ToString();
            string[] selectedItemParts = selectedItem.Split(new[] { "  " }, StringSplitOptions.None);
            if (selectedItemParts.Length < 2)
            {
                MessageBox.Show("Invalid selection format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedBrand = selectedItemParts[0];
            string selectedModel = selectedItemParts[1];

            string[] lines = File.ReadAllLines("Products.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length >= 4 && parts[3] == selectedBrand && parts[2] == selectedModel)
                {
                    DisplayProductInfo(parts, groupBox1);
                    break;
                }
            }
        }
        private void DisplayProductInfo(string[] productInfo, GroupBox groupBox)
        {
            groupBox.Controls.Clear(); 

            int totalItems = productInfo.Length;
            int halfItems = totalItems / 2;

            int yPosLeft = 20;
            int yPosRight = 20;
            int xOffset = groupBox.Width / 2; 

            for (int i = 0; i < totalItems; i++)
            {
                Label label = new Label
                {
                    Text = productInfo[i],
                    AutoSize = true
                };

                if (i < halfItems)
                {
                    
                    label.Location = new Point(10, yPosLeft);
                    yPosLeft += 25; 
                }
                else
                {
                    label.Location = new Point(xOffset, yPosRight);
                    yPosRight += 25; 
                }

                groupBox.Controls.Add(label);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
