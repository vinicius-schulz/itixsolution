using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITIX.Persistence.Migrations;
using ITIX.ViewForm.Ninject;

namespace ITIX.ViewForm
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());


            var configuration = new Configuration();
            var migrator = new DbMigrator(configuration);
            //Rollback
            migrator.Update();

            

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(CompositionRoot.Resolve<Main>());
            //System.Windows.Forms.Application.Run(FormResolve.Resolve<Main>());
        }
    }
}
