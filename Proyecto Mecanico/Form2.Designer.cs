namespace Proyecto_Mecanico
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources._2761439;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(64, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 175);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._887203;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(278, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 175);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources._2546898;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(64, 326);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(208, 175);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.help_icon_26;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(278, 326);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(208, 175);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 299);
            label1.Name = "label1";
            label1.Size = new Size(142, 22);
            label1.TabIndex = 5;
            label1.Text = "Rueda pinchada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 299);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 6;
            label2.Text = "Solicitar grua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 504);
            label3.Name = "label3";
            label3.Size = new Size(164, 22);
            label3.TabIndex = 7;
            label3.Text = "Problema electrico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(355, 504);
            label4.Name = "label4";
            label4.Size = new Size(49, 22);
            label4.TabIndex = 8;
            label4.Text = "Otro";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(149, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(30, 35);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 10;
            label5.Text = "Numero de VIN:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 80);
            panel1.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(519, 637);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Panel panel1;
    }
}