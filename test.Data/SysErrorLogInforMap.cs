using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Data
{
    public class SysErrorLogInforMap : EntityTypeConfiguration<SysErrorLogInfor>
    {
        public SysErrorLogInforMap()
        {
            //配置属性字段
            Property(t => t.id).HasMaxLength(32);
            Property(t => t.userName).HasMaxLength(50);
            Property(t => t.logLevel).HasMaxLength(50);
            //配置表名
            //ToTable("SysErrorLogInfor");
        }
    
    }
}
