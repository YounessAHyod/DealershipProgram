namespace DealershipProgram
{
    partial class Form3
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
            gbx1 = new GroupBox();
            cmbx1 = new ComboBox();
            tbx4 = new TextBox();
            tbx3 = new TextBox();
            tbx2 = new TextBox();
            tbx1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            pbtn1 = new Button();
            gbx2 = new GroupBox();
            tbx6 = new TextBox();
            tbx5 = new TextBox();
            acb3 = new Button();
            label9 = new Label();
            label8 = new Label();
            cbx2 = new CheckBox();
            cbx1 = new CheckBox();
            gbx3 = new GroupBox();
            tbx9 = new TextBox();
            tbx8 = new TextBox();
            tbx7 = new TextBox();
            acb4 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            gbx4 = new GroupBox();
            comboBox2 = new ComboBox();
            tbx11 = new TextBox();
            tbx10 = new TextBox();
            ajb5 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            gbx1.SuspendLayout();
            gbx2.SuspendLayout();
            gbx3.SuspendLayout();
            gbx4.SuspendLayout();
            SuspendLayout();
            // 
            // gbx1
            // 
            gbx1.BackColor = Color.LightCoral;
            gbx1.Controls.Add(cmbx1);
            gbx1.Controls.Add(tbx4);
            gbx1.Controls.Add(tbx3);
            gbx1.Controls.Add(tbx2);
            gbx1.Controls.Add(tbx1);
            gbx1.Controls.Add(label13);
            gbx1.Controls.Add(label12);
            gbx1.Controls.Add(label11);
            gbx1.Controls.Add(label10);
            gbx1.Controls.Add(label1);
            gbx1.Controls.Add(pbtn1);
            gbx1.Location = new Point(12, 13);
            gbx1.Name = "gbx1";
            gbx1.Size = new Size(863, 207);
            gbx1.TabIndex = 0;
            gbx1.TabStop = false;
            gbx1.Text = "General Information";
            gbx1.Enter += gbx1_Enter;
            // 
            // cmbx1
            // 
            cmbx1.FormattingEnabled = true;
            cmbx1.Items.AddRange(new object[] { "Cars", "Computers", "Jets" });
            cmbx1.Location = new Point(93, 40);
            cmbx1.Name = "cmbx1";
            cmbx1.Size = new Size(135, 28);
            cmbx1.TabIndex = 15;
            cmbx1.Text = "Select item...";
            cmbx1.SelectedIndexChanged += cmbx1_SelectedIndexChanged;
            // 
            // tbx4
            // 
            tbx4.Location = new Point(668, 112);
            tbx4.Name = "tbx4";
            tbx4.Size = new Size(140, 27);
            tbx4.TabIndex = 14;
            // 
            // tbx3
            // 
            tbx3.Location = new Point(668, 77);
            tbx3.Name = "tbx3";
            tbx3.Size = new Size(140, 27);
            tbx3.TabIndex = 13;
            // 
            // tbx2
            // 
            tbx2.Location = new Point(93, 112);
            tbx2.Name = "tbx2";
            tbx2.Size = new Size(140, 27);
            tbx2.TabIndex = 12;
            // 
            // tbx1
            // 
            tbx1.Location = new Point(93, 77);
            tbx1.Name = "tbx1";
            tbx1.Size = new Size(140, 27);
            tbx1.TabIndex = 11;
            tbx1.TextChanged += textBox1_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label13.Location = new Point(599, 116);
            label13.Name = "label13";
            label13.Size = new Size(49, 23);
            label13.TabIndex = 10;
            label13.Text = "Price";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.Location = new Point(599, 81);
            label12.Name = "label12";
            label12.Size = new Size(63, 23);
            label12.TabIndex = 9;
            label12.Text = "Brand:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.Location = new Point(23, 116);
            label11.Name = "label11";
            label11.Size = new Size(66, 23);
            label11.TabIndex = 8;
            label11.Text = "Model:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.Location = new Point(23, 81);
            label10.Name = "label10";
            label10.Size = new Size(33, 23);
            label10.TabIndex = 7;
            label10.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 6;
            label1.Text = "Type:";
            // 
            // pbtn1
            // 
            pbtn1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            pbtn1.Location = new Point(21, 165);
            pbtn1.Name = "pbtn1";
            pbtn1.Size = new Size(827, 36);
            pbtn1.TabIndex = 5;
            pbtn1.Text = "Proceed";
            pbtn1.UseVisualStyleBackColor = true;
            pbtn1.Click += pbtn1_Click;
            // 
            // gbx2
            // 
            gbx2.BackColor = Color.Khaki;
            gbx2.Controls.Add(tbx6);
            gbx2.Controls.Add(tbx5);
            gbx2.Controls.Add(acb3);
            gbx2.Controls.Add(label9);
            gbx2.Controls.Add(label8);
            gbx2.Controls.Add(cbx2);
            gbx2.Controls.Add(cbx1);
            gbx2.Enabled = false;
            gbx2.Location = new Point(12, 226);
            gbx2.Name = "gbx2";
            gbx2.Size = new Size(264, 218);
            gbx2.TabIndex = 1;
            gbx2.TabStop = false;
            gbx2.Text = "Add Car";
            // 
            // tbx6
            // 
            tbx6.Location = new Point(148, 88);
            tbx6.Name = "tbx6";
            tbx6.Size = new Size(79, 27);
            tbx6.TabIndex = 16;
            // 
            // tbx5
            // 
            tbx5.Location = new Point(140, 44);
            tbx5.Name = "tbx5";
            tbx5.Size = new Size(79, 27);
            tbx5.TabIndex = 15;
            // 
            // acb3
            // 
            acb3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            acb3.Location = new Point(23, 175);
            acb3.Name = "acb3";
            acb3.Size = new Size(210, 37);
            acb3.TabIndex = 15;
            acb3.Text = "Add Car";
            acb3.UseVisualStyleBackColor = true;
            acb3.Click += acb3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.Location = new Point(23, 92);
            label9.Name = "label9";
            label9.Size = new Size(119, 23);
            label9.TabIndex = 14;
            label9.Text = "Cylinder Size:";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.Location = new Point(21, 48);
            label8.Name = "label8";
            label8.Size = new Size(113, 23);
            label8.TabIndex = 13;
            label8.Text = "Horsepower:";
            // 
            // cbx2
            // 
            cbx2.AutoSize = true;
            cbx2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cbx2.Location = new Point(138, 142);
            cbx2.Name = "cbx2";
            cbx2.Size = new Size(71, 27);
            cbx2.TabIndex = 9;
            cbx2.Text = "Used";
            cbx2.UseVisualStyleBackColor = true;
            cbx2.CheckedChanged += cbx2_CheckedChanged;
            // 
            // cbx1
            // 
            cbx1.AutoSize = true;
            cbx1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cbx1.Location = new Point(21, 142);
            cbx1.Name = "cbx1";
            cbx1.Size = new Size(68, 27);
            cbx1.TabIndex = 8;
            cbx1.Text = "New";
            cbx1.UseVisualStyleBackColor = true;
            cbx1.CheckedChanged += cbx1_CheckedChanged;
            // 
            // gbx3
            // 
            gbx3.BackColor = Color.Khaki;
            gbx3.Controls.Add(tbx9);
            gbx3.Controls.Add(tbx8);
            gbx3.Controls.Add(tbx7);
            gbx3.Controls.Add(acb4);
            gbx3.Controls.Add(label7);
            gbx3.Controls.Add(label6);
            gbx3.Controls.Add(label5);
            gbx3.Enabled = false;
            gbx3.Location = new Point(314, 226);
            gbx3.Name = "gbx3";
            gbx3.Size = new Size(264, 218);
            gbx3.TabIndex = 2;
            gbx3.TabStop = false;
            gbx3.Text = "Add Computers";
            // 
            // tbx9
            // 
            tbx9.Location = new Point(135, 129);
            tbx9.Name = "tbx9";
            tbx9.Size = new Size(79, 27);
            tbx9.TabIndex = 19;
            // 
            // tbx8
            // 
            tbx8.Location = new Point(117, 88);
            tbx8.Name = "tbx8";
            tbx8.Size = new Size(79, 27);
            tbx8.TabIndex = 18;
            // 
            // tbx7
            // 
            tbx7.Location = new Point(117, 44);
            tbx7.Name = "tbx7";
            tbx7.Size = new Size(79, 27);
            tbx7.TabIndex = 17;
            // 
            // acb4
            // 
            acb4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            acb4.Location = new Point(31, 175);
            acb4.Name = "acb4";
            acb4.Size = new Size(210, 37);
            acb4.TabIndex = 16;
            acb4.Text = "Add Computer";
            acb4.UseVisualStyleBackColor = true;
            acb4.Click += acb4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(18, 133);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 12;
            label7.Text = "Screen Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(18, 92);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 11;
            label6.Text = "Storage:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(18, 51);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 10;
            label5.Text = "RAM:";
            // 
            // gbx4
            // 
            gbx4.BackColor = Color.Khaki;
            gbx4.Controls.Add(comboBox2);
            gbx4.Controls.Add(tbx11);
            gbx4.Controls.Add(tbx10);
            gbx4.Controls.Add(ajb5);
            gbx4.Controls.Add(label2);
            gbx4.Controls.Add(label3);
            gbx4.Controls.Add(label4);
            gbx4.Enabled = false;
            gbx4.Location = new Point(611, 226);
            gbx4.Name = "gbx4";
            gbx4.Size = new Size(264, 218);
            gbx4.TabIndex = 3;
            gbx4.TabStop = false;
            gbx4.Text = "Add Jet";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Commercial", "Private" });
            comboBox2.Location = new Point(72, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(135, 28);
            comboBox2.TabIndex = 16;
            comboBox2.Text = "Select item...";
            // 
            // tbx11
            // 
            tbx11.Location = new Point(179, 91);
            tbx11.Name = "tbx11";
            tbx11.Size = new Size(79, 27);
            tbx11.TabIndex = 18;
            // 
            // tbx10
            // 
            tbx10.Location = new Point(103, 47);
            tbx10.Name = "tbx10";
            tbx10.Size = new Size(79, 27);
            tbx10.TabIndex = 17;
            // 
            // ajb5
            // 
            ajb5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ajb5.Location = new Point(28, 175);
            ajb5.Name = "ajb5";
            ajb5.Size = new Size(210, 37);
            ajb5.TabIndex = 16;
            ajb5.Text = "Add Jet";
            ajb5.UseVisualStyleBackColor = true;
            ajb5.Click += ajb5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(13, 51);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 7;
            label2.Text = "Capacity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(13, 94);
            label3.Name = "label3";
            label3.Size = new Size(160, 23);
            label3.TabIndex = 8;
            label3.Text = "Fuel Consumption:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(13, 136);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 9;
            label4.Text = "Type:";
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(33, 459);
            button2.Name = "button2";
            button2.Size = new Size(827, 37);
            button2.TabIndex = 6;
            button2.Text = "Back to menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(898, 504);
            Controls.Add(button2);
            Controls.Add(gbx4);
            Controls.Add(gbx3);
            Controls.Add(gbx2);
            Controls.Add(gbx1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            gbx1.ResumeLayout(false);
            gbx1.PerformLayout();
            gbx2.ResumeLayout(false);
            gbx2.PerformLayout();
            gbx3.ResumeLayout(false);
            gbx3.PerformLayout();
            gbx4.ResumeLayout(false);
            gbx4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbx1;
        private GroupBox gbx2;
        private GroupBox gbx3;
        private GroupBox gbx4;
        private Button pbtn1;
        private Button button2;
        private CheckBox cbx2;
        private CheckBox cbx1;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button acb3;
        private Button acb4;
        private Button ajb5;
        private TextBox tbx4;
        private TextBox tbx3;
        private TextBox tbx2;
        private TextBox tbx1;
        private TextBox tbx6;
        private TextBox tbx5;
        private TextBox tbx9;
        private TextBox tbx8;
        private TextBox tbx7;
        private TextBox tbx11;
        private TextBox tbx10;
        private ComboBox cmbx1;
        private ComboBox comboBox2;
    }
}