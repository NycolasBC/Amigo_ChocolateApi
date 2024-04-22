using Amigo_Chocolate.Dados.EntityFramework;
using Amigo_Chocolate.Dominio.Entities;
using Amigo_Chocolate.Dominio.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Amigo_Chocolate.Dados.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        #region - Atributos e Construtores

        private readonly Contexto _contexto;
        private readonly IMapper _mapper;

        public LoginRepository(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        #endregion


        public Task Atualizar(Login login)
        {
            throw new NotImplementedException();
        }

        public async Task<Login> BuscarPorId(int id)
        {
            try
            {
                var login = await _contexto.Login.Where(c => c.IdLogin == id).FirstOrDefaultAsync();

                return login;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar o login: {ex.Message}");
            }
        }

        public async Task Excluir(Login login)
        {
            try
            {
                _contexto.Login.Remove(login);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir o login: {ex.Message}");
            }
        }

        public async Task Inserir(Login login)
        {
            try
            {
                await _contexto.Login.AddAsync(login);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir o login: {ex.Message}");
            }
        }

        public async Task<Login> Autenticar(string email, string senha)
        {
            var login = await _contexto.Login.Where(filtro =>
                        filtro.Email == email && filtro.Senha == senha).FirstOrDefaultAsync();

            return _mapper.Map<Login>(login);
        }
    }
}
