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
    public class Municipio : IEntidadeLocalizacao<dao.municipio>
    {
        public List<dao.municipio> SelecionarTodos()
        {
            var ctx = new imobappEntities();
            return (from a in ctx.municipio select a).ToList();
            
        }

        public List<dao.municipio> Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public List<dao.municipio> SelecionarPorReferencia(short id)
        {
            var ctx = new imobappEntities();
            return (from a in ctx.municipio where a.estado.id_estado == id select a).ToList();            
        }
    }
}
