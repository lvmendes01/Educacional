﻿using Lvmendes.Acesso.Entidades;

namespace Lvmendes.Educacional.Comum.Servico.Interfaces
{
    public interface IUsuarioServico : IComumServico<UsuarioEntidade>
    {

        UsuarioEntidade Login(string login, string senha);
    }
}
