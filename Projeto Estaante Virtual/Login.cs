using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_Estante_Virtual
{
    public partial class Login : Form
    {
        public static Guid usuarioSelecionado;

        SqlConnection _conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoEstante"].ConnectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void btLoginCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro outroform = new Cadastro();
            outroform.ShowDialog();
        }


        private void btLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((textboxUsername.Text != "") && (textboxSenha.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("Select UsuarioID, Usuario, Senha" +
                        " From TB_Usuarios" + " Where Usuario = @username and Senha = @senha", _conn);
                    comm.Parameters.Add("@username", SqlDbType.VarChar).Value = textboxUsername.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = textboxSenha.Text;

                    _conn.Open();

                    SqlDataReader reader = null;
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        usuarioSelecionado = reader.GetGuid(0);

                        Home outroform = new Home(usuarioSelecionado);
                        this.Visible = false;
                        outroform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretas", "Aviso de Segurança",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Todos os Campos são obrigatórios", "Aviso de Segurança",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
