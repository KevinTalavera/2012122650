using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AdministradorEquipo
    {
        int stockEquipo;
        int codIMEI;

        public AdministradorEquipo(int stockEqui, int codImei)
        {
            stockEquipo = stockEqui;
            codIMEI = codImei;
        }
    }
}
