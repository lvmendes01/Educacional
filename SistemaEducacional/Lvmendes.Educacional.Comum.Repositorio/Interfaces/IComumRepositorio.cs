﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Repositorio.Interfaces
{
    public interface IComumRepositorio<T> where T : class
    {
        List<T> ObterTodos(string[] include = null);
        List<T> ObterFiltros(Expression<Func<T, bool>> predicate);
        T Procurar(params object[] key);
        T Primeiro(Expression<Func<T, bool>> predicate, params string[] include);
        string Adicionar(T entity);
        string Atualizar(T entity);
        string Deletar(Func<T, bool> predicate);
    }
}
