using System;
using System.Xml;

namespace Amigo_Chocolate.Dominio.Entities
{
    public class RecuperaSenha
    {
        public RecuperaSenha(int idUsuario, DateTime dataSolicitacao)
        {
            IdUsuario = idUsuario;
            DataSolicitacao = dataSolicitacao;
        }

        public int IdRecuperaSenha { get; private set; }
        public int IdUsuario { get; private set; }
        public DateTime DataSolicitacao { get; private set; }

        // Propriedade de navegação
        public Usuario Usuario { get; private set; }
    }
}
