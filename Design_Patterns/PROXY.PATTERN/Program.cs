using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROXY.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            LocationBase location = new LocationManagerProxy();
            Console.WriteLine(location.GetIpAddress());
            Console.WriteLine(location.GetIpAddress());
            Console.WriteLine(location.GetIpAddress());
            Console.ReadKey();
        }
    }
    /*
     Proxy design pattern, cachleme sistemleri için kullanılabilecek
     tasarım kalıbı olarak çözüm sunar.
     Örnek:Sistemin ip adresini almak olsun.1 kere alınan bir ip adresini tekrar güncellemeye gerek kalmayacaktır.
     */
    abstract class LocationBase
    {
        public abstract string GetIpAddress();
    }
    class LocationManager : LocationBase
    {
        public override string GetIpAddress()
        {
            Console.WriteLine("===İp Adresi Getiriliyor===");
            Thread.Sleep(4000);
            var _page
                = new WebClient().DownloadString("https://api.ipify.org/?format=json");
            var _data = JObject.Parse(_page);
            return _data["ip"].ToString();
        }
    }
    class LocationManagerProxy : LocationBase
    {
        private LocationManager _location;
        private string _ip;
        public override string GetIpAddress()
        {
            if (_location == null)
            {
                _location = new LocationManager();
                _ip = _location.GetIpAddress();
            }
            return _ip;
        }
    }
}
