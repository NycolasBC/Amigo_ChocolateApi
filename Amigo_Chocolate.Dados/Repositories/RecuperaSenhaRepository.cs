using Amigo_Chocolate.Dados.EntityFramework;
using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;

namespace Amigo_Chocolate.Dados.Repositories
{
    public class RecuperaSenhaRepository : IRecuperaSenhaRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public RecuperaSenhaRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        public Task Atualizar(RecuperaSenha recuperaSenha)
        {
            throw new NotImplementedException();
        }

        public Task<RecuperaSenha> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(RecuperaSenha recuperaSenha)
        {
            throw new NotImplementedException();
        }
    }
}
