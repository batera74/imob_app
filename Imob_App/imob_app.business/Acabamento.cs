using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.dao;
using imob_app.business.Contratos;

namespace imob_app.business
{
    public class Acabamento : IEntidade<dao.acabamento>
    {
        private imobappEntities _ctx;

        public Acabamento()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.acabamento> SelecionarTodos()
        {
            return (from a in _ctx.acabamento select a).ToList();
        }

        public dao.acabamento Selecionar(int id)
        {
            return (from a in _ctx.acabamento where a.id == id select a).FirstOrDefault();
        }

        public dao.acabamento Selecionar(string descricao, imobappEntities _ctx)
        {
            return (from a in _ctx.acabamento where a.ds_item == descricao select a).FirstOrDefault();
        }
    }
}
