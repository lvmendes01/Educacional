using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using Lvmendes.Educacional.Comum.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Servico
{
    public class AlunoServico : IAlunoServico

    {

        private IAlunoRepositorio _repositorio;

        public AlunoServico(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(AlunoEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(AlunoEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<AlunoEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<AlunoEntidade> ObterFiltros(Expression<Func<AlunoEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<AlunoEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public AlunoEntidade Primeiro(Expression<Func<AlunoEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public AlunoEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
