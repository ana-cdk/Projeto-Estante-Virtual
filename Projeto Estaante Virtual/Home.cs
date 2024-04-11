using Domain.Models;
using Persistence.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace Projeto_Estante_Virtual
{
    public partial class Home : Form
    {
        private LivroDAL _livroDAL = new LivroDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoEstante"].ConnectionString));

        private Livro _livroAtual = null;

        private Form? frmAtivo;

        private Guid usuarioSelecionado;

        private bool _carregando = true;

        public Home(Guid usuarioSelecionado)
        {
            InitializeComponent();
            this.usuarioSelecionado = usuarioSelecionado;
            InicializarHome();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelHome.Controls)
                ctrl.ForeColor = Color.Black;

            frmAtivo.ForeColor = Color.Gray;
        }

        private void InicializarHome()
        {
            DTLivro.DataSource = _livroDAL.ObterTodos(usuarioSelecionado);
            btRemover.Enabled = false;
            _livroAtual = null;
            DTLivro.ClearSelection();
     
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            InicializarHome();
            DTLivro.ClearSelection();
            _carregando = false;
            DTLivro.Columns[1].Visible = false;
            DTLivro.Columns[7].Visible = false;
        }

        private void btFavoritos_Click(object sender, EventArgs e)
        {
            ActiveButton(btFavoritos);
            FormShow(new Favoritos(usuarioSelecionado));
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AddLivro outroform = new AddLivro(usuarioSelecionado);
            outroform.ShowDialog();
            InicializarHome();
        }

        private void btLivros_Click(object sender, EventArgs e)
        {
            ActiveButton(btLivros);
            ActiveFormClose();
        }

        private void btAbandonados_Click(object sender, EventArgs e)
        {
            ActiveButton(btAbandonados);
            FormShow(new Abandonados(usuarioSelecionado));
        }

        private void btLidos_Click(object sender, EventArgs e)
        {
            ActiveButton(btLidos);
            FormShow(new Lidos(usuarioSelecionado));
        }

        private void btLendo_Click(object sender, EventArgs e)
        {
            ActiveButton(btLendo);
            FormShow(new Lendo(usuarioSelecionado));
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

            InicializarHome();
            MessageBox.Show("Registro removido", "Sucesso",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DTLivro_RowEnter(object sender, DataGridViewCellEventArgs e)
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

        private void btQueroLer_Click(object sender, EventArgs e)
        {
            ActiveButton(btLendo);
            FormShow(new QueroLer(usuarioSelecionado));
        }
    }



}
