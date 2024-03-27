using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DealershipProgram
{
    public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
        pbtn1.Click += new EventHandler(pbtn1_Click);
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }

    private void label9_Click(object sender, EventArgs e)
    {

    }

    private void lbx1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void gbx1_Enter(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void cmbx1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void pbtn1_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tbx1.Text) ||
            string.IsNullOrEmpty(tbx2.Text) ||
            string.IsNullOrEmpty(tbx3.Text) ||
            string.IsNullOrEmpty(tbx4.Text) ||
            cmbx1.SelectedIndex == -1)

        {
            MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        gbx1.Enabled = false;
        gbx2.BackColor = SystemColors.Control;
        gbx3.BackColor = SystemColors.Control;
        gbx4.BackColor = SystemColors.Control;

        switch (cmbx1.SelectedItem.ToString())
        {
            case "Cars":
                gbx2.Enabled = true;
                break;
            case "Computers":
                gbx3.Enabled = true;
                break;
            case "Jets":
                gbx4.Enabled = true;
                break;
        }
    }

    private void acb3_Click(object sender, EventArgs e)
    {
        FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);

        string carCondition;

        if (cbx1.Checked && cbx2.Checked)
        {
            MessageBox.Show("Please specify if the vehicle is new or old. Both options cannot be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (!cbx1.Checked && !cbx2.Checked)
        {
            MessageBox.Show("Please specify if the vehicle is new or old.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        else if (cbx1.Checked)
        {
            carCondition = "New";
        }
        else
        {
            carCondition = "Old";
        }

        sw.WriteLine($"Cars;" + $"ID:{tbx1.Text};" + $"Model:{tbx2.Text};" + $"Brand:{tbx3.Text};" + $"Price:{tbx4.Text};" + $"Horsepower:{tbx5.Text};" + $"Cylindersize:{tbx6.Text};" + $"{carCondition}");
        sw.Close();
        fs.Close();
        MessageBox.Show("New Car Product has been added", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearTextBoxesInGroupBox(gbx1);
        ClearTextBoxesInGroupBox(gbx2);
        gbx1.Enabled = true;
        gbx2.Enabled = false;
    }

    private void acb4_Click(object sender, EventArgs e)
    {
        FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);

        sw.WriteLine($"Computers;" + $"ID:{tbx1.Text};" + $"Model:{tbx2.Text};" + $"Brand:{tbx3.Text};" + $"Price:{tbx4.Text};" + $"Ram:{tbx7.Text};" + $"Storage:{tbx8.Text};" + $"Screentype:{tbx9.Text}");
        sw.Close();
        fs.Close();
        MessageBox.Show("New Computer Product has been added", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearTextBoxesInGroupBox(gbx1);
        ClearTextBoxesInGroupBox(gbx3);
        gbx1.Enabled = true;
        gbx3.Enabled = false;
    }

    private void ajb5_Click(object sender, EventArgs e)
    {
        FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);

        string comboBox2Selection = comboBox2.SelectedItem?.ToString() ?? "Not Selected";

        sw.WriteLine($"Jets;" + $"ID:{tbx1.Text};" + $"Model:{tbx2.Text};" + $"Brand:{tbx3.Text};" + $"Price:{tbx4.Text};" + $"Capacity:{tbx10.Text};" + $"Fueltype:{tbx11.Text};" + $"{comboBox2Selection}");
        sw.Close();
        fs.Close();
        MessageBox.Show("New Jet Product has been added", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearTextBoxesInGroupBox(gbx1);
        ClearTextBoxesInGroupBox(gbx4);
        gbx1.Enabled = true;
        gbx4.Enabled = false;
    }

    private void ClearTextBoxesInGroupBox(GroupBox groupBox)
    {
        foreach (Control control in groupBox.Controls)
        {
            if (control is TextBox)
            {
                control.Text = string.Empty;
            }
        }
    }

    private void cbx1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbx2_CheckedChanged(object sender, EventArgs e)
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