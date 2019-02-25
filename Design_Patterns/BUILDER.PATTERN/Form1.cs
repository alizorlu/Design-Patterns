using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUILDER.PATTERN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDebtDirector director = new StudentDebtDirector();

            StudentDebtDirector.student = new StudentViewModel()
            {
                Id = 1,
                IsMale = false,
                Name = "Zeliha",
                Surname = "Kocabaş",
                Paid = 2000m
            };
            var builder = new FemaleStudentDebtBuilder();
            director.GenerateStudentDebt(builder);
            var resultmodel = builder.GetStudentData(StudentDebtDirector.student);

        }
    }
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsMale { get; set; }
        public decimal Paid { get; set; }
    }
    public abstract class StudentBuilder
    {
        public abstract StudentViewModel GetStudentData(StudentViewModel model);
        public abstract void DeptStudent(StudentViewModel model);
    }
    public class FemaleStudentDebtBuilder : StudentBuilder
    {
        public override void DeptStudent(StudentViewModel model)
        {
            model.Paid = model.Paid * 0.05m;
        }

        public override StudentViewModel GetStudentData(StudentViewModel model)
        {
            return model;
        }
    }
    public class MaleStudentDebtBuilder : StudentBuilder
    {
        public override void DeptStudent(StudentViewModel model)
        {
            model.Paid = model.Paid * 0.04m;
        }

        public override StudentViewModel GetStudentData(StudentViewModel model)
        {
            return model;
        }
    }
    public class StudentDebtDirector
    {
        public static StudentViewModel student;
        private object _lock = new object();
        public StudentViewModel CreateStudent()
        {
            lock (_lock)
            {
                if (student == null) student = new StudentViewModel();
            }
            return student;
        }
        public void GenerateStudentDebt(StudentBuilder builder)
        {
            builder.GetStudentData(student);
            builder.DeptStudent(student);
        }
    }
}
