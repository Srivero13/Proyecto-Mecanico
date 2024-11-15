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

namespace Proyecto_Mecanico
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            MessageBox.Show("Exito al guardar resultados!");
        }
    }
}
