using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Data
{
  public  class SysLoginLogInforMap: EntityTypeConfiguration<SysLoginLogInfor>
    {

        public SysLoginLogInforMap()
        {
            //配置属性字段
            Property(t => t.id).HasMaxLength(32);
            Property(t => t.userName).HasColumnType("varchar(MAX)").IsVariableLength().IsMaxLength();
            Property(t => t.loginIp).HasMaxLength(50);
            Property(t => t.loginCity).HasMaxLength(50);
            //ToTable("SysLoginLogInfor");
        }

    }
}
