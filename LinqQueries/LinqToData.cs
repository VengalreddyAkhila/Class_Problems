using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LinqQueries
{
    public class LinqToData
    {
        public void AddData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "Sanitizer");
            table.Rows.Add("2", "Dettol");
            table.Rows.Add("3", "HandWash");
            DisplayProducts(table);
        }

        private void DisplayProducts(DataTable table)
        {
            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
            Console.WriteLine("product names: ");
            foreach (string productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}
