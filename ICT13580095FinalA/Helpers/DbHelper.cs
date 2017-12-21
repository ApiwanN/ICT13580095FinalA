using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ICT13580095FinalA.Model;
using SQLite;
namespace ICT13580095FinalA.Helpers
                           
{
    public class Dbhelper
    {
		SQLiteConnection db;
        public Dbhelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();

        }
        public int AddProduct (Product product)
        {
            db.Insert(product);
            return product.Id;
        }

        internal IEnumerable GetProduct()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
		{
			return db.Table<Product>().ToList();
		}

		public int UpdateProduct(Product product)
		{
			return db.Update(product);
		}

		public int DeleteProduct(Product product)
		{
			return db.Delete(product);
		}
    }
}


