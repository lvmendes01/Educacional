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
    public class ProfessorServico : IProfessorServico
    {

        private IProfessorRepositorio _repositorio;

        public ProfessorServico(IProfessorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(ProfessorEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(ProfessorEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<ProfessorEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<ProfessorEntidade> ObterFiltros(Expression<Func<ProfessorEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<ProfessorEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos(includes);
        }

        public ProfessorEntidade Primeiro(Expression<Func<ProfessorEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public ProfessorEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
