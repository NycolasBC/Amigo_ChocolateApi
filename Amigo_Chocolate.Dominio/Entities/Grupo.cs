using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Net.NetworkInformation;

namespace Amigo_Chocolate.Dominio.Entities
{
    public class Grupo
    {
        public Grupo(string? imagem, string nome, int qtdUsuario, decimal valor, DateOnly dataRevelacao, string? descricao, int id_Status)
        {
            Imagem = imagem;
            Nome = nome;
            QtdUsuario = qtdUsuario;
            Valor = valor;
            DataRevelacao = dataRevelacao;
            Descricao = descricao;
            Id_Status = id_Status;
        }

        public Grupo(int idGrupo, string? imagem, string nome, int qtdUsuario, decimal valor, DateOnly dataRevelacao, string? descricao, int id_Status)
        {
            IdGrupo = idGrupo;
            Imagem = imagem;
            Nome = nome;
            QtdUsuario = qtdUsuario;
            Valor = valor;
            DataRevelacao = dataRevelacao;
            Descricao = descricao;
            Id_Status = id_Status;
        }

        public int IdGrupo { get; private set; }
        public string? Imagem { get; private set; }
        public string Nome { get; private set; }
        public int QtdUsuario { get; private set; }
        public decimal Valor { get; private set; }
        public DateOnly DataRevelacao { get; private set; }
        public string? Descricao { get; private set; }
        public int Id_Status { get; private set; }
    }
}
