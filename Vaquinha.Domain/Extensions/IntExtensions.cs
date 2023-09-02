using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaquinha.Domain.Extensions
{
    public static class IntExtensions
    {
        public static string ToDinheiroBrString(this int valor)
        {
            return valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}