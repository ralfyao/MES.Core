using Dapper;
using log4net;
using log4net.Core;
using log4net.Repository.Hierarchy;
using MES.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MES.Core.Repository.Impl
{
    public abstract class AbstractRepository<T> : IRepository<T>
    {
        private static ILog logger = LogManager.GetLogger(typeof(AbstractRepository<T>));
        protected string theId;
        public int Delete(T t)
        {
            int delCnt = 0;
            var keyInfo = GetKeyPropertyAndValue(t);
            try
            {
                string sql = $@"DELETE FROM {typeof(T).Name} WHERE  {keyInfo.Value.property.Name}='{keyInfo.Value.value}'";

                using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                {
                    conn.Open();
                    delCnt = conn.Execute(sql);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return delCnt;
        }

        public List<T> GetList(T t)
        {
            List<T> prodList = new List<T>();
            try
            {
                using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM {typeof(T).Name} WHERE 1=1 ";
                    if (t != null)
                    {
                        sql += $" AND {theId} like @{theId} + '%'";
                    }
                    var parameters = new DynamicParameters(t);
                    var result = conn.Query<T>(sql, parameters);
                    prodList.AddRange(result);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return prodList;
        }

        public List<T> GetListBy(T t, string propName)
        {
            List<T> list = new List<T>();
            try
            {
                string sql = $@"SELECT * FROM {typeof(T).Name} WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} = @{propName}";
                        list = conn.Query<T>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<T>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<T> GetListBy(T t, List<string> propName)
        {
            List<T> list = new List<T>();
            try
            {
                string sql = $@"SELECT * FROM {typeof(T).Name} WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        propName.ForEach(x => {
                            if (!string.IsNullOrEmpty(x))
                                sql += $" AND {x} = @{x}";
                        });
                        list = conn.Query<T>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<T>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }
        public List<T> GetListBy(T t, List<string> propName, string fields = "")
        {
            List<T> list = new List<T>();
            try
            {
                string sql = $@"SELECT {(string.IsNullOrEmpty(fields) ? "*" : fields)} FROM Product WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        propName.ForEach(x => {
                            if (!string.IsNullOrEmpty(x))
                                sql += $" AND {x} = @{x}";
                        });
                        list = conn.Query<T>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<T>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<T> GetListBy(T t, string propName, string fields = "")
        {
            List<T> list = new List<T>();
            try
            {
                string sql = $@"SELECT {(string.IsNullOrEmpty(fields) ? "*" : fields)} FROM {t.GetType().Name} WHERE 1=1";
                if (t != null)
                {
                    sql += $" AND {propName} = @{propName}";
                }
                var parameters = new DynamicParameters(t);
                using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                {
                    conn.Open();
                    var result = conn.Query<T>(sql, parameters);
                    list = result.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public List<T> GetListLike(T t, string propName)
        {
            List<T> list = new List<T>();
            try
            {
                string sql = $@"SELECT * FROM {typeof(T).Name} WHERE 1=1";
                if (t != null)
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        var parameters = new DynamicParameters(t);
                        sql += $" AND {propName} like @{propName}+'%'";
                        list = conn.Query<T>(sql, parameters).ToList();
                    }
                }
                else
                {
                    using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                    {
                        conn.Open();
                        list = conn.Query<T>(sql).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex + ex.StackTrace);
            }
            return list;
        }

        public T GetUnique(T t)
        {
            T? data = default(T);
            var keyInfo = GetKeyPropertyAndValue(t);
            try
            {
                using (var conn = new SqlConnection(IRepository<T>.ConnStr))
                {
                    conn.Open();
                    data = conn.QueryFirstOrDefault<T>($"SELECT * FROM {typeof(T).Name} WHERE {keyInfo.Value.property.Name} = '{keyInfo.Value.value}'"
                    );
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return data;
        }

        private static (PropertyInfo property, object value)? GetKeyPropertyAndValue<T>(T entity)
        {
            if (entity == null)
                return null;

            var type = typeof(T);

            var keyProp = type.GetProperties()
                .FirstOrDefault(p => p.GetCustomAttribute<KeyAttribute>() != null);

            if (keyProp == null)
                return null;

            var value = keyProp.GetValue(entity);
            return (keyProp, value);
        }

        public abstract int Insert(T t);

        public abstract int Update(T t);
    }
}
