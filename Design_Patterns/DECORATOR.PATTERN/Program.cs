using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECORATOR.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductBase product = new MarketProducts()
            {
                Name = "Ülker Çikolatalı Gofret",
                Unit = "Adet/1",
                Price = 1.35m
            };
            Console.WriteLine($"{product.Name}={product.Price}TL");
            SpecialOffer special = new SpecialOffer(product);
            special.DiscountPercentage = 10;
            Console.WriteLine($"{special.Name}={special.Price}TL");
            Console.ReadKey();
        }
    }
    abstract class ProductBase
    {
        public abstract string Name { get; set; }
        public abstract string Unit { get; set; }
        public abstract decimal Price { get; set; }
    }
    class MarketProducts : ProductBase
    {
        public override string Name { get;set; }
        public override string Unit { get; set; }
        public override decimal Price { get; set; }
    }
    class ButcherProducts : ProductBase
    {
        public override string Name { get; set; }
        public override string Unit { get; set; }
        public override decimal Price { get; set; }
    }
    abstract class ProductDecoratorBase : ProductBase
    {
        private ProductBase _product;
        protected ProductDecoratorBase(ProductBase product)
        {
            _product = product;
        }
    }
    class SpecialOffer : ProductDecoratorBase
    {
        private readonly ProductBase product;
        public int DiscountPercentage { get; set; } = 0;
        public SpecialOffer(ProductBase _product):base(_product)
        {
            product = _product;
        }
        public override string Name { get; set; }
        public override string Unit { get; set; }
        public override decimal Price { get { return product.Price - (product.Price * DiscountPercentage / 100); }
            set {  } }
    }
}
