using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.DB
{
    public class LiteRepo<T> : ILiteRepo<T>
    {
        private LiteDatabase db = null;

        private LiteCollection<T> table { get; set; }
        public LiteRepo(T model)
        {
            db = new LiteDatabase($@"D:\ÜNİVERSİTE PROJELER\İŞ_YERİ_EĞİTİM\Günlük\22.02.2019\Tasarım Kalıpları Çalışması\Design_Patterns\Design_Patterns.DB\bin\Debug\pattern.db");
            table = db.GetCollection<T>(model.GetType().Name.ToString());

        }
        public void Add(T Model, out bool result)
        {
            try
            {
                table.Insert(Model);
                result = true;
            }
            catch (LiteDB.LiteException)
            {

                result = false;
            }

        }

        public void Delete(Guid id, out bool result)
        {
            table.Delete(id);
            result = true;
        }

        public List<T> GetList()
        {
            return table.FindAll().ToList();
        }

        public void Update(T Model, out bool result)
        {
            table.Update(Model);
            result = true;
        }

        public T Find(Guid id)
        {
            return table.FindById(id);
        }
    }
}
