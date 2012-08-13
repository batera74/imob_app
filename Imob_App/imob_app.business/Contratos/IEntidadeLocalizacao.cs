﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using imob_app.dao;
using System.Collections;

namespace imob_app.business.Contratos
{
    public interface IEntidadeLocalizacao<T> : IEntidade<T>
    {
        List<T> SelecionarPorReferencia(int id);
        List<T> SelecionarExistentesPorReferencia(int id);
    }
}
