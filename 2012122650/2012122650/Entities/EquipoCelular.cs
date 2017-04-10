using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class EquipoCelular
    {
        
        List<AdministradorEquipo> adEqui;
        List<AdministradorEquipo> codImei; 

        public EquipoCelular (int adEqui, int codImei )
        {
            this.adEqui.Add(new AdministradorEquipo(adEqui));
            this.codImei.Add(new AdministradorEquipo(codImei));
        }
    }
}
