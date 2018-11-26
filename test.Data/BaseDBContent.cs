using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace test.Data
{
    public class BaseDBContent : DbContext
    {
        public BaseDBContent()
        : base("name=Entity")
        {
            //从不创建数据库
           // Database.SetInitializer<BaseDBContent>(null);
        }

        public virtual DbSet<SysErrorLogInfor> SysErrorLogInfor { get; set; }
        public virtual DbSet<SysLoginLogInfor> SysLoginLogInfor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //手动加载
            //modelBuilder.Configurations.Add(new SysErrorLogInforMap());
            //全部加载
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            //删除默认数据库复数策略
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
