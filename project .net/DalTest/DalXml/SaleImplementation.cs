using DalApi;
using DalXml;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation:Isale
{
    string filePath = "../xml/sales.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));

        public int Create(Sale sale)
        {
            List<Sale> sales;

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();
                }
            }
            else
            {
                sales = new List<Sale>();
            }

            Sale newSale = sale with { id_product = Config.SaleId };
            sales.Add(newSale);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, sales);
            }

            return newSale.id_product;
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            if (!File.Exists(filePath))
                throw new DalFileNotExsist();

            List<Sale> sales;

            using (StreamReader reader = new StreamReader(filePath))
            {
                sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();
            }

            return sales.FirstOrDefault(filter);
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            if (!File.Exists(filePath))
                throw new DalFileNotExsist();

            List<Sale> sales;

            using (StreamReader reader = new StreamReader(filePath))
            {
                sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();
            }

            return filter == null
                ? sales
                : sales.Where(filter).ToList();
        }

        public void Update(Sale sale)
        {
            if (!File.Exists(filePath))
                throw new DalFileNotExsist();

            List<Sale> sales;

            using (StreamReader reader = new StreamReader(filePath))
            {
                sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();
            }

            int index = sales.FindIndex(s => s.id_product == sale.id_product);

            if (index == -1)
                throw new Exception("Sale not found");

            sales[index] = sale;

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, sales);
            }
        }

        public void Delete(int id)
        {
            if (!File.Exists(filePath))
                throw new DalFileNotExsist();

            List<Sale> sales;

            using (StreamReader reader = new StreamReader(filePath))
            {
                sales = serializer.Deserialize(reader) as List<Sale> ?? new List<Sale>();
            }

            var sale = sales.FirstOrDefault(s => s.id_product == id);

            if (sale == null)
                throw new Exception("Sale not found");

            sales.Remove(sale);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, sales);
            }
        }
}
