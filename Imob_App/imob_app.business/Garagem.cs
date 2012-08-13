using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Garagem : IEntidade<dao.garagem>
    {
        private imobappEntities _ctx;

        public Garagem()
        {
            _ctx = new imobappEntities();
        }

        public List<garagem> SelecionarTodos()
        {
            return (from g in _ctx.garagem select g).ToList(); 
        }

        public garagem Selecionar(int id)
        {
            return (from g in _ctx.garagem where g.id == id select g).FirstOrDefault();
        }


        public List<garagem> SelecionarExistentes()
        {
            throw new NotImplementedException();
        }
    }
}
