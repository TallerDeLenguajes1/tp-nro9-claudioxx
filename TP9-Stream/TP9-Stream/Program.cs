using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace TP9_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion();
            SoporteParaConfiguracion.LeerConfiguracion();
        }
    }
}
