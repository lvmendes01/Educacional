using Lvmendes.Educacional.Comum.Entidades;

namespace Lvmendes.Educacional.Comum.Modelo
{
    public class PessoaFisicaModelo : IdentificadorModelo
    {
        public virtual string Nome { get; set; }
        public virtual string NomeSocial { get; set; }
        public virtual string Cpf { get; set; }
        public virtual DateTime DataNascimento { get; set; }

        public virtual EstadoCivilEnum EstadoCivil { get; set; }
        public virtual EnderecoModelo Endereco { get; set; }
        public virtual SexoEnumerado Sexo { get; set; }

        public virtual string Email { get; set; }
        public virtual IList<TelefoneModelo> Telefones { get; set; } = new List<TelefoneModelo>();
        public PessoaFisicaEntidade Transformar(PessoaFisicaModelo objeto)
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
                Sexo = objeto.Sexo,

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
        public PessoaFisicaModelo Transformar(PessoaFisicaEntidade objeto)
        {
            var entidade = new ProfessorModelo
            {
                Id = objeto.Id,
                DataCriacao = objeto.DataCriacao,
                Cpf = objeto.Cpf,
                DataNascimento = objeto.DataNascimento,
                Email = objeto.Email,
                Endereco = Endereco.Transformar(objeto.Endereco),
                EstadoCivil = objeto.EstadoCivil,
                NomeSocial = objeto.NomeSocial,
                Sexo = objeto.Sexo,
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