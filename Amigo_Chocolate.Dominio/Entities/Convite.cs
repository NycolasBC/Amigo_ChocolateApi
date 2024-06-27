using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Chocolate.Dominio.Entities
{
    public class Convite
    {
        public Convite(int idConvite, string descricao, int id_Status)
        {
            IdConvite = idConvite;
            Descricao = descricao;
            Id_Status = id_Status;
        }

        public Convite(int idGrupo, string nomeGrupo, string nomeUsuario, string emailConvidado, string descricao, int id_Status)
        {
            IdGrupo = idGrupo;
            NomeGrupo = nomeGrupo;
            NomeUsuario = nomeUsuario;
            EmailConvidado = emailConvidado;
            Descricao = descricao;
            Id_Status = id_Status;
        }

        public Convite(int idConvite, int idGrupo, string nomeGrupo, string nomeUsuario, string emailConvidado, string descricao, int id_Status)
        {
            IdConvite = idConvite;
            IdGrupo = idGrupo;
            NomeGrupo = nomeGrupo;
            NomeUsuario = nomeUsuario;
            EmailConvidado = emailConvidado;
            Descricao = descricao;
            Id_Status = id_Status;
        }

        public int IdConvite { get; private set; }
        public int IdGrupo { get; private set; }
        public string NomeGrupo { get; private set; }
        public string NomeUsuario { get; private set; }
        public string EmailConvidado { get; private set; }
        public string Descricao { get; private set; }
        public int Id_Status { get; private set; }

        // Propriedade de navegação
        public Grupo Grupo { get; private set; }
    }
}
