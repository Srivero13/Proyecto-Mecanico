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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelModel = new Label();
            labelYear = new Label();
            labelEngine = new Label();
            labelManufacturer = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(49, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(49, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 64);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(49, 369);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 64);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(49, 467);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(76, 64);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 207);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 5;
            label1.Text = "Rueda pinchada";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(154, 302);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 6;
            label2.Text = "Solicitar grua";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(154, 396);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 7;
            label3.Text = "Problema electrico";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(154, 489);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 8;
            label4.Text = "Otro";
            label4.Click += label4_Click;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.BackColor = Color.Transparent;
            labelModel.Font = new Font("Segoe UI", 14.25F);
            labelModel.Location = new Point(12, 117);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(77, 25);
            labelModel.TabIndex = 10;
            labelModel.Text = "Modelo";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.Transparent;
            labelYear.Font = new Font("Segoe UI", 14.25F);
            labelYear.Location = new Point(12, 67);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(46, 25);
            labelYear.TabIndex = 11;
            labelYear.Text = "Año";
            // 
            // labelEngine
            // 
            labelEngine.AutoSize = true;
            labelEngine.BackColor = Color.Transparent;
            labelEngine.Font = new Font("Segoe UI", 14.25F);
            labelEngine.Location = new Point(13, 142);
            labelEngine.Name = "labelEngine";
            labelEngine.Size = new Size(64, 25);
            labelEngine.TabIndex = 12;
            labelEngine.Text = "Motor";
            // 
            // labelManufacturer
            // 
            labelManufacturer.AutoSize = true;
            labelManufacturer.BackColor = Color.Transparent;
            labelManufacturer.Font = new Font("Segoe UI", 14.25F);
            labelManufacturer.Location = new Point(12, 92);
            labelManufacturer.Name = "labelManufacturer";
            labelManufacturer.Size = new Size(65, 25);
            labelManufacturer.TabIndex = 13;
            labelManufacturer.Text = "Marca";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(519, 637);
            Controls.Add(labelEngine);
            Controls.Add(labelManufacturer);
            Controls.Add(labelModel);
            Controls.Add(label4);
            Controls.Add(labelYear);
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
        private Label labelModel;
        private Label labelYear;
        private Label labelEngine;
        private Label labelManufacturer;
    }
}