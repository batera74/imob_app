using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Lazer : IEntidade<dao.lazer>
    {
        private imobappEntities _ctx;

        public Lazer()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.lazer> SelecionarTodos()
        {
            return (from l in _ctx.lazer select l).ToList();
        }

        public dao.lazer Selecionar(int id)
        {
            return (from l in _ctx.lazer where l.id == id select l).FirstOrDefault();
        }

        public dao.lazer Selecionar(string descricao, imobappEntities _ctx)
        {
            return (from a in _ctx.lazer where a.ds_item == descricao select a).FirstOrDefault();
        }
    }
}
