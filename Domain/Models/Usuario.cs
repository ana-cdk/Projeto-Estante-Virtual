using System;


namespace Domain.Models
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Guid? UsuarioID { get; set; }

        public Usuario(string username, string email, string senha, Guid? usuarioID = null)
        {
            Username = username;
            Email = email;
            Senha = senha;
            UsuarioID = usuarioID;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Usuario)) return false;

            if ((obj as Usuario).UsuarioID.Equals(UsuarioID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (UsuarioID == null ? 1 : UsuarioID.GetHashCode());
        }
    }
}
