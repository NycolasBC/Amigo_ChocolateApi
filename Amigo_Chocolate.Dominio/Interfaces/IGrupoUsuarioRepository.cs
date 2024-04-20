﻿using Amigo_Chocolate.Dominio.Entities;

namespace Amigo_Chocolate.Dominio.Interfaces
{
    public interface IGrupoUsuarioRepository
    {
        Task<GrupoUsuario> BuscarPorId(int id);
        Task Inserir(GrupoUsuario grupoUsuario);
        Task Atualizar(GrupoUsuario grupoUsuario);
        Task Excluir(GrupoUsuario grupoUsuario);
    }
}