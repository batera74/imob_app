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
        private imobappEntities _ctx;

        public Municipio()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.municipio> SelecionarTodos()
        {
            return (from a in _ctx.municipio select a).ToList();            
        }

        public dao.municipio Selecionar(int id)
        {
            return (from m in _ctx.municipio where m.id_municipio == id select m).FirstOrDefault();
        }

        public List<dao.municipio> SelecionarPorReferencia(int id)
        {
            return (from a in _ctx.municipio where a.estado.id_estado == id select a).ToList();            
        }

        public List<dao.municipio> SelecionarExistentesPorReferencia(int id)
        {
            return (from a in _ctx.imovel where a.bairro.municipio.estado.id_estado == id select a.bairro.municipio).Distinct().ToList();
        }        
    }
}
