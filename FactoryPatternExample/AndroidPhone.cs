using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class AndroidPhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Making a call with an Android!");
        }

        public void Text()
        {
            Console.WriteLine("Texting with an Android phone..");
        }
    }
}
