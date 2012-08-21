using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imob_app.business.Contratos
{
    public interface IExistente<T> : IEntidade<T>
    {
        List<T> SelecionarExistentes();
    }
}
