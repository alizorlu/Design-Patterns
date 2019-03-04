using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATOR
{
    class Program
    {
        static void Main(string[] args)
        {

            Mediator mediator = new Mediator();
            Students student1 = new Students(mediator);
            student1.Name = "Necip Memilli";
            Students student2 = new Students(mediator);
            student2.Name = "La İbo";

            mediator.Students = new List<Students>();
            mediator.Students.Add(student1);
            mediator.Students.Add(student2);

            Teacher teacher = new Teacher(mediator);
            teacher.Name = "Çok Qotü Düşen";
            mediator.Teacher = teacher;

            mediator.SendQuestion("Bişi oldumu?", student2);
            teacher.AnswerQuestion("Yoghh", teacher);
            Console.ReadKey();
        }

    }
    abstract class CourseMember
    {
        private Mediator _mediator;
        protected CourseMember(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
    class Students : CourseMember
    {
        protected Mediator Mediator;
        public string Name { get; set; }

        public Students(Mediator mediator):base(mediator)
        {
            Mediator = mediator;
        }

    }
    class Teacher : CourseMember
    {
        public string Name { get; set; }
        protected Mediator Mediator;

        public Teacher(Mediator mediator):base(mediator)
        {
            Mediator = mediator;
        }
        public void ReceiveQuestion(string question,Students receive)
        {
            Console.WriteLine($"{receive.Name} öğrencisi :{question} sorusunu sordu");
        }
        public void AnswerQuestion(string question,Teacher teacher)
        {
            Console.WriteLine($"[{teacher.Name}] = {question} cevabını verdi");
        }

    }
    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Students> Students { get; set; }

        public void SendQuestion(string question,Students student)
        {
            Teacher.ReceiveQuestion(question, student);
        }

    }
}
