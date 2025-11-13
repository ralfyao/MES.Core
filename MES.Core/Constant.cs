using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core
{
    public class Constant
    {
        public static string CONNECTION_STRING = GetConnectionString();

        public static string GetConnectionString()
        {
            string retStr = string.Empty;
            try
            {
                using (var reader = File.OpenText(@".\settings.conf"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.IndexOf("CONNECTION_STRING") != -1)
                        {
                            retStr = line.Split(':')[1];
                        }
                    }
                }
            }
            catch { }
            return retStr;
        }

        public static string PrivilegeName { get; set; } = "PrivilegeName";
        public static string MenuID { get; set; } = "MenuID";
    }
}
