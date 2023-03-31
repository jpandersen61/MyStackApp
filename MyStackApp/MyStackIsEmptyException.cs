using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackApp
{
    public class MyStackIsEmptyException : Exception
    {
        public MyStackIsEmptyException(string message) : base(message)
        {

        }
    }
}
