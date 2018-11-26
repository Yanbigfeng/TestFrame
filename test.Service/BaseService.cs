using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using test.Data;
using test.IService;

namespace test.Service
{
    /// <summary>
    /// 业务基类
    /// </summary>
    public class BaseService : IBaseService
    {


        /***************************-----测试-----************************************/



        /**************************----定义全局上下文基础方法封装----*************************************/

        //定义上下文统一,提前定义变量然后使用赋值，测试可用，但是太傻了
        public BaseDBContent db2;
        #region 增加
        public int Add2<T>(T model) where T : class, new()
        {
            DbSet<T> dst = db2.Set<T>();
            dst.Add(model);
            return db2.SaveChanges();

        }
        #endregion

        #region 删除

        #endregion

        /**************************----泛型方法实现基础方法封装----*************************************/

        #region 查询
        public IQueryable<T> Entities<T>() where T : class, new()
        {
            var db = new BaseDBContent();
            return db.Set<T>();
        }
        #endregion

        #region 增加
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add<T>(T model) where T : class, new()
        {
            using (var db = new BaseDBContent())
            {
                DbSet<T> dst = db.Set<T>();
                dst.Add(model);
                return db.SaveChanges();
            }
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Del<T>(T model) where T : class, new()
        {
            using (var db = new BaseDBContent())
            {
                db.Set<T>().Attach(model);
                db.Set<T>().Remove(model);
                return db.SaveChanges();
            }
        }
        #endregion

        #region 修改
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Modify<T>(T model) where T : class, new()
        {
            using (var db = new BaseDBContent())
            {
                db.Entry(model).State = EntityState.Modified;
                return db.SaveChanges();
            }

        } 
        #endregion


    }
}
