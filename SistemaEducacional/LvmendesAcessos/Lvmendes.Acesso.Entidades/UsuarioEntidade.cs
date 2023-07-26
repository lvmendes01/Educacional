using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Acesso.Entidades
{
    public class UsuarioEntidade: IdentificadorEntidade
    {
        public virtual string Login { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Senha { get; set; }
        [ForeignKey("PerfilId")]
        public virtual Int64 PerfilId { get; set; }
        private PerfilEntidade Perfil { get; set; }
    }
   
}
