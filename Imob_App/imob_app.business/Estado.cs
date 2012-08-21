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
    public class Estado : IExistente<dao.estado>
    {
        private imobappEntities _ctx;

        public Estado()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.estado> SelecionarTodos()
        {
           return (from e in _ctx.estado select e).ToList();
        }

        public dao.estado Selecionar(int id)
        {
            return (from e in _ctx.estado where e.id_estado == id select e).FirstOrDefault();
        }

        public List<dao.estado> SelecionarExistentes()
        {
            return (from e in _ctx.imovel select e.bairro.municipio.estado).Distinct().ToList();
        }        
    }
}
