using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDao : ILeilaoDao
    {
        AppDbContext _context;

        public LeilaoDao()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Leilao> BuscarTodos()
        {
            return _context.Leiloes
                            .Include(x => x.Categoria)
                            .ToList();
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(x => x.Id == id);
        }

        public void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Alterar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}
