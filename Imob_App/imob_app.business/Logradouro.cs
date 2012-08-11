using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Logradouro : IEntidade<dao.logradouro>
    {
        private imobappEntities _ctx;

        public Logradouro()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.logradouro> SelecionarTodos()
        {
            return (from l in _ctx.logradouro select l).ToList(); 
        }

        public dao.logradouro Selecionar(int id)
        {
            return (from l in _ctx.logradouro where l.id_logradouro == id select l).FirstOrDefault();
        }
    }
}
