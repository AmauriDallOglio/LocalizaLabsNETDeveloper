using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaLabsNETDeveloper.Desafios
{
    public class Comunicação_em_Piralândia
    {
        public void resultado()
        {
            string n = Console.ReadLine();

            char[] arr = n.ToCharArray();
            Array.Reverse(arr);

            string v = new string(arr);
            Console.WriteLine(v);
        }
    }
}
