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
using System.Data.Objects.DataClasses;

namespace imob_app.business
{
    public class Imovel : IExistente<entidades.ImovelResultado>
    {
        private imobappEntities _ctx;

        public Imovel()
        {
            //Inicializa o contexto do Modelo
            _ctx = new imobappEntities();
        }

        //Seleciona todos os Imóveis cadastrados no banco
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
                                  Padrao = imov.padrao.ds_item,
                                  Imagens = imov.imagem
                              };
            return imoveis.OrderByDescending(o => o.Referencia).ToList();

        }

        //Pesquisa os Imóveis correspondentes aos termos da pesquisados
        public List<entidades.ImovelResultado> Pesquisar(int idEstado, int idMunicipio, int idBairro, int idDormitorio, int idCategoria,
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

            if (query.Length == 0)
                query.Append("1 == 1");

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
                        Padrao = imov.padrao.ds_item,
                        Imagens = imov.imagem
                    }).ToList();

        }

        //Seleciona imóveis de acordo com o Id do Usuário
        public List<entidades.ImovelResultado> SelecionarPorUsuario(int idUsuario)
        {
            var query = (from imov in _ctx.imovel
                         where imov.usuario.id_usuario == idUsuario
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
                             Padrao = imov.padrao.ds_item,
                             Imagens = imov.imagem
                         });

            return query.ToList();
        }

        //Seleciona imóvel pelo Id
        public dao.imovel SelecionarImovel(int id)
        {
            dao.imovel imovel = (from imov in _ctx.imovel
                                     .Include("categoria")
                                     .Include("bairro")
                                     .Include("bairro.municipio")
                                     .Include("bairro.municipio.estado")
                                     .Include("categoria")
                                     .Include("dormitorio")
                                     .Include("estadoimovel")
                                     .Include("finalidade")
                                     .Include("posicaoimovel")
                                     .Include("usuario")
                                     .Include("imagem")
                                     .Include("armario")
                                     .Include("acabamento")
                                     .Include("intima")
                                     .Include("lazer")
                                     .Include("social")
                                     .Include("servico")
                                     .Include("padrao")
                                     .Include("garagem")
                                     .Include("logradouro")

                                 where imov.id_imovel == id
                                 select imov).FirstOrDefault();


            return imovel;
        }

        //Seleciona imóvel pelo Id
        public dao.imovel SelecionarImovel(int id, imobappEntities _ctx)
        {
            dao.imovel imovel = (from imov in _ctx.imovel
                                     .Include("categoria")
                                     .Include("bairro")
                                     .Include("bairro.municipio")
                                     .Include("bairro.municipio.estado")
                                     .Include("categoria")
                                     .Include("dormitorio")
                                     .Include("estadoimovel")
                                     .Include("finalidade")
                                     .Include("posicaoimovel")
                                     .Include("usuario")
                                     .Include("imagem")
                                     .Include("armario")
                                     .Include("acabamento")
                                     .Include("intima")
                                     .Include("lazer")
                                     .Include("social")
                                     .Include("servico")
                                     .Include("padrao")
                                     .Include("garagem")
                                     .Include("logradouro")

                                 where imov.id_imovel == id
                                 select imov).FirstOrDefault();


            return imovel;
        }

        //Remove o imóvel da base de dados de acordo com o Id
        public bool Excluir(int id)
        {
            try
            {
                var imovel = from i in _ctx.imovel where i.id_imovel == id select i;
                _ctx.DeleteObject(imovel);
                _ctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Verifica se é necessário a concatenação do operador AND na query
        public string VerificaQuery(string query)
        {
            if (!query.Equals(String.Empty))
                return " And ";
            else
                return "";
        }

        //Seleciona imóvel pelo Id
        public entidades.ImovelResultado Selecionar(int id)
        {
            var query = from imov in _ctx.imovel
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
                             Padrao = imov.padrao.ds_item,
                             Imagens = imov.imagem
                         };

            return query.FirstOrDefault();
        }

        //Seleciona imóveis existentes
        public List<ImovelResultado> SelecionarExistentes()
        {
            throw new NotImplementedException();
        }
                
        //Adiciona imagem ao imovel
        public bool AdicionarImagem(dao.imagem img, int idImovel)
        {
            try
            {
                //Imóvel que será salvo as imagens
                dao.imovel imov;

                //Instância classe de negócio do Imóvel
                business.Imovel imovBiz = new business.Imovel();

                //imov = _ctx.imovel.FirstOrDefault(i => i.id_imovel == idImovel);
                imov = this.SelecionarImovel(idImovel);

                imov.imagem.Add(img);
                _ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //Seleciona Acabamentos
        public List<dao.acabamento> SelecionarAcabamento()
        {
            return (from i in _ctx.imovel select i.acabamento).First().ToList();
        }

        //Seleciona Armarios
        public List<dao.armario> SelecionarArmario()
        {
            return (from i in _ctx.imovel select i.armario).First().ToList();
        }

        //Seleciona Lazer
        public List<dao.lazer> SelecionarLazer()
        {
            return (from i in _ctx.imovel select i.lazer).First().ToList();
        }

        //Seleciona Serviço
        public List<dao.servico> SelecionarServico()
        {
            return (from i in _ctx.imovel select i.servico).First().ToList();
        }

        //Seleciona Íntima
        public List<dao.intima> SelecionarIntima()
        {
            return (from i in _ctx.imovel select i.intima).First().ToList();
        }

        //Seleciona Social
        public List<dao.social> SelecionarSocial()
        {
            return (from i in _ctx.imovel select i.social).First().ToList();
        }

    }
}
