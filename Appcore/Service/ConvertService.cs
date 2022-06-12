using Appcore.Interface;
using Dominio.Entities;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Service
{
    public class ConvertService : IConvertService
    {

        private IModelConverticion comp;
        public ConvertService(IModelConverticion comp)
        {
            this.comp = comp;
        }
        public decimal ConvertNomialToEfective(decimal i, int m)
        {
            return comp.ConvertNomialToEfective(i, m);
        }

        public decimal ConvertNominalToPeriodicEfective(decimal i, int m)
        {
            return comp.ConvertNominalToPeriodicEfective(i, m);
        }

        public decimal ConvertPeriodicEfectiveToNominal(decimal i, int m)
        {
            return comp.ConvertPeriodicEfectiveToNominal(i,m);
        }

        public void Create(ConvercionDeTasas t)
        {
            comp.Create(t);
        }

        public bool Delete(ConvercionDeTasas t)
        {
            return comp.Delete(t);
        }

        public List<ConvercionDeTasas> GetAll()
        {
            return comp.GetAll();
        }

        public int Update(ConvercionDeTasas t)
        {
            return comp.Update(t);
        }
    }
}
