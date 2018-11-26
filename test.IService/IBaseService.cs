using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.DTO;

namespace test.IService
{
    /// <summary>
    /// 基类接口
    /// </summary>
    public interface IBaseService : IDependency
    {

        IQueryable<T> Entities<T>() where T : class, new();
        int Add<T>(T model) where T : class, new();
        int Del<T>(T model) where T : class, new();
        int Modify<T>(T model) where T : class, new();
    }
}
