using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class DataException:ApplicationException
    {
        public DataException(string message):base(message)
        {

        }
    }

    class MyAppException:ApplicationException
    {
        public MyAppException(string message) : base(message)
        {

        }
        public MyAppException(string message,Exception inner):base(message, inner)
        {

        }
    }
}
