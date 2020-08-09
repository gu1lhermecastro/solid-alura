using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        IEnumerable<Categoria> ConsultaCategorias();

        IEnumerable<Leilao> ConsultaLeiloes();

        Leilao ConsultaLeilaoPorId(int id);

        void CadastrarLeilao(Leilao leilao);

        void ModificaLeilao(Leilao leilao);

        void RemoveLeilao(Leilao leilao);

        void IniciaPregaoDoLeilaoComId(Leilao leilao);

        void FinalizaPregaoDoLeilaoComId(Leilao leilao);
    }
}
