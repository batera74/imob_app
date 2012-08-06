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
        public List<dormitorio> SelecionarTodos()
        {
            var ctx = new imobappEntities();
            return (from a in ctx.dormitorio select a).ToList();            
        }
        
        public List<dao.dormitorio> Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
