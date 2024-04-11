using Domain.Models;
using Persistence.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;


namespace Projeto_Estante_Virtual
{
    public partial class Lendo : Form
    {
        private Guid usuarioSelecionado;

        private LivroDAL _livroDAL = new LivroDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoEstante"].ConnectionString));

        private Livro _livroAtual = null;

        private string status = "Lendo";

        private bool _carregando = true;
        public Lendo(Guid usuarioSelecionado)
        {
            InitializeComponent();
            this.usuarioSelecionado = usuarioSelecionado;
        }
        private void InicializarLendo()
        {
            DTLivro.DataSource = _livroDAL.ObterPorStatus(usuarioSelecionado, status);
            btRemover.Enabled = false;
            _livroAtual = null;
            DTLivro.ClearSelection();
        }

        private void Lendo_Shown(object sender, EventArgs e)
        {
            InicializarLendo();
            DTLivro.ClearSelection();
            _carregando = false;
            DTLivro.Columns[1].Visible = false;
            DTLivro.Columns[7].Visible = false;
        }

       private void RegistrarLivroAtual(string titulo, string autor, int paginas, string status, int nota, string favorito,
       Guid? usuarioID = null, Guid? livroID = null)
        {
            _livroAtual = new Livro(titulo, autor, paginas, status, nota, favorito,
            usuarioID: usuarioID, livroID: livroID);
            btRemover.Enabled = true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (_livroAtual == null)
            {
                MessageBox.Show("É preciso selecionar um livro para remover", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Confirma remover" +
                $" {_livroAtual.Titulo}",
                "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }

            _livroDAL.Remover(_livroAtual);

            InicializarLendo();
            MessageBox.Show("Registro removido", "Sucesso",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DTLivro_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregando)
            {
                RegistrarLivroAtual(
                        DTLivro.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        DTLivro.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        Convert.ToInt32(DTLivro.Rows[e.RowIndex].Cells[3].Value.ToString()),
                        DTLivro.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        Convert.ToInt32(DTLivro.Rows[e.RowIndex].Cells[5].Value.ToString()),
                        DTLivro.Rows[e.RowIndex].Cells[6].Value.ToString(),
                        usuarioID: Guid.Parse(DTLivro.Rows[e.RowIndex].Cells[7].Value.ToString()),
                        livroID: Guid.Parse(DTLivro.Rows[e.RowIndex].Cells[1].Value.ToString())
                        );
            }
        }
    }
}
