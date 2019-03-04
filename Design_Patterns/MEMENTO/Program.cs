using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir nesne üzerindeki değişikliği;istenildiği taktirde
             restore/undo işleminin uygulanabilmesini sağlayabilir.

             */

            Product product = new Product { Name = "ASUS Note Book A Series", Price = 6500.99m };
            product.ViewProduct();
            Console.WriteLine("===%10 indirim===");

            CareTaker history = new CareTaker();
            history.Memento = product.CreateUndo();
            product.Price -= product.Price * 0.1m;
            product.ViewProduct();

            Console.WriteLine("===Indirim sonlandı===");
            product.RestoreFromUndo(history.Memento);
            product.ViewProduct();

            Console.ReadKey();
        }
    }
    class Product
    {
        private string _name;
        private decimal _price;
        private DateTime _lastedited;
        public string Name
        {
           get { return _name; }
            set { _name = value; LastEdit(); }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value;
                LastEdit();
            }
            
        }
        public void LastEdit() => _lastedited = DateTime.Now;

        public void ViewProduct()
        {
            Console.WriteLine($"{_name} TRY{_price} TARIH={_lastedited.ToLongTimeString()}");
        }
        public Memento CreateUndo() => new Memento(_name, _price, _lastedited);
        public void RestoreFromUndo(Memento memento)
        {
            _name = memento.Name;
            _price = memento.Price;
            _lastedited = memento.LastEdit;
        }
    }
    class Memento
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime LastEdit { get; set; }
        public Memento(string _name,decimal _price,DateTime _lastedit)
        {
            Name = _name;
            Price = _price;
            LastEdit = _lastedit;
        }
    }
    class CareTaker
    {
        public Memento Memento { get; set; }
    }
}
