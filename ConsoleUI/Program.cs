
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EfProductDal efProductDal = new EfProductDal();

            Product product1 = new Product { CategoryId = 1, 
                BrandId = 1, 
                Name = "Su", Price = 2, 
                CreateDate = DateTime.Now, 
                Code = "WTR01", Active = true };

            efProductDal.Add(product1);

            foreach (var product in efProductDal.GetAll())
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
