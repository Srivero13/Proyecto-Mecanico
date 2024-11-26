using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Proyecto_Mecanico
{
    public partial class Form5 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form5()
        {
            InitializeComponent();
            this.Text = "Confirmacion de mecanico";
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


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Muchas gracias por la paciencia.\n\n"+
                $"Esperamos que su problema sea resuelto a la brevedad\n"+
                $"Gracias por utilizar la aplicacion!");
            this.Close();
        }
    }
}
