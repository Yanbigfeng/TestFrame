namespace test.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SysErrorLogInfor
    {
        public string id { get; set; }

        public int userId { get; set; }

        public string userName { get; set; }

        public string logLevel { get; set; }

        public string logMessage { get; set; }

        public DateTime? addTime { get; set; }

        public int? delFlag { get; set; }
    }
}
