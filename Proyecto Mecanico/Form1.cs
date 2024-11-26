using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Mecanico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
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

            var result = await DecodificarVinConApi(vin);
            if (!result.IsValid)
            {
                MessageBox.Show("El VIN ingresado no es válido o no se pudo decodificar.", "VIN inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Form2 obj = new Form2(result.Manufacturer, int.Parse(result.Year), result.Model, result.Engine);
            this.Hide();
            obj.FormClosed += (s, args) => this.Close();
            obj.Show();
        }

        private async Task<(bool IsValid, string Manufacturer, string Year, string Model, string Engine)> DecodificarVinConApi(string vin)
        {
            if (vin.Length != 17)
                return (false, "Desconocido", "Desconocido", "Desconocido", "Desconocido");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"https://vpic.nhtsa.dot.gov/api/vehicles/DecodeVin/{vin}?format=json";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var vinData = JsonSerializer.Deserialize<VinApiResponse>(jsonResponse);

                        if (vinData?.Results != null)
                        {
                            string manufacturer = vinData.Results.Find(r => r.Variable == "Make")?.Value ?? "Desconocido";
                            string year = vinData.Results.Find(r => r.Variable == "Model Year")?.Value ?? "Desconocido";
                            string model = vinData.Results.Find(r => r.Variable == "Model")?.Value ?? "Desconocido";
                            string engine = vinData.Results.Find(r => r.Variable == "Engine Model")?.Value ?? "Desconocido";
                            return (true, manufacturer, year, model, engine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (false, "Desconocido", "Desconocido", "Desconocido", "Desconocido");
        }
    }

    public class VinApiResponse
    {
        public List<Result>? Results { get; set; }
    }

    public class Result
    {
        public string? Variable { get; set; }
        public string? Value { get; set; }
    }
}
