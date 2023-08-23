using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas {
    public class Quadrado:Forma {
    
    public double Lado { get; set; }
    
        public override void CalcularArea() {

            this.Area = Math.Pow(Lado, 2);            
   }

   public override void CalcularPerimetro() {

            this.Perimetro = 4 * Lado;

        }
    }
}
