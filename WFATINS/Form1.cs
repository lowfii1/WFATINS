namespace WFATINS
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

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txtValor1.Text;
            MessageBox.Show($"Você digitou : {texto}", "Viu?");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text != string.Empty && txtValor2.Text != string.Empty)
            {
                // cast - parse-Convert
                double valor1 = double.Parse(txtValor1.Text);
                double valor2 = double.Parse(txtValor2.Text);
                double lstresultado = 0;
                if (cmbOperacao.SelectedIndex == 0)
                    lstresultado = valor1 + valor2;
                else if (cmbOperacao.SelectedIndex == 1)
                    lstresultado = valor1 - valor2;
                else if (cmbOperacao.SelectedIndex == 2)
                    lstresultado = valor1 / valor2;
                else
                    lstresultado = valor1 * valor2;
                lstResultado.Items.Add($"{valor1} {cmbOperacao.SelectedItem.ToString().Substring(0, 1)} {valor2}={lstresultado}");
            }
            else
            {
                MessageBox.Show("Você precisa informa valores nas duas caixas!");
            }
        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValor2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("O usuário passou o mouse por sobre o controle");
        }

        private void btnCalcular_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("");
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

        }


        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var user = Environment.UserName;
            MessageBox.Show($"O usuário {user} fez um click duplo no controle sobre o controle");
        }
    }
}
