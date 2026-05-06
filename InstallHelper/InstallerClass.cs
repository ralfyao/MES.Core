using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Install;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InstallHelper
{
    public class InstallerClass : Installer
    {
        public override void Install(IDictionary stateSaver)
        {
            try
            {
                base.Install(stateSaver);

                string server = Context.Parameters["DB_SERVER"]??"";
                string db = Context.Parameters["DB_NAME"] ?? "";
                string user = Context.Parameters["DB_USER"] ?? "";
                string pwd = Context.Parameters["DB_PWD"] ?? "";

                string connStr = $"Server={server};Database={db};User Id={user};Password={pwd};";

                string configPath = Path.Combine(Context.Parameters["targetdir"], "DigiERP.exe.config");

                var config = ConfigurationManager.OpenExeConfiguration(configPath);
                config.ConnectionStrings.ConnectionStrings["MyDb"].ConnectionString = connStr;
                config.Save();
                // 你的邏輯
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\install_error.txt", ex.ToString());
                throw;
            }
        }
    }
}
