using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY.INJECTION.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager product = new ProductManager(new EFProductDal());
            product.SaveProduct();
            product = new ProductManager(new NHProductDal());
            product.SaveProduct();
            Console.ReadKey();
        }
    }
    /*
     Nesneye olan bağımlılık durumlarına bir çözüm sunan tasarım desenidir.
     Genellikle iş katmanlarında yaşanan nesneye bağlılık sorunlarına çözüm sunabilir.
         */
    interface IProductDal
    {
        void Save();
    }
    class EFProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with ef");
        }
    }
    class NHProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with nh");
        }
    }
    class ProductManager
    {
        private IProductDal _productdal;
        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }
        public void SaveProduct() => _productdal.Save();
    }
}
