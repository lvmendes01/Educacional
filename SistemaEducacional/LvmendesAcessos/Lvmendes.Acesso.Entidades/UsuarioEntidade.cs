using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Acesso.Entidades
{
    public class UsuarioEntidade: IdentificadorEntidade
    {
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual PerfilEntidade Perfil { get; set; }
    }
}
