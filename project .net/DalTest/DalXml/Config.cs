using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DalXml
{
    internal static class Config
    {
        private const string filePath = "../xml/data-config.xml";

        public static int ProductId
        {
            get
            {
                XElement file = XElement.Load(filePath);
                XElement curProID = file.Element("productId");
                int num = int.Parse(curProID.Value);
                curProID.SetValue(num + 1);
                file.Save(filePath);
                return num;
            }
        }
        public static int SaleId
        {
            get
            {
                XElement file = XElement.Load(filePath);
                XElement curSaleId = file.Element("saleId");
                int num = int.Parse(curSaleId.Value);
                curSaleId.SetValue(num + 1);
                file.Save(filePath);
                return num;
            }
        }



    }
}
