using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigo_Chocolate.Servico.ViewModels.Convite
{
    public class ConviteViewModel
    {
        public int IdConvite { get; set; }
        public int IdGrupo { get; set; }
        public string NomeGrupo { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailConvidado { get; set; }
        public string Descricao { get; set; }
        public int Id_Status { get; set; }
    }
}
