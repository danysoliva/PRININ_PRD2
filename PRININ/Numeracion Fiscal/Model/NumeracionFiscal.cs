using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Numeracion_Fiscal.Model
{
  public  class NumeracionFiscal
    {
        public int ID { get; set; }
        public string CAI { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVence { get; set; }
        public string NumIni { get; set; }
        public string NumFin { get; set; }
        public string Estado { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool GenCorr { get; set; }
        public int Correlative { get; set; }
        public string Leyenda { get; set; }
        public string TypeDoc { get; set; }
    }
}
