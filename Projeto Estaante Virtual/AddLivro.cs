using Domain.Models;
using Persistence.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;


namespace Projeto_Estante_Virtual
{
    public partial class AddLivro : Form
    {
        private LivroDAL _dal = new LivroDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoEstante"].ConnectionString));
        private Livro _livroAtual = null;

        private int qtdEstrelas;
        private string ehFav;
        private Guid usuarioSelecionado;

        public AddLivro(Guid usuarioSelecionado)
        {
            InitializeComponent();
            this.usuarioSelecionado = usuarioSelecionado;
            qtdEstrelas = 0;
            ehFav = "Não"; 
            estrela1.Visible = false;
            estrela2.Visible = false;
            estrela3.Visible = false;
            estrela4.Visible = false;
            estrela5.Visible = false;
            btFav.Visible = false;
        }

    
        private void AddLivro_Load(object sender, EventArgs e)
        {
            addlivroStatusComboBox.Items.Add("Abandonado");
            addlivroStatusComboBox.Items.Add("Lendo");
            addlivroStatusComboBox.Items.Add("Lido");
            addlivroStatusComboBox.Items.Add("Quero Ler");
        }

        private void estrela1_Click(object sender, EventArgs e)
        {
            estrela1.Image = Properties.Resources.estrelapintada; 
            estrela2.Image = Properties.Resources.estrela;
            estrela3.Image = Properties.Resources.estrela;
            estrela4.Image = Properties.Resources.estrela;
            estrela5.Image = Properties.Resources.estrela;
            qtdEstrelas = 1;

        }

        private void estrela2_Click(object sender, EventArgs e)
        {
            estrela1.Image = Properties.Resources.estrelapintada;
            estrela2.Image = Properties.Resources.estrelapintada;
            estrela3.Image = Properties.Resources.estrela;
            estrela4.Image = Properties.Resources.estrela;
            estrela5.Image = Properties.Resources.estrela;
            qtdEstrelas = 2;
        }

        private void estrela3_Click(object sender, EventArgs e)
        {
            estrela1.Image = Properties.Resources.estrelapintada;
            estrela2.Image = Properties.Resources.estrelapintada;
            estrela3.Image = Properties.Resources.estrelapintada;
            estrela4.Image = Properties.Resources.estrela;
            estrela5.Image = Properties.Resources.estrela;
            qtdEstrelas = 3;

        }

        private void estrela4_Click(object sender, EventArgs e)
        {
            estrela1.Image = Properties.Resources.estrelapintada;
            estrela2.Image = Properties.Resources.estrelapintada;
            estrela3.Image = Properties.Resources.estrelapintada;
            estrela4.Image = Properties.Resources.estrelapintada;
            estrela5.Image = Properties.Resources.estrela;
            qtdEstrelas = 4;
        }

        private void estrela5_Click(object sender, EventArgs e)
        {
            estrela1.Image = Properties.Resources.estrelapintada;
            estrela2.Image = Properties.Resources.estrelapintada;
            estrela3.Image = Properties.Resources.estrelapintada;
            estrela4.Image = Properties.Resources.estrelapintada;
            estrela5.Image = Properties.Resources.estrelapintada;
            qtdEstrelas = 5;
        }

        private void btFav_Click(object sender, EventArgs e)
        {
            btFav.Image = Properties.Resources.coracaopintado;
            ehFav = "Sim";
        }

        private void addlivroStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(addlivroStatusComboBox.SelectedItem) == "Lido")
            {
                estrela1.Visible = true;
                estrela2.Visible = true;
                estrela3.Visible = true;
                estrela4.Visible = true;
                estrela5.Visible = true;
                btFav.Visible = true;
            }
            else
            {
                estrela1.Visible = false;
                estrela2.Visible = false;
                estrela3.Visible = false;
                estrela4.Visible = false;
                estrela5.Visible = false;
                btFav.Visible = false;
            }
        }

        private void btAddNovoLivro_Click(object sender, EventArgs e)
        {
            Livro livro;
            try
            {
                livro = new Livro(addlivroTituloTextBox.Text, addlivroAutorTextBox.Text,
                    Convert.ToInt32(addlivroQtdPagsTextBox.Text), addlivroStatusComboBox.Text, qtdEstrelas, ehFav, usuarioSelecionado,
                    livroID: _livroAtual?.LivroID ?? null);

                _dal.Gravar(livro, usuarioSelecionado);

                MessageBox.Show("Livro adicionado!!"
                , "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
