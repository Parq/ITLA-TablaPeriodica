using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TablaPeriodica.Models
{
    public class Elementos
    {
        public string Simbolo { get; set; }
        public string Categoria { get; set; }
        public int Numero { get; set; }

        public Elementos(string Simbolo, string Categoria, int Numero)
        {
            this.Simbolo = Simbolo;
            this.Categoria = Categoria;
            this.Numero = Numero;
        }
    }
}
