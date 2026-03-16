using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DalXml
{
    internal static class Config
    {
        private const string nameconfig = "data-config";
        public static int ProductNum
        {
            get
            {
                ProductNum++;
                return 0;
            }
        }

    }
}
