using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    
    public class InstituicaoModelo : PessoaJuridicaModelo
    {
        public virtual string Natureza { get; set; }
        public virtual IList<InstalacaoModelo> Filias { get; set; }


        public virtual string Email { get; set; }
        public virtual IList<TelefoneEntidade> Telefones { get; set; } = new List<TelefoneEntidade>();
        public InstituicaoEntidade Transformar(InstituicaoModelo objeto)
        {
            var entidade = new InstituicaoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                CNPJ = objeto.CNPJ,
                IE = objeto.IE,
                Nome = objeto.Nome,
                DataCriacaoEmpresa = objeto.DataCriacaoEmpresa,
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
        public InstituicaoModelo Transformar(InstituicaoEntidade objeto)
        {

            var entidade = new InstituicaoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                CNPJ = objeto.CNPJ,
                IE = objeto.IE,
                Nome = objeto.Nome,
                DataCriacaoEmpresa = objeto.DataCriacaoEmpresa,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco)
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
    }

}
