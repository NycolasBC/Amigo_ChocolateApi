namespace Amigo_Chocolate.Dominio.Entities
{
    public class Sorteio
    {
        public Sorteio(int id_Sorteio, int id_Usuario, int id_Sorteado)
        {
            Id_Sorteio = id_Sorteio;
            Id_Usuario = id_Usuario;
            Id_Sorteado = id_Sorteado;
        }

        public int Id_Sorteio { get; private set; }
        public int Id_Usuario { get; private set; }
        public int Id_Sorteado { get; private set; }

        // Propriedade de navegação
        public Usuario Usuario { get; private set; }
    }
}
