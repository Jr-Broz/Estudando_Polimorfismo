using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas {
    public class Program {
        static void Main(string[] args) {
        
        Quadrado q = new Quadrado();

            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe o valor do lado do quadrado em metros.");

            q.Lado = Convert.ToInt32(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();

          Console.WriteLine($"a AREA do quadrado e {q.Area} m2 ");
          Console.WriteLine($"O perimetro do quadrado e {q.Perimetro} m2");
          
          Console.ReadKey();
        }
    }
}
