using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;

namespace imob_app.business
{
    public class Estado : IEntidadeLocalizacao
    {
        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            List<estado> consulta = (from a in ctx.estado select a).ToList();
            return consulta;
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable SelecionarPorReferencia(short id)
        {
            throw new NotImplementedException();
        }
    }
}
