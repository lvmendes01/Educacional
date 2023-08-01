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
    public class DisciplinaCursadaServico : IDisciplinaCursadaServico
    {

        private IDisciplinaCursadaRepositorio _repositorio;

        public DisciplinaCursadaServico(IDisciplinaCursadaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(DisciplinaCursadaEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(DisciplinaCursadaEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<DisciplinaCursadaEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<DisciplinaCursadaEntidade> ObterFiltros(Expression<Func<DisciplinaCursadaEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<DisciplinaCursadaEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public DisciplinaCursadaEntidade Primeiro(Expression<Func<DisciplinaCursadaEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public DisciplinaCursadaEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
