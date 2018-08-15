using System;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.Entity;
using ITIX.EntityFramework.EntityFramework;
using System.Data.Entity.Migrations;
using ITIX.EntityFramework.Migrations;

namespace ITIX.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var configuration = new Configuration();
            var migrator = new DbMigrator(configuration);
            //Rollback
            migrator.Update();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            System.Windows.Forms.Application.Run(new MainScreen());
        }
    }
}
