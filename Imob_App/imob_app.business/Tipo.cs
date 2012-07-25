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
    public class Tipo : IEntidade
    {
        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            List<categoria> consulta = (from a in ctx.categoria select a).ToList();
            return consulta;
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
