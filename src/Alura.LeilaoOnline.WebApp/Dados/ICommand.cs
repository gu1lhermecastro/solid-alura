using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICommand<T>
    {
        IEnumerable<T> BuscarTodos();

        T BuscarPorId(int id);
    }
}
