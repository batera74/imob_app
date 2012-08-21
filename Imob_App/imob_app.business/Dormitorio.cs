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
    public class Dormitorio : IExistente<dao.dormitorio>
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

        public dao.dormitorio Selecionar(int id, imobappEntities _ctx)
        {
            return (from d in _ctx.dormitorio where d.id == id select d).FirstOrDefault();
        }

        public List<dormitorio> SelecionarExistentes()
        {
            return (from c in _ctx.imovel select c.dormitorio).Distinct().ToList();
        }
    }
}
