namespace Proyecto_Mecanico
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2024_11_14_213454;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 296);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 1;
            label1.Text = "Selecciona tu ubicacion con un click:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 372);
            label2.Name = "label2";
            label2.Size = new Size(296, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingresa una descripcion mas detallada de tu ubicacion:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 390);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 425);
            label3.Name = "label3";
            label3.Size = new Size(249, 15);
            label3.TabIndex = 4;
            label3.Text = "Realiza una descripcion de tu situacion actual:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 443);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(186, 524);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(127, 499);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(197, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Confirmo los datos introducidos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 637);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
    }
}