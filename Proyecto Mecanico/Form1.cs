using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Proyecto_Mecanico

{
    public partial class Form1 : Form
    {
        private static readonly Dictionary<char, int> YearTable = new Dictionary<char, int>
    {
        { 'A', 1980 }, { 'B', 1981 }, { 'C', 1982 }, { 'D', 1983 }, { 'E', 1984 },
        { 'F', 1985 }, { 'G', 1986 }, { 'H', 1987 }, { 'J', 1988 }, { 'K', 1989 },
        { 'L', 1990 }, { 'M', 1991 }, { 'N', 1992 }, { 'P', 1993 }, { 'R', 1994 },
        { 'S', 1995 }, { 'T', 1996 }, { 'V', 1997 }, { 'W', 1998 }, { 'X', 1999 },
        { 'Y', 2000 }, { '1', 2001 }, { '2', 2002 }, { '3', 2003 }, { '4', 2004 },
        { '5', 2005 }, { '6', 2006 }, { '7', 2007 }, { '8', 2008 }, { '9', 2009 }
    };

        private static readonly Dictionary<string, string> ManufacturerTable = new Dictionary<string, string>
    {
        { "1HG", "Honda" },
        { "2HG", "Honda" },
        { "1FA", "Ford" },
        { "1FD", "Ford" },
        { "WVW", "Volkswagen" },
        { "3VW", "Volkswagen" },
        { "JHM", "Honda" },
        { "JTM", "Toyota" },
        { "5TD", "Toyota" },
        { "1G1", "Chevrolet" }
    };
        private static readonly Dictionary<string, List<(string Model, string Engine)>> ModelEngineTable =
            new Dictionary<string, List<(string Model, string Engine)>>
        {
            { "Honda", new List<(string, string)>
                {
                    ("Civic", "1.8L I4"),
                    ("Accord", "2.4L I4"),
                    ("CR-V", "2.0L I4 Turbo")
                }
            },
            { "Ford", new List<(string, string)>
                {
                    ("Focus", "2.0L I4"),
                    ("F-150", "3.5L V6 EcoBoost"),
                    ("Mustang", "5.0L V8")
                }
            },
            { "Volkswagen", new List<(string, string)>
                {
                    ("Golf", "1.4L TSI"),
                    ("Passat", "2.0L TDI"),
                    ("Tiguan", "2.0L TSI")
                }
            }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string vin = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(vin) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de confirmar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = DecodificarVin(vin);
            if (!result.IsValid)
            {
                MessageBox.Show("El VIN ingresado no es válido.", "VIN inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 obj = new Form2(result.Manufacturer, result.Year, result.Model, result.Engine);
            this.Hide();
            obj.FormClosed += (s, args) => this.Close();
            obj.Show();
        }

        private (bool IsValid, string Manufacturer, int Year, string Model, string Engine) DecodificarVin(string vin)
        {
            if (vin.Length != 17)
                return (false, "Desconocido", 0, "Desconocido", "Desconocido");

            foreach (char c in vin)
            {
                if (!char.IsLetterOrDigit(c) || "IOQ".Contains(c))
                    return (false, "Desconocido", 0, "Desconocido", "Desconocido");
            }

            string wmi = vin.Substring(0, 3);
            string manufacturer = ManufacturerTable.ContainsKey(wmi) ? ManufacturerTable[wmi] : "Desconocido";

            char yearCode = vin[9];
            int year = YearTable.ContainsKey(yearCode) ? YearTable[yearCode] : 0;

            string model = "Modelo genérico";
            string engine = "Motor estándar";

            if (ModelEngineTable.ContainsKey(manufacturer))
            {
                var options = ModelEngineTable[manufacturer];
                var selectedOption = options[new Random().Next(options.Count)];
                model = selectedOption.Model;
                engine = selectedOption.Engine;
            }

            return (true, manufacturer, year, model, engine);
        }
    }
}