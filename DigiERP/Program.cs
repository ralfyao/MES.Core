using MES.Core;

namespace DigiERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FileInfo connFile = new FileInfo(@".\settings.conf");
            if (!connFile.Exists )
            {
                FrmSetConf frmSetConf = new FrmSetConf();
                frmSetConf.ShowDialog();
                return;
            }
            Constant.CONNECTION_STRING = Constant.GetConnectionString();
            Application.Run(new FrmShow());
        }
    }
}