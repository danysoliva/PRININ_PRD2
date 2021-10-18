using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Mantenimiento.Rubros.Model
{
    public class Capitulo
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public int RubroID { get; set; }
        public string Rubro { get; set; }
        public string Descripcion { get; set; }
    }
}
