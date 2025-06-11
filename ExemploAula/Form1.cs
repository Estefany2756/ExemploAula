namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text== "admin" && txtsenha.Text== "123456")
            {
                MessageBox.Show("Login realizado com sucesso");
                txtusuario.Clear();
                txtsenha.Clear();
                txtusuario.Focus();
                Hide();
                frmvalido val = new frmvalido();
                val.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }
    }
}
