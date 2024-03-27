namespace DealershipProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt1 = new Button();
            btexit = new Button();
            bt2 = new Button();
            bt3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.BackColor = Color.DimGray;
            bt1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bt1.ForeColor = Color.White;
            bt1.Location = new Point(204, 208);
            bt1.Name = "bt1";
            bt1.Size = new Size(253, 36);
            bt1.TabIndex = 3;
            bt1.Text = "Add Products";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // btexit
            // 
            btexit.BackColor = Color.Firebrick;
            btexit.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btexit.ForeColor = SystemColors.ButtonHighlight;
            btexit.Location = new Point(187, 373);
            btexit.Name = "btexit";
            btexit.Size = new Size(289, 37);
            btexit.TabIndex = 6;
            btexit.Text = "EXIT";
            btexit.UseVisualStyleBackColor = false;
            btexit.Click += btexit_Click;
            // 
            // bt2
            // 
            bt2.BackColor = Color.DimGray;
            bt2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bt2.ForeColor = Color.White;
            bt2.Location = new Point(204, 259);
            bt2.Name = "bt2";
            bt2.Size = new Size(253, 36);
            bt2.TabIndex = 7;
            bt2.Text = "See Products";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.BackColor = Color.DimGray;
            bt3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bt3.ForeColor = Color.White;
            bt3.Location = new Point(204, 311);
            bt3.Name = "bt3";
            bt3.Size = new Size(253, 36);
            bt3.TabIndex = 8;
            bt3.Text = "See Reports";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += bt3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 76);
            label1.Name = "label1";
            label1.Size = new Size(446, 47);
            label1.TabIndex = 9;
            label1.Text = "Vistula Dealership";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 141);
            label2.Name = "label2";
            label2.Size = new Size(203, 40);
            label2.TabIndex = 10;
            label2.Text = "Main Menu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(665, 513);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(btexit);
            Controls.Add(bt1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt1;
        private Button btexit;
        private Button bt2;
        private Button bt3;
        private Label label1;
        private Label label2;
    }
}
