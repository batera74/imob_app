using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Social : IEntidade<dao.social>
    {
        private imobappEntities _ctx;

        public Social()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.social> SelecionarTodos()
        {
            return (from s in _ctx.social select s).ToList();
        }

        public dao.social Selecionar(int id)
        {
            return (from s in _ctx.social where s.id == id select s).FirstOrDefault();
        }

        public dao.social Selecionar(string descricao, imobappEntities _ctx)
        {
            return (from a in _ctx.social where a.ds_item == descricao select a).FirstOrDefault();
        }
    }
}
