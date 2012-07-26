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
    public class Estado : IEntidadeLocalizacao<dao.estado>
    {
        public List<dao.estado> SelecionarTodos()
        {
            var ctx = new imobappEntities();
            return (from a in ctx.estado select a).ToList();            
        }

        public List<dao.estado> Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public List<dao.estado> SelecionarPorReferencia(short id)
        {
            throw new NotImplementedException();
        }
    }
}
