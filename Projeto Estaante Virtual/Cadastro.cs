using Persistence.Persistence.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Domain.Models;

namespace Projeto_Estante_Virtual
{
    public partial class Cadastro : Form
    {
        private UsuarioDAL _dal = new UsuarioDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoEstante"].ConnectionString));
        private Usuario _usuarioAtual = null;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            try
            {
                usuario = new Usuario(cadastroUsernameTextBox.Text, cadastroEmailTextBox.Text,
                    cadastroSenhaTextBox.Text, usuarioID: _usuarioAtual?.UsuarioID ?? null);
                
                _dal.Gravar(usuario);

                MessageBox.Show("Conta criada!!" +
                    "Faça seu login", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Visible = false;
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
