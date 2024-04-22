using System.Net.NetworkInformation;

namespace Amigo_Chocolate.Dominio.Entities
{
    public class GrupoUsuario
    {
        public GrupoUsuario(int idGrupo, int idUsuario, int id_Status)
        {
            IdGrupo = idGrupo;
            IdUsuario = idUsuario;
            Id_Status = id_Status;
        }

        public int IdGrupoUsuario { get; private set; }
        public int IdGrupo { get; private set; }
        public int IdUsuario { get; private set; }
        public int Id_Status { get; private set; }

        // Propriedade de navegação
        public Usuario Usuario { get; private set; }
        public Grupo Grupo { get; private set; }
    }
}
