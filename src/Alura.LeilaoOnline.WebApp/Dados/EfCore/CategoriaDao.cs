using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class CategoriaDao : ICategoriaDao
    {
        AppDbContext _context;

        public CategoriaDao(AppDbContext context)
        {
            _context = context;
        }

        public Categoria BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
