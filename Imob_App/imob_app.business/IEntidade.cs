using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace imob_app.business
{
    public interface IEntidade
    {
        IEnumerable SelecionarTodos();
        IEnumerable Selecionar(int id);        
    }
}
