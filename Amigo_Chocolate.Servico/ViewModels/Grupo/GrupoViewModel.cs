namespace Amigo_Chocolate.Servico.ViewModels.Grupo
{
    public class GrupoViewModel
    {
        public int IdGrupo { get; set; }
        public string? Imagem { get; set; }
        public string Nome { get; set; }
        public int QtdUsuario { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataRevelacao { get; set; }
        public string? Descricao { get; set; }
        public int Id_Status { get; set; }
    }
}
