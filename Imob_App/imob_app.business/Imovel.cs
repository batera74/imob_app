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
using System.Linq.Dynamic;

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

        public List<ImovelResultado> Pesquisar(int idEstado, int idMunicipio, int idBairro, int idDormitorio, int idCategoria,
                                                        decimal valorDe, decimal valorAte)
        {
            StringBuilder query = new StringBuilder();
            if (idBairro > 0)
                query.Append("it.bairro.id_bairro == " + idBairro);
            else if (idMunicipio > 0)
                query.Append("it.bairro.municipio.id_municipio == " + idMunicipio);
            else if (idEstado > 0)
                query.Append("it.bairro.municipio.estado.id_estado == " + idEstado);


            if (idDormitorio > 0)
                query.Append(VerificaQuery(query.ToString()) + "it.dormitorio.id == " + idDormitorio);
            if (idCategoria > 0)
                query.Append(VerificaQuery(query.ToString()) + "it.categoria.id == " + idCategoria);
            if (valorDe > 0)
                query.Append(VerificaQuery(query.ToString()) + "it.vl_imovel >= " + valorDe);
            if (valorAte > 0)
                query.Append(VerificaQuery(query.ToString()) + "it.vl_imovel <= " + valorAte);

            var imoveis = _ctx.imovel.Where(query.ToString());

            return (from imov in imoveis
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

        public string VerificaQuery(string query)
        {
            if (!query.Equals(String.Empty))
                return " And ";
            else
                return "";
        }

        public entidades.ImovelResultado SelecionarResultado(int id)
        {
            var query = (from imov in _ctx.imovel
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
                             });

            return query.FirstOrDefault();
        }

        public dao.imovel SelecionarImov(int id)
        {
            dao.imovel imovel = (from imov in _ctx.imovel
                                     .Include("categoria")
                                     .Include("bairro")
                                     .Include("categoria")
                                     .Include("dormitorio")
                                     .Include("estadoimovel")
                                     .Include("finalidade")
                                     .Include("posicaoimovel")
                                     .Include("usuario")
                                     .Include("imagem")
                                     .Include("acabamento")
                                     //.Include("armario")
                                     //.Include("intima")
                                     //.Include("lazer")
                                     //.Include("social")
                                     //.Include("servico")

                        where imov.id_imovel == id
                        select imov).FirstOrDefault();

            imovel.categoriaReference.Load();
            imovel.bairroReference.Load();
            imovel.bairro.municipioReference.Load();
            imovel.categoriaReference.Load();
            imovel.dormitorioReference.Load();
            imovel.estadoimovelReference.Load();
            imovel.finalidadeReference.Load();
            imovel.posicaoimovelReference.Load();
            imovel.usuarioReference.Load();

            return imovel;
        }

        public List<entidades.ImovelResultado> Selecionar(int idBairro, int idDormitorio, int idCategoria,
                                                          decimal valorDe, decimal valorAte)
        {
            return (from imov in _ctx.imovel
                    where imov.bairro.id_bairro == idBairro
                    && imov.dormitorio.id == idDormitorio
                    && imov.categoria.id == idCategoria
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


        public List<ImovelResultado> Selecionar(int id)
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
    }
}
