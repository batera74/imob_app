using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Intima : IEntidade<dao.intima>
    {
        private imobappEntities _ctx;

        public Intima()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.intima> SelecionarTodos()
        {
            return (from i in _ctx.intima select i).ToList();
        }

        public dao.intima Selecionar(int id)
        {
            return (from i in _ctx.intima where i.id == id select i).FirstOrDefault();
        }

        public dao.intima Selecionar(string descricao, imobappEntities _ctx)
        {
            return (from a in _ctx.intima where a.ds_item == descricao select a).FirstOrDefault();
        }
    }
}
