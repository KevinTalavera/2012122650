using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Ubigeo
    {
        List<Departamento> depa;
        List<Provincia> provin;
        List<Distrito> distri;

        public Ubigeo(string depa, string provin, string distri)
        {
            this.depa.Add(new Departamento(depa));
            this.provin.Add(new Provincia(provin));
            this.distri.Add(new Distrito(distri));
        }
    }
}
