using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Mecanico
{
    public partial class Form4 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form4()
        {
            InitializeComponent();
            this.Text = "Proceder al pago";
            label4.Visible=false;
            pictureBox1.Visible=false;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600,
                Primary.Blue700,
                Primary.Blue200,
                Accent.Orange700,
                TextShade.WHITE
            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label4.Visible=true;
                pictureBox1.Visible=true;
            }
            else
            {
                label4.Visible=false;
                pictureBox1.Visible=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago exitoso!");
            Form5 form = new Form5();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
