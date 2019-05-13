using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication
{
    public static class DbEnum
    {
        public enum DBResposeType { OK, NotOK, ConnectionError, SQLError };
    }
}
