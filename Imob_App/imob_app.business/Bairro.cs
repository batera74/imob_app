using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;

namespace imob_app.business
{
    public class Bairro : IEntidade
    {
        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            var consulta = from a in ctx.bairro select new { a.id_bairro, a.nm_bairro };
            return consulta;
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
