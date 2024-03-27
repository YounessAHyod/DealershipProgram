namespace DealershipProgram
{
    partial class Form4
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(72, 62);
            label1.Name = "label1";
            label1.Size = new Size(117, 24);
            label1.TabIndex = 0;
            label1.Text = "Report Type:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Product Brand", "Product Type", "Product Price" });
            comboBox1.Location = new Point(233, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(447, 57);
            button1.Name = "button1";
            button1.Size = new Size(254, 33);
            button1.TabIndex = 2;
            button1.Text = "Generate Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(72, 109);
            label2.Name = "label2";
            label2.Size = new Size(659, 253);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(81, 386);
            button2.Name = "button2";
            button2.Size = new Size(638, 41);
            button2.TabIndex = 4;
            button2.Text = "Back To Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private Button button2;
    }
}