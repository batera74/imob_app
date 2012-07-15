using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;

namespace imob_app.business
{
    public class Bairro : IEntidadeLocalizacao
    {
        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            List<bairro> consulta = (from a in ctx.bairro select a).ToList();
            return consulta;
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable SelecionarPorReferencia(short id)
        {
            var ctx = new imobappEntities();
            List<bairro> consulta = (from a in ctx.bairro where a.municipio.id_municipio == id select a).ToList();
            return consulta;
        }
    }
}
