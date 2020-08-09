using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultProdutoService : IProdutoService
    {
        ILeilaoDao _leilaoDao;
        //ICategoriaDao _categoriaDao; -> Criar Dao

        public DefaultProdutoService(ILeilaoDao leilaoDao)
        {
            throw new NotImplementedException();
        }

        public Categoria ConsultaCategoriaPorIdComLeiloesEmPregao(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaComInfoLeilao> ConsultaCategoriasComTotalDeLeiloesEmPregao()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo)
        {
            throw new NotImplementedException();
        }
    }
}
