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
                SaveConfig(); 
                return ProductNum;
            }
            set
            {
                ProductNum = value;
            }
        }
        private static void SaveConfig()
        {
            var doc = new System.Xml.XmlDocument();
            doc.Load(nameconfig);
            doc.SelectSingleNode("/config/ProductNum").InnerText = ProductNum.ToString();
            doc.Save(nameconfig);
        }



    }
}
