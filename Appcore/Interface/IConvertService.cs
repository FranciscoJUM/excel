using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Interface
{
    public interface IConvertService : Iservice<ConvercionDeTasas>
    {
        decimal ConvertNominalToPeriodicEfective(decimal i, int m);
        decimal ConvertPeriodicEfectiveToNominal(decimal i, int m);
        decimal ConvertNomialToEfective(decimal i, int m);
    }
}
