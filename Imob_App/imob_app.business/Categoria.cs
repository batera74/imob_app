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
    public class Categoria : IEntidade<dao.categoria>
    {
        public List<dao.categoria> SelecionarTodos()
        {
            var ctx = new imobappEntities();
            return (from a in ctx.categoria select a).ToList();
        }

        public List<dao.categoria> Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
