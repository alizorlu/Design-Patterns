using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMAND.PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudManager manager = new CrudManager();
            TeacherOperation teacher = new TeacherOperation(manager);
            StudentOperation student = new StudentOperation(manager);

            CrudModel teacherModel=new CrudModel() { Name="Asaf Varol",Description="Prof Dr"};
            CrudModel studentModel=(new CrudModel() { Name = "Ali Zorlu", Description = "4.Sınıf Öğrenci" });

            CrudController controller = new CrudController();
            controller.AddCommand(teacher,teacherModel);
            controller.AddCommand(student,studentModel);
            controller.ExecCommands();

            Console.ReadLine();
        }
    }
    class CrudModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    class CrudManager
    {
        public void CreateTeacher(CrudModel model)
        {
            Console.WriteLine($"{model.Name} {model.Description} =>öğretmen eklendi.");
        }
        public void CreateStudent(CrudModel model)
        {
            Console.WriteLine($"{model.Name} {model.Description} =>öğrenci eklendi.");
        }
    }
    interface ICrud
    {
        void Execute(CrudModel model);
    }
    class TeacherOperation : ICrud
    {
        private CrudManager _crudManager;

        public TeacherOperation(CrudManager crudManager)
        {
            _crudManager = crudManager;
        }
        public void Execute(CrudModel model)
        {
            _crudManager.CreateTeacher(model);
        }
    }
    class StudentOperation : ICrud
    {
        private CrudManager _crudManager;
        public StudentOperation(CrudManager manager)
        {
            _crudManager = manager;
        }
        public void Execute(CrudModel model)
        {
            _crudManager.CreateStudent(model);
        }
    }
    class CrudController
    {
        private List<ICrud> _cruds = new List<ICrud>();
        private List<CrudModel> _model = new List<CrudModel>();
        public void AddCommand(ICrud crud,CrudModel model)
        {
            _cruds.Add(crud);
            _model.Add(model);
        }
        public void ExecCommands()
        {
            for (int i = 0; i < _cruds.Count; i++)
            {
                _cruds[i].Execute(_model[i]);
            }
        }
    }
}
