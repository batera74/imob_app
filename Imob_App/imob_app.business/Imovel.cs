using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using imob_app.dao;
using imob_app.entidades;
using imob_app.business.Contratos;

namespace imob_app.business
{
    public class Imovel : IEntidade
    {

        public IEnumerable SelecionarTodos()
        {
            var ctx = new imobappEntities();
            var teste = from imov in ctx.imovel
                        select new entidades.ImovelResultado()
                        {
                            Referencia = imov.id_imovel,
                            Categoria = imov.categoria.ds_item,                            
                            Dormitorio = imov.dormitorio.ds_item,
                            Suite = imov.qt_suite,
                            Bairro = imov.bairro.nm_bairro,
                            Municipio = imov.bairro.municipio.nm_municipio,
                            Estado = imov.bairro.municipio.estado.cd_estado,
                            AreaTotal = imov.vl_area_total,
                            AreaUtil = imov.vl_area_util,
                            EstadoImovel = imov.estadoimovel.ds_item,
                            Valor = imov.vl_imovel,
                            Imagens = imov.imagem
                        };

            return teste.OrderByDescending(o => o.Referencia).ToList();
        }

        public IEnumerable Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public void PreencherIdFotoPrincipal(List<entidades.ImovelResultado> imoveis)
        {
            foreach (ImovelResultado item in imoveis)
            {
                dao.imagem img = item.Imagens.FirstOrDefault(p => p.ic_principal == true);
                //item.IdFotoPrincipal = img != null ? img.id_imagem : 1;
            }
        }

    }
}
