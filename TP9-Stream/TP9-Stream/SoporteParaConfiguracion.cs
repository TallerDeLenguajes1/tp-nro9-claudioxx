using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    static public class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create("Configuracion.dat")))
            {
                bw.Write(@"..\Release");
            }
        }

        public static string LeerConfiguracion()
        {
            string path;
            using (BinaryReader br = new BinaryReader(File.Open("Configuracion.dat", FileMode.Open)))
            {
                path = br.ReadString();
            }
            return path;
        }
    }
}
