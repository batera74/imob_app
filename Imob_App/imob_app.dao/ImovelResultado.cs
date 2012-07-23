using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imob_app.dao
{
    public class ImovelResultado
    {
        public string Categoria { get; set; }
        public int Referencia { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public decimal? AreaUtil { get; set; }
        public decimal? AreaTotal { get; set; }
        public string EstadoImovel { get; set; }
        public decimal Valor { get; set; }
        public int IdFotoPrincipal { get; set; }
    }
}
