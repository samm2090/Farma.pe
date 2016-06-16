using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farma.pe.models
{
    public class Persona
    {
        
        public int PER_ID { get; set; }
        public string NOM_PER { get; set; }
        public string APEP_PER { get; set; }
        public string APEM_PER { get; set; }
        public Nullable<System.DateTime> FNAC_PER { get; set; }

        public virtual Usuario USUARIO { get; set; }
    }
}
