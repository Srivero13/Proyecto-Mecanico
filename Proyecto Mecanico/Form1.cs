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

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) ||
            string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de confirmar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form2 obj = new Form2(textBox3.Text);
            this.Hide();
            obj.FormClosed += (s, args) => this.Close();
            obj.Show();
        }
    }
}
