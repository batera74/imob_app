using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;

namespace imob_app.business
{
    public class Estado : IEntidade
    {
        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            var consulta = from a in ctx.estado select new { a.id_estado, a.cd_estado };
            return consulta;
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
