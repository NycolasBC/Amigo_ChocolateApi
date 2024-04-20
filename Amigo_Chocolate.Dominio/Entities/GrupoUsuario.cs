using System.Net.NetworkInformation;

namespace Amigo_Chocolate.Dominio.Entities
{
    public class GrupoUsuario
    {
        public GrupoUsuario(int id_Grupo, int id_Usuario, int id_Status)
        {
            Id_Grupo = id_Grupo;
            Id_Usuario = id_Usuario;
            Id_Status = id_Status;
        }

        public int Id_Grupo { get; private set; }
        public int Id_Usuario { get; private set; }
        public int Id_Status { get; private set; }

        // Propriedade de navegação
        public Usuario Usuario { get; private set; }
        public Grupo Grupo { get; private set; }
    }
}
