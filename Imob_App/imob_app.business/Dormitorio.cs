using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;
using imob_app.business.Contratos;

namespace imob_app.business
{
    public class Dormitorio : IEntidade<dao.dormitorio>
    {
        private imobappEntities _ctx;

        public Dormitorio()
        {
            _ctx = new imobappEntities();
        }

        public List<dormitorio> SelecionarTodos()
        {
            return (from d in _ctx.dormitorio select d).ToList();            
        }
        
        public dao.dormitorio Selecionar(int id)
        {
            return (from d in _ctx.dormitorio where d.id == id select d).FirstOrDefault();
        }
    }
}
