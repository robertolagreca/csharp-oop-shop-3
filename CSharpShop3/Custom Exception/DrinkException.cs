using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop3.Custom_Exception
{
    public class DrinkException: ArgumentOutOfRangeException
    {
        public DrinkException(string ParamName, string Message): base (ParamName, Message) { }
    }
}
