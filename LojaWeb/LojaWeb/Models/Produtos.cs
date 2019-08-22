using System.Collections.Generic;
using System.Linq;
using WebLoja2.Context;

namespace WebLoja2.Models
{
    public class Produtos
    {
        public int Id { get;  set; }

        public string Modelo { get;  set; }

        public string Nome { get;   set; }        

        public double Valor { get; set; }

        public int TempoGarantia { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public string Categoria { get; set; }

        
    }
}

    


