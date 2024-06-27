﻿namespace Amigo_Chocolate.Dominio.Entities
{
    public class Login
    {
        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public int IdLogin { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
    }
}
