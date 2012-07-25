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
        //private EntityCollection<dao.imagem> imagens;

        public string Categoria { get; set; }
        public int Referencia { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public decimal? AreaUtil { get; set; }
        public decimal? AreaTotal { get; set; }
        public string EstadoImovel { get; set; }
        public decimal Valor { get; set; }
        public EntityCollection<imagem> Imagens { get; set; }
        //{
        //    get
        //    {
        //        imagem imagem = imagens.FirstOrDefault(i => i.ic_principal == true);
        //        this.IdFotoPrincipal = imagem != null ? imagem.id_imagem : 1;
        //        return imagens;                
        //    }
        //    set 
        //    {
        //        imagens = value;
        //        imagem imagem = imagens.FirstOrDefault(i => i.ic_principal == true);
        //        this.IdFotoPrincipal = imagem != null ? imagem.id_imagem : 1;                 
        //    }
        //}
        public int IdFotoPrincipal { get; set; }
    }
}
