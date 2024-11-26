using Microsoft.VisualBasic;
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
    public partial class Form3 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form3()
        {
            InitializeComponent();
            this.Text = "Ubicacion";
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
            button1.Visible=false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Visible=true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de confirmar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Exito al guardar resultados!");
            Form4 form = new Form4();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

    
    }
}
