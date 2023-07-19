namespace Lvmendes.Acesso.Entidades
{
    public class PerfilEntidade : IdentificadorEntidade
    {
        public virtual string NomePerfil { get; set; }
        public virtual List<PermissaoEntidade> Permissoes { get; set; }
    }
}