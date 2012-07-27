using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using imob_app.dao;
using imob_app.entidades;
using imob_app.business.Contratos;
using System.Data.Objects;

namespace imob_app.business
{
    public class Imovel : IEntidade<entidades.ImovelResultado>
    {
        private imobappEntities _ctx;

        public Imovel()
        {
            _ctx = new imobappEntities();
        }

        public List<entidades.ImovelResultado> SelecionarTodos()
        {
            var imoveis = from imov in _ctx.imovel
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
            return imoveis.OrderByDescending(o => o.Referencia).ToList();

        }

        public List<entidades.ImovelResultado> Selecionar(int id)
        {
            return (from imov in _ctx.imovel
                    where imov.id_imovel == id
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
                        }).ToList();
        }

        public List<entidades.ImovelResultado> Selecionar(dao.estado estado)
        {
            return (from imov in _ctx.imovel
                    where imov.bairro.municipio.estado.id_estado == estado.id_estado
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
                    }).ToList();
        }

        public List<entidades.ImovelResultado> Selecionar(dao.municipio municipio)
        {
            return (from imov in _ctx.imovel
                    where imov.bairro.municipio.id_municipio == municipio.id_municipio
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
                    }).ToList();
        }

        public List<entidades.ImovelResultado> Selecionar(dao.bairro bairro)
        {
            return (from imov in _ctx.imovel
                    where imov.bairro.id_bairro == bairro.id_bairro
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
                    }).ToList();
        }

        public List<entidades.ImovelResultado> Selecionar(dao.dormitorio dormitorio)
        {
            return (from imov in _ctx.imovel
                    where imov.dormitorio.id == dormitorio.id
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
                    }).ToList();
        }

        public List<entidades.ImovelResultado> Selecionar(dao.categoria categoria)
        {
            return (from imov in _ctx.imovel
                    where imov.categoria.id == categoria.id
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
                    }).ToList();
        }

        public List<entidades.ImovelResultado> Selecionar(decimal valorDe, decimal valorAte)
        {
            return (from imov in _ctx.imovel
                    where imov.vl_imovel > valorDe && imov.vl_imovel < valorAte
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
                    }).ToList();
        }

        public List<entidades.ImovelResultado> Selecionar(dao.bairro bairro, dao.dormitorio dormitorio, dao.categoria categoria)
        {
            return (from imov in _ctx.imovel
                    where imov.bairro.id_bairro == bairro.id_bairro
                    && imov.dormitorio.id == dormitorio.id
                    && imov.categoria.id == categoria.id
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
                    }).ToList();
        }        

        public List<entidades.ImovelResultado> Selecionar(dao.bairro bairro, dao.dormitorio dormitorio, dao.categoria categoria,
                                                          decimal valorDe, decimal valorAte)
        {
            return (from imov in _ctx.imovel
                    where imov.bairro.id_bairro == bairro.id_bairro
                    && imov.dormitorio.id == dormitorio.id
                    && imov.categoria.id == categoria.id
                    && imov.vl_imovel > valorDe
                    && imov.vl_imovel < valorAte
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
                    }).ToList();
        }
    }
}
