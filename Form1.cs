namespace DealershipProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Form3 infoForm = new Form3();
            infoForm.Show();
            this.Hide();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Form2 infoForm = new Form2();
            infoForm.Show();
            this.Hide();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Form4 infoForm = new Form4();
            infoForm.Show();
            this.Hide();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
