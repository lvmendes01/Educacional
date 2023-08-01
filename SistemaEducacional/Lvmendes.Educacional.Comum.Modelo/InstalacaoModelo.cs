using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class InstalacaoModelo : IdentificadorModelo
    {
      
        public virtual EnderecoModelo Endereco { get; set; }
        public virtual string Email { get; set; }

        public virtual IList<TelefoneModelo> Telefones { get; set; } = new List<TelefoneModelo>();
        public virtual IList<CursoOfertadoModelo> Cursos { get; set; } = new List<CursoOfertadoModelo>();
        public InstalacaoEntidade Transformar(InstalacaoModelo objeto)
        {

            var entidade = new InstalacaoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
            };


            foreach (var item in objeto.Telefones)
            {
                entidade.Telefones.Add(new TelefoneEntidade
                {
                    DataCriacao = item.DataCriacao,
                    DDD = item.DDD,
                    Id = item.Id,
                    Numero = item.Numero,

                });
            }

         

            return entidade;
        }
        public InstalacaoModelo Transformar(InstalacaoEntidade objeto)
        {

            return new InstalacaoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
            };
        }
    }
}
