using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipProgram
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedReportType = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedReportType))
            {
                label2.Text = "Please select a report type.";
                return;
            }

            string[] lines = File.ReadAllLines("Products.txt");
            switch (selectedReportType)
            {
                case "Product Brand":
                    label2.Text = GenerateBrandReport(lines);
                    break;
                case "Product Type":
                    label2.Text = GenerateTypeReport(lines);
                    break;
                case "Product Price":
                    label2.Text = GeneratePriceReport(lines);
                    break;
                default:
                    label2.Text = "Invalid report type selected.";
                    break;
            }
        }

        private string GenerateBrandReport(string[] lines)
        {
            var brandCounts = new Dictionary<string, int>();
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length >= 4)
                {
                    string brand = parts[3];
                    if (!brandCounts.ContainsKey(brand))
                    {
                        brandCounts[brand] = 0;
                    }
                    brandCounts[brand]++;
                }
            }

            return string.Join("\n", brandCounts.Select(kvp => $"Number of products from {kvp.Key}: {kvp.Value}"));
        }

        private string GenerateTypeReport(string[] lines)
        {
            var typeCounts = new Dictionary<string, int>();
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length >= 4)
                {
                    string type = parts[0];
                    if (!typeCounts.ContainsKey(type))
                    {
                        typeCounts[type] = 0;
                    }
                    typeCounts[type]++;
                }
            }

            return string.Join("\n", typeCounts.Select(kvp => $"Number of {kvp.Key}: {kvp.Value}"));
        }

        private string GeneratePriceReport(string[] lines)
        {
            var prices = new Dictionary<string, (decimal MaxPrice, decimal MinPrice)>();
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length >= 5)
                {
                    string type = parts[0].Trim(); // Assuming type is at index 0
                    string pricePart = parts[4].Trim(); // Assuming price is at index 4

                    // Extracting the numeric part of the price
                    if (pricePart.StartsWith("Price:") && decimal.TryParse(pricePart.Substring(6), out decimal price))
                    {
                        if (!prices.ContainsKey(type))
                        {
                            prices[type] = (price, price);
                        }
                        else
                        {
                            var current = prices[type];
                            prices[type] = (Math.Max(current.MaxPrice, price), Math.Min(current.MinPrice, price));
                        }
                    }
                }
            }

            var result = new StringBuilder();
            foreach (var kvp in prices)
            {
                result.AppendLine($"Most Expensive {kvp.Key}: ${kvp.Value.MaxPrice}");
                result.AppendLine($"Most Cheapest {kvp.Key}: ${kvp.Value.MinPrice}");
            }
            return result.ToString();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 infoForm = new Form1();
            infoForm.Show();
            Hide();
        }
    }
}
