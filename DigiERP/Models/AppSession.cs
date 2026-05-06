using MES.Core.Model;
using MES.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiERP.Models
{
    public static class AppSession
    {
        public static User User { get; set; }
        public static SqlConnection _conn { get; set; }
    }
}
