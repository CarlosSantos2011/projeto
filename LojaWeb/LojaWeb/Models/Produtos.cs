using System.Collections.Generic;
using System.Linq;
using WebLoja2.Context;

namespace WebLoja2.Models
{
    public class Produtos
    {
        public int Id { get; internal set; }

        public string Modelo { get; internal set; }

        public string Nome { get;  internal set; }        

        public double Valor { get; set; }

        public int TempoGarantia { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public string Categoria { get; set; }

        
    }
}

    


