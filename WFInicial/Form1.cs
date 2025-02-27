namespace WFInicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show(
                   "Ok", 
                   "Aprovado", 
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            else if (media < 5)
            {
                MessageBox.Show(
                    "Deu Ruim",
                    "Reprovado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show
                    ("Aten��o", "Voc� est� de recupera��o", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
