using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NPoco_Mysql_NetCore_Sample.Model
{
    public class HomeViewModel
    {
       public List<DotNetDbModel> DotNetFrameworks { get; set; }
    }

    [TableName("test1")]
    public class DotNetDbModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("dotnet_version")]
        public float Version { get; set; }

        [Column("dotnet_framework")]
        public DotNetFramework Framework { get; set; }
    }

    public enum DotNetFramework
    {
        Full = 1,
        Core = 2
    }
}
