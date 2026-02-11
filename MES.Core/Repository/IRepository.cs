using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository
{
    public interface IRepository<T>
    {
        public static string ConnStr = Constant.CONNECTION_STRING;
        public List<T> GetList(T t);
        public List<T> GetListBy(T t, string propName);
        public List<T> GetListBy(T t, List<string> propName);
        public List<T> GetListLike(T t, string propName);
        public T GetUnique(T t);
        public int Delete(T t);

        public int Insert(T t);

        public int Update(T t);
    }
}
