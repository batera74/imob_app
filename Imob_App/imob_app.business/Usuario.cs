using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using imob_app.business.Contratos;
using imob_app.dao;

namespace imob_app.business
{
    public class Usuario : IEntidade<dao.usuario>
    {
        private imobappEntities _ctx;

        public Usuario()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.usuario> SelecionarTodos()
        {
            return (from s in _ctx.usuario select s).ToList();
        }

        public dao.usuario Selecionar(int id_usuario)
        {
            return (from s in _ctx.usuario where s.id_usuario == id_usuario select s).FirstOrDefault();
        }

        public dao.usuario Selecionar(string id_facebook)
        {
            return (from s in _ctx.usuario where s.id_facebook == id_facebook select s).FirstOrDefault();
        }
    }
}
