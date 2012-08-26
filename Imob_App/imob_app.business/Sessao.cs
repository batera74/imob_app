using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imob_app.business
{
    public class Sessao
    {
        public dao.usuario usuarioDb;
        public IDictionary<string, object> usuarioFb;

        public Sessao(dao.usuario usuarioDb, IDictionary<string, object> usuarioFb)
        {
            this.usuarioDb = usuarioDb;
            this.usuarioFb = usuarioFb;
        }
    }
}
