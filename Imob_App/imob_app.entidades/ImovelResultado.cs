using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using imob_app.dao;

namespace imob_app.entidades
{
    public class ImovelResultado
    {
        public int Referencia { get; set; }
        public string Categoria { get; set; }
        public int? Dormitorio { get; set; }
        public int? Suite { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public decimal? AreaUtil { get; set; }
        public decimal? AreaTotal { get; set; }
        public string EstadoImovel { get; set; }
        public decimal Valor { get; set; }
        public string Padrao { get; set; }
        public EntityCollection<imagem> Imagens { get; set; }
        
        public ImovelResultado()
        {
        }

        public ImovelResultado(dao.imovel imov)
        {            
            Referencia = imov.id_imovel;
            Categoria = imov.categoria.ds_item;
            Dormitorio = imov.dormitorio.ds_item;
            Suite = imov.qt_suite;
            Bairro = imov.bairro.nm_bairro;
            Municipio = imov.bairro.municipio.nm_municipio;
            Estado = imov.bairro.municipio.estado.cd_estado;
            AreaTotal = imov.vl_area_total;
            AreaUtil = imov.vl_area_util;
            EstadoImovel = imov.estadoimovel.ds_item;
            Valor = imov.vl_imovel;
            Padrao = imov.padrao.ds_item;
            Imagens = imov.imagem;
        }

        public ImovelResultado Converter(dao.imovel imovel)
        {
            return new ImovelResultado(imovel);
        }
    }
}
