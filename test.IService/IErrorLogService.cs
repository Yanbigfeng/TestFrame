using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.DTO;

namespace test.IService
{
   public interface IErrorLogService:IDependency
    {
        /// <summary>
        /// 插入错误日志数据
        /// </summary>
        /// <returns></returns>
        int AddErrorLog();

        /// <summary>
        /// 修改日志
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int ModiyErrorLog(string id);
    }
}
