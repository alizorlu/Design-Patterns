using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVER.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsManager manager = new NewsManager();
            manager.news = new News()
            {
                Title = "Ortamın Adını Koyduk!",
                Content = "Fikret Orman,bjkstore marketiyle piyasada takıma ait ürünlerin satışını yapacaklarını söyledi",
                AddingTime = DateTime.Now
            };
            Observer visitor = new VisitorObserver();
            manager.Attach(visitor);
            visitor.ChangeNews();
            manager.Attach(new SubscriberObserver());
            manager.AddNews();
            Console.ReadLine();
        }
    }
    class NewsManager
    {
        List<Observer> _observer = new List<Observer>();
        public News news { get; set; }
        public void AddNews()
        {
            Console.WriteLine($"Son dakika !\n{news.Title.ToUpper()}\n{news.Content}\nTarih:{news.AddingTime.ToShortDateString()}");
            
        }
        public void Attach(Observer observer)
        {
            _observer.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observer.Remove(observer);
        }
        private void NotifyAll()
        {
            foreach (var item in _observer)
            {
                AddNews();
            }
        }
    }
    abstract class Observer
    {
       
        public abstract void ChangeNews();
       
    }
    class VisitorObserver : Observer
    {
        public override void ChangeNews()
        {
            Console.WriteLine($"[Ziyaretçi]:Biraz önce şöyle bir haber yayınlandı.");
        }
    }
    class SubscriberObserver : Observer
    {
        public override void ChangeNews()
        {
            Console.WriteLine($"[Abone]:Biraz önce şöyle bir haber yayınlandı.");
        }
    }
    public class News
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime AddingTime { get; set; }
    }
}
