namespace DealershipProgram
{
    partial class Form2
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
            listBox1 = new ListBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 48);
            label1.Name = "label1";
            label1.Size = new Size(228, 47);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cars", "Computers", "Jets" });
            comboBox1.Location = new Point(34, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Select product...";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 156);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 204);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(34, 405);
            button1.Name = "button1";
            button1.Size = new Size(666, 33);
            button1.TabIndex = 3;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(307, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 204);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(306, 113);
            button2.Name = "button2";
            button2.Size = new Size(73, 30);
            button2.TabIndex = 5;
            button2.Text = "Show";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 366);
            button3.Name = "button3";
            button3.Size = new Size(248, 33);
            button3.TabIndex = 6;
            button3.Text = "Show Information";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(762, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
    }
}