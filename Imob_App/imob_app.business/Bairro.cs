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
    public class Bairro : IEntidadeLocalizacao<dao.bairro>
    {
        public List<dao.bairro> SelecionarTodos()
        {
            var ctx = new imobappEntities();
            return (from a in ctx.bairro select a).ToList();
            
        }

        public List<dao.bairro> Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public List<dao.bairro> SelecionarPorReferencia(short id)
        {
            var ctx = new imobappEntities();
            return (from a in ctx.bairro where a.municipio.id_municipio == id select a).ToList();            
        }
    }
}
