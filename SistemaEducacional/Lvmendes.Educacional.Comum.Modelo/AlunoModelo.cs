using Lvmendes.Educacional.Comum.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class AlunoModelo : PessoaFisicaModelo
    {
        public virtual ResponsavelModelo ResponsavelFinanceiro { get; set; }
        public virtual TipoIngressoEnum TipoIngresso { get; set; }
        public AlunoEntidade Transformar(AlunoModelo objeto)
        {

            var entidade = new AlunoEntidade
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Cpf = objeto.Cpf,
                Nome = objeto.Nome,
                DataNascimento = objeto.DataNascimento,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
                EstadoCivil = objeto.EstadoCivil,
                NomeSocial = objeto.NomeSocial,
                TipoIngresso = objeto.TipoIngresso,
                Sexo =objeto.Sexo,
                ResponsavelFinanceiro = ResponsavelFinanceiro.Transformar(objeto.ResponsavelFinanceiro),
                
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
        public AlunoModelo Transformar(AlunoEntidade objeto)
        {

            var entidade = new AlunoModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Cpf = objeto.Cpf,
                DataNascimento = objeto.DataNascimento,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
                EstadoCivil = objeto.EstadoCivil,
                TipoIngresso = objeto.TipoIngresso,
                NomeSocial = objeto.NomeSocial,
                Sexo = objeto.Sexo,
                ResponsavelFinanceiro = ResponsavelFinanceiro.Transformar(objeto.ResponsavelFinanceiro),
            };


            foreach (var item in objeto.Telefones)
            {
                entidade.Telefones.Add(new TelefoneModelo
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
