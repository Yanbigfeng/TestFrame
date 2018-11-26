namespace test.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class SysLoginLogInfor
    {

        public string id { get; set; }

        public int userId { get; set; }


        public string userName { get; set; }


        public string loginIp { get; set; }


        public string loginCity { get; set; }

        public DateTime? loginTime { get; set; }

        public int? delFlag { get; set; }
    }
}
