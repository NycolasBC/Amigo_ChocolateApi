using Amigo_Chocolate.Dados.EntityFramework;
using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;

namespace Amigo_Chocolate.Dados.Repositories
{
    public class SorteioRepository : ISorteioRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;

        public SorteioRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        #endregion

        public Task Atualizar(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }

        public Task<Sorteio> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sorteio> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }
    }
}
