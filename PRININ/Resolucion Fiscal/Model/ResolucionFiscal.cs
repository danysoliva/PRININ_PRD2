using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Resolucion_Fiscal.Model
{
    public class ResolucionFiscal
    {
        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
