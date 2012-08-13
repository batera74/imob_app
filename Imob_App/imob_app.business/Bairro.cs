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
    public class Bairro : IEntidadeLocalizacao<dao.bairro>
    {
        private imobappEntities _ctx;

        public Bairro()
        {
            _ctx = new imobappEntities();
        }

        public List<dao.bairro> SelecionarTodos()
        {
            return (from b in _ctx.bairro select b).ToList();            
        }

        public dao.bairro Selecionar(int id)
        {
            return (from b in _ctx.bairro where b.id_bairro == id select b).FirstOrDefault();
        }

        public List<dao.bairro> SelecionarPorReferencia(int idMunicipio)
        {
            return (from b in _ctx.bairro where b.municipio.id_municipio == idMunicipio select b).ToList();            
        }


        public List<bairro> SelecionarExistentes()
        {
            throw new NotImplementedException();
        }


        public List<bairro> SelecionarExistentesPorReferencia(int idMunicipio)
        {
            return (from b in _ctx.imovel where b.bairro.municipio.id_municipio == idMunicipio select b.bairro).Distinct().ToList();            
        }
    }
}
