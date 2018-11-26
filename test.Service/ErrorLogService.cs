using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Data;
using test.IService;

namespace test.Service
{
    public class ErrorLogService : BaseService, IErrorLogService
    {
        /// <summary>
        /// 插入错误日志数据
        /// </summary>
        /// <returns></returns>
        public int AddErrorLog()
        {
            try
            {
                SysErrorLogInfor sysError = new SysErrorLogInfor();
                sysError.id = Guid.NewGuid().ToString("N");
                sysError.userId = 100;
                sysError.userName = "test100";
                sysError.logLevel = "logLevel";
                sysError.logMessage = "logMessage";
                sysError.addTime = DateTime.Now;
                sysError.delFlag = 0;
                return this.Add<SysErrorLogInfor>(sysError);


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                System.Diagnostics.Debug.WriteLine("错误日志插入错误：" + ex);
                System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                return 0;
            }

        }

        /// <summary>
        /// 修改日志
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ModiyErrorLog(string id)
        {
            try
            {
                var data = this.Entities<SysErrorLogInfor>();
                SysErrorLogInfor sysError = data.Where(u => u.id == id).FirstOrDefault();
                sysError.logMessage = "修改信息内容";
                return this.Modify<SysErrorLogInfor>(sysError);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                System.Diagnostics.Debug.WriteLine("错误日志修改错误：" + ex);
                System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                return 0;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelErrorLog(string id)
        {
            try
            {
                var data = this.Entities<SysErrorLogInfor>();
                SysErrorLogInfor sysError = data.Where(u => u.id == id).FirstOrDefault();
                return this.Del<SysErrorLogInfor>(sysError);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                System.Diagnostics.Debug.WriteLine("错误日志日志删除错误：" + ex);
                System.Diagnostics.Debug.WriteLine("------------------------------------------------");
                return 0;

            }
        }

    }
}
