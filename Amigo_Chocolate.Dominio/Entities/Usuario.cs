namespace Amigo_Chocolate.Dominio.Entities
{
    public class Usuario
    {
        public Usuario(int idUsuario, string? foto, string nome, string email, string senha, int id_Status)
        {
            IdUsuario = idUsuario;
            Foto = foto;
            Nome = nome;
            Email = email;
            Senha = senha;
            Id_Status = id_Status;
        }

        public Usuario(string? foto, string nome, string email, string senha, int id_Status)
        {
            Foto = foto;
            Nome = nome;
            Email = email;
            Senha = senha;
            Id_Status = id_Status;
        }

        public int IdUsuario { get; private set; }
        public string? Foto { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public int Id_Status { get; private set; }
    }
}
