using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class EstadoImovel : IEntidade<dao.estadoimovel>
    {
        private imobappEntities _ctx;

        public EstadoImovel()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.estadoimovel> SelecionarTodos()
        {
            return (from e in _ctx.estadoimovel select e).ToList(); 
        }

        public dao.estadoimovel Selecionar(int id)
        {
            return (from e in _ctx.estadoimovel where e.id == id select e).FirstOrDefault();
        }


        public List<estadoimovel> SelecionarExistentes()
        {
            throw new NotImplementedException();
        }
    }
}
