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

        public void Alterar(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public Categoria BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(Categoria obj)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Categoria obj)
        {
            throw new NotImplementedException();
        }
    }
}
