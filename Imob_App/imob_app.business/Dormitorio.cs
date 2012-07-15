using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;

namespace imob_app.business
{
    public class Dormitorio : IEntidade
    {
        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            List<dormitorio> consulta = (from a in ctx.dormitorio select a).ToList();
            return consulta;
        }
        
        public System.Collections.IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
