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
        private ICidadeRepositorio _repositoriocidade;

        public ProfessorServico(IProfessorRepositorio repositorio, ICidadeRepositorio repositoriocidade)
        {
            _repositorio = repositorio;
            _repositoriocidade = repositoriocidade;
        }

        public string Adicionar(ProfessorEntidade entity)
        {

            if (entity.Endereco.Cidade.Id != 0)
                entity.Endereco.Cidade = _repositoriocidade.CarregarCidadePeloId(entity.Endereco.Cidade.Id);

            if (entity.Endereco.Estado.Id != 0)
                entity.Endereco.Estado = _repositoriocidade.CarregarEstadoPeloId(entity.Endereco.Estado.Id);



            return _repositorio.Adicionar(entity);
        }

        public string Atualizar(ProfessorEntidade entity)
        {
            if (entity.Endereco.Cidade.Id != 0)
                entity.Endereco.Cidade = _repositoriocidade.CarregarCidadePeloId(entity.Endereco.Cidade.Id);

            if (entity.Endereco.Estado.Id != 0)
                entity.Endereco.Estado = _repositoriocidade.CarregarEstadoPeloId(entity.Endereco.Estado.Id);

            return _repositorio.AtualizarProfessor(entity);
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

            if (includes)
            {
                String[] includesdados = new String[4] { "Endereco", "Endereco.Cidade", "Endereco.Estado", "Telefones" };

                return _repositorio.ObterTodos(include: includesdados);
            }
            return _repositorio.ObterTodos();

        }

        public ProfessorEntidade Primeiro(Expression<Func<ProfessorEntidade, bool>> predicate)
        {
            String[] includes = new String[4] { "Endereco", "Endereco.Cidade", "Endereco.Estado", "Telefones" };

            var professor = _repositorio.Primeiro(predicate, includes);

            return professor; 
        }

        public ProfessorEntidade Procurar(params object[] key)
        {
            return _repositorio.Procurar(key);
        }
    }
}
