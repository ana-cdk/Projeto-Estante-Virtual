using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.Persistence.DAL
{
    public class UsuarioDAL
    {
        private SqlConnection _sqlConnection;
        
        public UsuarioDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
       public void Adicionar(Usuario usuario)
        {
            
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Usuarios(Usuario, Email, Senha, UsuarioID)" +
            "values(@usuario, @email, @senha, @usuarioID)";
            command.Parameters.AddWithValue("@usuario", usuario.Username);
            command.Parameters.AddWithValue("@email", usuario.Email);
            command.Parameters.AddWithValue("@senha", usuario.Senha);
            command.Parameters.AddWithValue("@usuarioID", Guid.NewGuid());
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
      
        public void Gravar(Usuario usuario)
        {
            validacao(usuario);
            if(usuario.UsuarioID == null)
            {
                Adicionar(usuario);
            }
        }

        private void validacao(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Username))
                throw new Exception("O username não pode ser vazio");
            if (string.IsNullOrWhiteSpace(usuario.Email))
                throw new Exception("O email não pode ser vazio");
            if (string.IsNullOrWhiteSpace(usuario.Senha))
                throw new Exception("A senha não pode ser vazia");
        }
    }
}
