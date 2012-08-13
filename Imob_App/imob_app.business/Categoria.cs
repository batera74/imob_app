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
    public class Categoria : IEntidade<dao.categoria>
    {
        private imobappEntities _ctx;
        
        public Categoria()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.categoria> SelecionarTodos()
        {
            return (from c in _ctx.categoria select c).ToList();
        }

        public dao.categoria Selecionar(int id)
        {
            return (from c in _ctx.categoria where c.id == id select c).FirstOrDefault();
        }


        public List<categoria> SelecionarExistentes()
        {
            return (from c in _ctx.imovel select c.categoria).Distinct().ToList();
        }
    }
}
