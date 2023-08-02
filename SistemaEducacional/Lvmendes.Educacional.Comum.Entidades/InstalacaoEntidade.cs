using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Entidades
{
    public class InstalacaoEntidade : IdentificadorEntidade
    {
        public virtual EnderecoEntidade Endereco { get; set; }
        public virtual string Email { get; set; }
        [NotMapped]
        public virtual InstituicaoEntidade Instituicao { get; set; }
        public virtual Int64 InstituicaoEntidadeId { get; set; }

        public virtual IList<TelefoneEntidade> Telefones { get; set; } = new List<TelefoneEntidade>();
        public virtual IList<CursoOfertadoEntidade> Cursos { get; set; } = new List<CursoOfertadoEntidade>();

    }
}
