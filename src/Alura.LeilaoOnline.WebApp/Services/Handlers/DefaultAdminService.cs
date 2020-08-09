using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        ILeilaoDao _leilaoDao;

        public DefaultAdminService(ILeilaoDao leilaoDao)
        {
            _leilaoDao = leilaoDao;
        }

        public void CadastrarLeilao(Leilao leilao)
        {
            _leilaoDao.Incluir(leilao);
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            throw new NotImplementedException();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            throw new NotImplementedException();
        }

        public void FinalizaPregaoDoLeilaoComId(Leilao leilao)
        {
            throw new NotImplementedException();
        }

        public void IniciaPregaoDoLeilaoComId(Leilao leilao)
        {
            throw new NotImplementedException();
        }

        public void ModificaLeilao(Leilao leilao)
        {
            throw new NotImplementedException();
        }

        public void RemoveLeilao(Leilao leilao)
        {
            throw new NotImplementedException();
        }
    }
}
