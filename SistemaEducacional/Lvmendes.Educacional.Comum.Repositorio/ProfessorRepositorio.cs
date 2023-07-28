using Lvmendes.Educacional.Comum.Entidades;
using Lvmendes.Educacional.Comum.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Repositorio
{
    public class ProfessorRepositorio : ComumRepositorio<ProfessorEntidade>, IProfessorRepositorio
    {
        private ComumBDContext context;
        public ProfessorRepositorio(ComumBDContext _context) : base(_context)
        {
            _context.Professores
                .Include(s => s.Telefones)
                .Include(s => s.Endereco)
                .Include(s => s.Endereco.Cidade)
                .Include(s => s.Endereco.Estado);
            context = _context;
        }

        public string AtualizarProfessor(ProfessorEntidade entidade)
        {
            try
            {
                Context.Entry(entidade.Endereco).State = EntityState.Modified;
                foreach (var item in entidade.Telefones)
                {
                    Context.Entry(item).State = EntityState.Modified;
                }
               
                Context.Entry(entidade).State = EntityState.Modified;
                Commit();
                return "Atualizar com sucesso!!";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
