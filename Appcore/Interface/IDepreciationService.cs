using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Interface
{
    public interface IDepreciationService: Iservice<Depreciations>
    {
        public List<Depreciations> Depreciacion(double valor, double vr, int vida);
    }
}
