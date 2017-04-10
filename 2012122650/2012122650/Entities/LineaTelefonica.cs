using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class LineaTelefonica
    {
        List<AdministradorLinea> admiLinea;
        List<TipoLinea> tipoLi;

        public LineaTelefonica(int admiLinea, string tipoLi)
        {
            this.admiLinea.Add(new AdministradorLinea(admiLinea));
            this.tipoLi.Add(new TipoLinea(tipoLi));
        }
    }
}
