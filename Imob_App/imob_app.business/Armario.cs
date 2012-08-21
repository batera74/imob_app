using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Armario : IEntidade<dao.armario>
    {
        private imobappEntities _ctx;

        public Armario()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.armario> SelecionarTodos()
        {
            return (from a in _ctx.armario select a).ToList();
        }

        public dao.armario Selecionar(int id)
        {
            return (from a in _ctx.armario where a.id == id select a).FirstOrDefault();
        }

        public dao.armario Selecionar(string descricao, imobappEntities _ctx)
        {
            return (from a in _ctx.armario where a.ds_item == descricao select a).FirstOrDefault();
        }
    }
}
