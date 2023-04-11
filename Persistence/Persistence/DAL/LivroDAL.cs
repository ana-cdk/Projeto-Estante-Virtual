using System;
using System.Data.SqlClient;
using Domain.Models;
using Microsoft.SqlServer.Management.Smo;

namespace Persistence.Persistence.DAL
{
    public class LivroDAL
    {
        private SqlConnection _sqlConnection;
        private Guid usuarioSelecionado;
        public LivroDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        private void Adicionar(Livro livro)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into Tb_Livros(Titulo, Autor, Paginas, Status, Nota, Favorito, UsuarioID, LivroID)" +
                "values(@titulo, @autor, @paginas, @status, @nota, @favorito, @usuarioID, @livroID)";
           
            command.Parameters.AddWithValue("@titulo", livro.Titulo);
            command.Parameters.AddWithValue("@autor", livro.Autor);
            command.Parameters.AddWithValue("@paginas", livro.Paginas);
            command.Parameters.AddWithValue("@status", livro.Status);
            command.Parameters.AddWithValue("@nota", livro.Nota);
            command.Parameters.AddWithValue("@favorito", livro.Favorito);
            command.Parameters.AddWithValue("@usuarioID", usuarioSelecionado);
            command.Parameters.AddWithValue("@livroID", Guid.NewGuid());
            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Gravar(Livro livro, Guid usuarioSelecionado)
        {
            this.usuarioSelecionado = usuarioSelecionado;
            validacao(livro);
            if (livro.LivroID == null)
            {
                Adicionar(livro);

            }
        }

        private void validacao(Livro livro)
        {
            if (string.IsNullOrWhiteSpace(livro.Titulo))
                throw new Exception("O titulo não pode ficar em branco");
            if (string.IsNullOrWhiteSpace(livro.Autor))
                throw new Exception("O autor não pode ficar em branco");
            if (string.IsNullOrWhiteSpace(livro.Status))
                throw new Exception("Por favor, selecione o status de leitura");
        }

        public IReadOnlyCollection<Livro> ObterTodos(Guid usuarioSelecionado)
        {
            List<Livro> livros = new List<Livro>();
            var command = new SqlCommand(
                "select Titulo, Autor, Paginas, Status, Nota, Favorito, UsuarioID, LivroID " +
                "from Tb_Livros where UsuarioID = @usuarioSelecionado order by Titulo", _sqlConnection);
            command.Parameters.AddWithValue("@usuarioSelecionado", usuarioSelecionado);

            _sqlConnection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var livro = new Livro(
                        reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3),
                        reader.GetInt32(4), reader.GetString(5), usuarioSelecionado, livroID: reader.GetGuid(7)
                        );

                    livros.Add(livro);
                }
            }

            _sqlConnection.Close();

            return livros.AsReadOnly();
        }

        public IReadOnlyCollection<Livro> ObterPorStatus(Guid usuarioSelecionado, string status)
        {
            List<Livro> livros = new List<Livro>();
            var command = new SqlCommand(
                "select Titulo, Autor, Paginas, Status, Nota, Favorito, UsuarioID, LivroID " +
                "from Tb_Livros where UsuarioID = @usuarioSelecionado and Status = @status order by Titulo", _sqlConnection);
            command.Parameters.AddWithValue("@usuarioSelecionado", usuarioSelecionado);
            command.Parameters.AddWithValue("@status", status);

            _sqlConnection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var livro = new Livro(
                        reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3),
                        reader.GetInt32(4), reader.GetString(5), usuarioSelecionado, livroID: reader.GetGuid(7)
                        );

                    livros.Add(livro);
                }
            }

            _sqlConnection.Close();

            return livros.AsReadOnly();
        }
        public IReadOnlyCollection<Livro> ObterFav(Guid usuarioSelecionado)
        {
            List<Livro> livros = new List<Livro>();
            var command = new SqlCommand(
                "select Titulo, Autor, Paginas, Status, Nota, Favorito, UsuarioID, LivroID " +
                "from Tb_Livros where UsuarioID = @usuarioSelecionado and Favorito = 'Sim' order by Titulo", _sqlConnection);
            command.Parameters.AddWithValue("@usuarioSelecionado", usuarioSelecionado);

            _sqlConnection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var livro = new Livro(
                        reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3),
                        reader.GetInt32(4), reader.GetString(5), usuarioSelecionado, livroID: reader.GetGuid(7)
                        );

                    livros.Add(livro);
                }
            }

            _sqlConnection.Close();

            return livros.AsReadOnly();
        }
        public void Remover(Livro livro)
        {
            try
            {
                var command = new SqlCommand(
                       "delete from TB_Livros where LivroID = @livroID", _sqlConnection);
                command.Parameters.AddWithValue("@livroID", livro.LivroID);

                _sqlConnection.Open();
                var teste =  command.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
