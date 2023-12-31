using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas {
    public abstract class Forma {

    public string Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        public string Descricao() {

         return "Sou a classe abstrata forma";
        }
    }
}
