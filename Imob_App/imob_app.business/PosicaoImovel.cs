using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.dao;
using imob_app.business.Contratos;

namespace imob_app.business
{
    public class PosicaoImovel : IEntidade<dao.posicaoimovel>
    {
        private imobappEntities _ctx;

        public PosicaoImovel()
        {
            _ctx = new imobappEntities();
        }

        public List<posicaoimovel> SelecionarTodos()
        {
            return (from p in _ctx.posicaoimovel select p).ToList(); 
        }

        public posicaoimovel Selecionar(int id)
        {
            return (from p in _ctx.posicaoimovel where p.id == id select p).FirstOrDefault();
        }

        public posicaoimovel Selecionar(int id, imobappEntities _ctx)
        {
            return (from p in _ctx.posicaoimovel where p.id == id select p).FirstOrDefault();
        }
    }
}
