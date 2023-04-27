namespace Login_Windows_Forms
{
    using System.Threading;

    public partial class Forms_login : Form
    {
        public Forms_login()
        {
            InitializeComponent();
        }

        public void FecharProgram()
        {
            this.Close();
            Application.Exit();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // fecha o programa
            FecharProgram();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            // criando excecao
            try
            {
                // variavel local para salvar o user
                string user = txtb_inserir_user.Text;

                // verificacao de user e password
                if (txtb_inserir_user.Text.Equals("Admin") && txtb_inserir_senha.Text.Equals("admin1234"))
                {
                    // abre um novo menu
                    var menu = new MenuRestrito();
                    menu.Show();
                    this.Visible = false;
                    MessageBox.Show("Bem vindo(a) de volta " + user);

                    // pausando programa por 1,2 segundos
                    Thread.Sleep(1200);

                    // fechando programa
                    FecharProgram();

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.",
                                    "Desculpe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtb_inserir_user.Focus();
                    txtb_inserir_senha.Text = "";
                    txtb_inserir_user.Text = "";
                }
            }
            // excecao propriamente dita
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}