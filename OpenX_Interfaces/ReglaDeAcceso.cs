using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenX_Interfaces
{
    public class ReglaDeAcceso
    {
        public int Id { get; set; }
        public string UsuarioAsignado { get; set; }
        public string DispositivoAsignado { get; set; }
        public string Horario { get; set; }

    }
}
