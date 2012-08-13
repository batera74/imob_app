using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Padrao : IEntidade<dao.padrao>
    {
        private imobappEntities _ctx;

        public Padrao()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.padrao> SelecionarTodos()
        {
            return (from p in _ctx.padrao select p).ToList(); 
        }

        public dao.padrao Selecionar(int id)
        {
            return (from p in _ctx.padrao where p.id == id select p).FirstOrDefault();
        }


        public List<padrao> SelecionarExistentes()
        {
            throw new NotImplementedException();
        }
    }
}
