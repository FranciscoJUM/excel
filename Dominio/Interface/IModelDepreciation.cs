using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public  interface IModelDepreciation: IModel<Depreciations>
    {

        public List<Depreciations> Depreciacion(double valor, double vr, int vida);
        //{
        //    double depreciacion = (valor - vr) /vida;
        //    return Enumerable.Repeat<double>(depreciacion, vida).ToList();
        //}
    }
}
