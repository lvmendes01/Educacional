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
    public class HorariosServico : IHorariosServico
    {

        private IHorariosRepositorio _repositorio;

        public HorariosServico(IHorariosRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public string Adicionar(HorarioEntidade entity)
        {
            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(HorarioEntidade entity)
        {
            return _repositorio.Atualizar(entity);
        }

        public string Deletar(Func<HorarioEntidade, bool> predicate)
        {
            return _repositorio.Deletar(predicate);
        }

        public List<HorarioEntidade> ObterFiltros(Expression<Func<HorarioEntidade, bool>> predicate)
        {
            return _repositorio.ObterFiltros(predicate);
        }

        public List<HorarioEntidade> ObterTodos(bool includes = false)
        {
            return _repositorio.ObterTodos();
        }

        public HorarioEntidade Primeiro(Expression<Func<HorarioEntidade, bool>> predicate)
        {
            return _repositorio.Primeiro(predicate);
        }

        public HorarioEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
