using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaLabsNETDeveloper.Desafios
{
    public class Coordenadas_de_um_Ponto
    {
        public void resultado()
        {
            string[] coordenadas = Console.ReadLine().Split(" ");

            double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) Console.WriteLine("Origem");

            if (x == 0.0 && y != 0.0) Console.WriteLine("Eixo Y");

            if (x != 0.0 && y == 0.0) Console.WriteLine("Eixo X");

            if (x > 0.0 && y > 0.0) Console.WriteLine("Q1");

            if (x < 0.0 && y > 0.0) Console.WriteLine("Q2");

            if (x < 0.0 && y < 0.0) Console.WriteLine("Q3");

            if (x > 0.0 && y < 0.0) Console.WriteLine("Q4");
        }
    }
}
