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
    public class SimpleService : ISimpleService
    {
        private IModelSimple simp;
        #region methods
        public SimpleService(IModelSimple simp)
        {
            this.simp = simp;
           
        }
        public decimal CalculateInteres(double f, int n, double p)
        {
            return simp.CalculateInteres(f, n, p);
        }

        public int CalculatePeriodo(double f, double p, decimal i)
        {
            return simp.CalculatePeriodo(f, p, i);
        }

        public double CalculateVF(double p, int n, decimal i)
        {
            return simp.CalculateVF(p, n, i);
        }

        public double CalculateVP(double f, int n, decimal i)
        {

            return simp.CalculateVP(f, n, i);
        }

        public void Create(InteresSimple t)
        {
            simp.Create(t);
        }

        public bool Delete(InteresSimple t)
        {
            return simp.Delete(t);
        }

        public List<InteresSimple> GetAll()
        {
            return simp.GetAll();
        }

        public int Update(InteresSimple t)
        {
            return simp.Update(t);
        }
        #endregion
    }
}
