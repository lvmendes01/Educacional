using System.Linq.Expressions;

namespace Lvmendes.Educacional.Comum.Servico.Interfaces
{
    public interface IComumServico<T> where T : class
    {
        List<T> ObterTodos(bool includes = false);
        List<T> ObterFiltros(Expression<Func<T, bool>> predicate);
        T Procurar(params object[] key);
        T Primeiro(Expression<Func<T, bool>> predicate);
        string Adicionar(T entity);
        string Atualizar(T entity);
        string Deletar(Func<T, bool> predicate);
    }
}
