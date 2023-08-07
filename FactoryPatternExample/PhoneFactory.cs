using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public static class PhoneFactory
    {
        public static IMobilePhone GetPhone(string phoneType)
        {
            switch(phoneType.ToLower())
            {
                case "android":
                    return new AndroidPhone();
                case "apple":
                case "iphone":
                    return new ApplePhone();
                case "google":
                    return new GooglePhone();
                default:
                    return new AndroidPhone();
            }
        }
    }
}
