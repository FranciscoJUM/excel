using Appcore.Interface;
using Appcore.Service;
using Autofac;
using Dominio.Interface;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proto1._0
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            //simple
            builder.RegisterType<SimpleRepository>().As<IModelSimple>();
            builder.RegisterType<SimpleService>().As<ISimpleService>();
            //compuesto
            builder.RegisterType<CompuestoRepository>().As<IModelCompuesto>();
            builder.RegisterType<CompuestoService>().As<ICompuestoService>();
            //Converter
            builder.RegisterType<ConvertRepository>().As<IModelConverticion>();
            builder.RegisterType<ConvertService>().As<IConvertService>();
            //Depreciation
            builder.RegisterType<DepreciationRepository>().As<IModelDepreciation>();
            builder.RegisterType<DepreciationService>().As<IDepreciationService>();


            var container = builder.Build();
            Application.Run(new Inicio( container.Resolve<ISimpleService>(), container.Resolve<ICompuestoService>(), container.Resolve<IConvertService>(), container.Resolve<IDepreciationService>())); 
          //  Application.Run(new Inicio((container.Resolve<ISimpleService>(), container.Resolve<ICompuestoService>(), container.Resolve<IConvertService>())));



        }
    }
}
