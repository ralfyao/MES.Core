using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public class CommonRepository<T> : AbstractRepository<T> where T : class
    {
        public override int Insert(T t)
        {
            throw new NotImplementedException();
        }

        public override int Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
