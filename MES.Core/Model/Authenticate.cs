using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Model
{
    public class Authenticate
    {
        [Key]
        public string Account { get; set; }
        public string? AccountName { get; set; }
        public string Password { get; set; }
        public string Privilege { get; set; }
        public string LastModifier { get; set; }
        public string LastModifyDate {  get; set; }
    }
}
