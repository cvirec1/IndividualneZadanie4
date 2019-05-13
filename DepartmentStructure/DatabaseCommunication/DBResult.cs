using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication
{
    public class DBResult
    {
        public DbEnum.DBResposeType DBResultEnum { get; set; }
        public string DBResultMessage { get; set; }
    }
}
