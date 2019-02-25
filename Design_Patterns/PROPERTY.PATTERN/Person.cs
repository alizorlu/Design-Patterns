using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPERTY.PATTERN
{
    public abstract class Person
    {
        public abstract Person Clone();
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
   
    public class Teacher : Person
    {
        public string University { get; set; }
        public string Lesson { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Customer : Person
    {
        public string TakenService { get; set; }
        public DateTime TakenServiceDate { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Admin : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }

}
