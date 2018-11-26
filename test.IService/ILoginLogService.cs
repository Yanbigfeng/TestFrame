using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.DTO;

namespace test.IService
{
    public interface ILoginLogService : IDependency
    {
        /// <summary>
        /// 插入登录日志
        /// </summary>
        /// <returns></returns>
        int AddLoginLog();


        int ModiyLoginLog();

        int DelLoginLog();
    }
}
