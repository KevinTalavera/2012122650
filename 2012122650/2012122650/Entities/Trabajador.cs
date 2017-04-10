using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Trabajador
    {
        string nombre;
        int codTrabajador;
        List<TipoTrabajador> tipoTra;

        

        public Trabajador (string nom, int codTra, string tipoTra)
        {
            nombre = nom;
            codTrabajador = codTra;
            this.tipoTra.Add(new TipoTrabajador(tipoTra));
        }
    }
}
