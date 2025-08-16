using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenX_Interfaces
{
    public static class LogManager
    {
        public static List <string> Actividades = new List <string> ();

        public static void AgregarActividad(string evento)
        {
            string timestamp = DateTime.Now.ToString ("dd-MM-yyyy HH:mm:ss");
            Actividades.Add($"[{timestamp}] {evento}");
        }
    }
}
