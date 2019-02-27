using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityPerson profesor = new UniversityPerson()
            {
                Name = "Asaf Varol",
                Task = "Profesör"
            };
            UniversityPerson docent = new UniversityPerson()
            {
                Name = "Murat Karabatak",
                Task = "Doçent"
            };
            UniversityPerson docent2 = new UniversityPerson()
            {
                Name = "Erkan Tanyıldızı",
                Task = "Doçent"
            };
            UniversityPerson yrdoc = new UniversityPerson()
            {
                Name = "Muhammet Baykara",
                Task = "Yardımcı Doçent"
            };
            UniversityPerson yrdoc2 = new UniversityPerson()
            {
                Name = "Mustafa Ulaş",
                Task = "Yardımcı Doçent"
            };
            UniversityPerson argor = new UniversityPerson()
            {
                Name = "Zafer Güler",
                Task = "Araştırma Görevlisi"
            };
            UniversityPerson argor2 = new UniversityPerson()
            {
                Name = "Nilay Yıldırım",
                Task = "Araştırma Görevlisi"
            };
            UniversityPerson ogrenci = new UniversityPerson()
            {
                Name = "Ali Zorlu",
                Task = "4.Sınıf Öğrenci"
            };
            UniversityPerson ogrenci1 = new UniversityPerson()
            {
                Name = "Serhat Üstek",
                Task = "4.Sınıf Öğrenci"
            };

            profesor.AddPeople(docent);
            profesor.AddPeople(docent2);
            profesor.AddPeople(yrdoc2);
            profesor.AddPeople(yrdoc);
            profesor.AddPeople(argor);
            profesor.AddPeople(argor2);
            profesor.AddPeople(ogrenci);
            profesor.AddPeople(ogrenci1);
            argor.AddPeople(ogrenci);
            argor.AddPeople(ogrenci1);

            foreach (UniversityPerson subpeople in argor)
            {
                Console.WriteLine($"ÜST {subpeople.Name}\t:{subpeople.Task}");
            }
            Console.ReadKey();
        }
    }
    //HİYERARŞİK BİR ÇÖZÜM SUNAN TASARIM KALIBI
    interface IPeople
    {
        string Name { get; set; }
        string Task { get; set; }
    }
    class UniversityPerson:IPeople,IEnumerable<IPeople>
    {
        public string Name { get; set; }
        public string Task { get; set; }
        List<IPeople> _peoples = new List<IPeople>();
        public IEnumerator<IPeople> GetEnumerator()
        {
            foreach (var item in _peoples)
            {
                yield return item;
            }
        }
        public void AddPeople(IPeople people)
        {
            _peoples.Add(people);
        }
        public IPeople GetPeople(int index) => _peoples[index];
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
