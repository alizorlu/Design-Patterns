using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAINOFRESPONSIBILITY
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Hiyerarşik ve akış şartına göre çözüm sunabilecek tasarım desenidir.
             */
            Mudur mudur = new Mudur();
            GenelMudur genelMudur = new GenelMudur();
            Ceo ceo = new Ceo();

            //Yetkiler belirlenir.
            mudur.IzinOnayi(genelMudur);
            genelMudur.IzinOnayi(ceo);

            //Yeni bir izin oluşturulur.

            IzinModel dogumizni = new IzinModel() { Aciklamasi = "Doğum", GunSayisi = 21 };
            IzinModel seyahat = new IzinModel() { Aciklamasi = "Seyahat", GunSayisi = 4 };
            IzinModel genel = new IzinModel() { Aciklamasi = "Genel", GunSayisi = 12 };
            mudur.Handle(dogumizni);
            mudur.Handle(seyahat);
            mudur.Handle(genel);
            Console.ReadKey();
        }
    }
    class IzinModel
    {
        public string Aciklamasi { get; set; }
        public int GunSayisi { get; set; }
    }
    abstract class IzinHandleBase
    {
        public IzinHandleBase _yetkili;
        public abstract void Handle(IzinModel model);

        public void IzinOnayi(IzinHandleBase yetkili)
        {
            _yetkili = yetkili;
        }
    }
    class Mudur : IzinHandleBase
    {
        public override void Handle(IzinModel model)
        {
            //İstenen izin 1-5 gün arasında ise müdür onaylayabilir
            if (model.GunSayisi >= 1 && model.GunSayisi <= 5)
            {
                Console.WriteLine($"{model.Aciklamasi} izni müdür tarafından verildi [{model.GunSayisi} gün]");
            }
            else if (_yetkili != null)
            {
                _yetkili.Handle(model);
            }
        }
    }
    class GenelMudur : IzinHandleBase
    {
        public override void Handle(IzinModel model)
        {
            //Eğer istenen izin 5-15 gün arasında ise genel müdür onaylar
            if (model.GunSayisi>5&&model.GunSayisi<=15)
            {
                Console.WriteLine($"{model.Aciklamasi} izni genel müdür tarafından verildi [{model.GunSayisi} gün]");
            }
            else if (_yetkili != null)
            {
                _yetkili.Handle(model);
            }
        }
    }
    class Ceo : IzinHandleBase
    {
        public override void Handle(IzinModel model)
        {
            if (model.GunSayisi>15)
            {
                Console.WriteLine($"{model.Aciklamasi} izni ceo tarafından verildi [{model.GunSayisi} gün]");
            }
           
        }
    }
}
