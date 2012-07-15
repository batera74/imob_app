using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;

namespace imob_app.business
{
    public class Municipio : IEntidadeLocalizacao
    {
        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            List<municipio> consulta = (from a in ctx.municipio select a).ToList();
            return consulta;
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable SelecionarPorReferencia(short id)
        {
            var ctx = new imobappEntities();
            List<municipio> consulta = (from a in ctx.municipio where a.estado.id_estado == id select a).ToList();
            return consulta;
        }
    }
}
