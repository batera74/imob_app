using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using imob_app.dao;
using System.Data;

namespace imob_app.business
{
    public class Imovel : IEntidade
    {

        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            /*
            var imobs = from x in ctx.imovel                        
                        join i in (from i2 in ctx.imagem where i2.ic_principal == true select i2) 
                        on x.id_imovel equals i.imovel.id_imovel 
                        where i.ic_principal == true*/
            var teste = from c in ctx.imovel
                        join i in ctx.imagem on c.id_imovel equals i.imovel.id_imovel into j1
                        from j2 in j1.DefaultIfEmpty()
                     select new ImovelResultado()
                     {
                         Categoria = j2.imovel.categoria.ds_item,
                         Referencia = j2.imovel.id_imovel,
                         Bairro = j2.imovel.bairro.nm_bairro,
                         Municipio = j2.imovel.bairro.municipio.nm_municipio,
                         Estado = j2.imovel.bairro.municipio.estado.cd_estado,
                         AreaTotal = j2.imovel.vl_area_total,
                         AreaUtil = j2.imovel.vl_area_util,
                         EstadoImovel = j2.imovel.estadoimovel.ds_item,
                         Valor = j2.imovel.vl_imovel,
                         IdFotoPrincipal = j2.id_imagem
                     };

            

//            return imobs.ToList();
            return teste.ToList();
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }


    }
}
