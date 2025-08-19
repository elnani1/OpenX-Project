using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenX_Interfaces
{
    public class Actividad
    {
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public Actividad(string descripcion)
        {
            Descripcion = descripcion;
            FechaHora = DateTime.Now;
        }
        public override string ToString()
        {
            return $"[{FechaHora:dd-MM-yyyy HH:mm:ss}] {Descripcion}";
        }
    }
}
