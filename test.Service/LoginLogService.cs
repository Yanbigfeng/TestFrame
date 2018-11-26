using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;
using test.IService;

namespace test.Service
{
    class LoginLogService : BaseService, ILoginLogService
    {

        #region 增加
        public int AddLoginLog()
        {
            using (var db = new BaseDBContent())
            {
                try
                {
                    this.db2 = db;
                    SysLoginLogInfor sysLogin = new SysLoginLogInfor();
                    sysLogin.id = Guid.NewGuid().ToString("N");
                    sysLogin.userId = 100;
                    sysLogin.userName = "test100";
                    sysLogin.loginIp = "192.168.1.25";
                    sysLogin.loginCity = "青岛";
                    sysLogin.loginTime = DateTime.Now;
                    sysLogin.delFlag = 0;
                    return this.Add2<SysLoginLogInfor>(sysLogin);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                    System.Diagnostics.Debug.WriteLine("登录日志插入错误：" + ex);
                    System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                    return 0;
                }
            }

        }
        #endregion

        #region 修改
        public int ModiyLoginLog()
        {
            using (var db = new BaseDBContent())
            {
                db2 = db;
                var data = this.Entities<SysLoginLogInfor>().ToList();
                SysLoginLogInfor sysLogin = data.Where(u => u.id == "001").FirstOrDefault();
                sysLogin.userName = "修改了名字";
                return this.Modify<SysLoginLogInfor>(sysLogin);
            }
        }
        #endregion


        #region 删除
        public int DelLoginLog()
        {
            return 0;
        }
        #endregion


        #region 不用
        /// <summary>
        /// 插入登录日志
        /// </summary>
        /// <returns></returns>
        //public int AddLoginLog()
        //{
        //    try
        //    {
        //        SysLoginLogInfor sysLogin = new SysLoginLogInfor();
        //        sysLogin.id = Guid.NewGuid().ToString("N");
        //        sysLogin.userId = 100;
        //        sysLogin.userName = "test100";
        //        sysLogin.loginIp = "192.168.1.25";
        //        sysLogin.loginCity = "青岛";
        //        sysLogin.loginTime = DateTime.Now;
        //        sysLogin.delFlag = 0;
        //        return Add<SysLoginLogInfor>(sysLogin);
        //        // db.Set<SysLoginLogInfor>().Add(sysLogin);
        //        // return db.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine("------------------------------------------------");
        //        System.Diagnostics.Debug.WriteLine("登录日志插入错误：" + ex);
        //        System.Diagnostics.Debug.WriteLine("------------------------------------------------");
        //        return 0;
        //    }
        //} 
        #endregion

    }
}
