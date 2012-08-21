using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.dao;
using imob_app.business.Contratos;

namespace imob_app.business
{
    public class Servico : IEntidade<dao.servico>
    {
        private imobappEntities _ctx;

        public Servico()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.servico> SelecionarTodos()
        {
            return (from s in _ctx.servico select s).ToList();
        }

        public dao.servico Selecionar(int id)
        {
            return (from s in _ctx.servico where s.id == id select s).FirstOrDefault();
        }

        public dao.servico Selecionar(string descricao, imobappEntities _ctx)
        {
            return (from a in _ctx.servico where a.ds_item == descricao select a).FirstOrDefault();
        }
    }
}
