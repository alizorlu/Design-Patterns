using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABSTRACTFACTORY.PATTERN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {

            OperationModel.administrator = new AdministratorUser();
            OperationModel.administrator.email = "azorlua@gmail.com";
            OperationModel.administrator.username = "azorlua";
            OperationModel.teacher = new TeacherRegister();
            OperationModel.teacher.Name = "Engin";
            OperationModel.teacher.Surname = "Avcı";
            OperationModel.teacher.Lesson = "Image Processing";
            OperationModel model = new OperationModel(new SystemAuth());

            model.GetAll();
        }

        private void editorBtn_Click(object sender, EventArgs e)
        {
            OperationModel.student = new StudentRegister();
            OperationModel.student.Education = "Fırat Üniversitesi";
            OperationModel.student.Name = "Ali";
            OperationModel.student.Surname = "Zorlu";
            OperationModel.customer = new Customer();
            OperationModel.customer.email = "musteri@emagazam.com";
            OperationModel.customer.job = "Serbest Meslek";
            OperationModel model = new OperationModel(new Auth());

            model.GetAll();
        }
    }
    public abstract class Register
    {
        public abstract void Regist(object model);
    }
    public class StudentRegister : Register
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Education { get; set; }
        public override void Regist(object model)
        {
            StudentRegister student
                = (StudentRegister)model;
            MessageBox.Show($"{student.Name}{student.Surname} öğrencinin kaydı başarılı {DateTime.Now.ToString("HH:mm")}");
        }
    }
    public class TeacherRegister : Register
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lesson { get; set; }
        public override void Regist(object model)
        {
            TeacherRegister teacher
                = (TeacherRegister)model;
            MessageBox.Show($"{teacher.Name}{teacher.Surname} " +
                $"öğretmenin kaydı başarılı[{teacher.Lesson}] {DateTime.Now.ToString("HH:mm")}");
        }
    }
    public abstract class SystemUser
    {
        public abstract void CreateUser(object model);
    }
    public class AdministratorUser : SystemUser
    {
        public string username { get; set; }
        public string email { get; set; }
        public override void CreateUser(object model)
        {
            AdministratorUser administrator
                = (AdministratorUser)model;
            MessageBox.Show($"Yeni admin oluşturuldu.\n{administrator.email}");
        }
    }
    public class Customer : SystemUser
    {
        public string email { get; set; }
        public string job { get; set; }
        public override void CreateUser(object model)
        {
            Customer customer = (Customer)model;
            MessageBox.Show($"Yeni müşteri[{customer.job}] oluşturuldu.\n{customer.email}");
        }
    }
    public abstract class SystemAuthFactory
    {
        public abstract Register CreateRegister();
        public abstract SystemUser CreateSystemUser();
    }
    public class SystemAuth : SystemAuthFactory
    {
        public override Register CreateRegister()
        {
            return new TeacherRegister();
        }

        public override SystemUser CreateSystemUser()
        {
            return new AdministratorUser();
        }
    }
    public class Auth : SystemAuthFactory
    {
        public override Register CreateRegister()
        {
            return new StudentRegister();
        }

        public override SystemUser CreateSystemUser()
        {
            return new Customer();
        }
    }
    public class OperationModel
    {
        private SystemAuthFactory systemAuthFactory;
        private SystemUser systemUser;
        private Register register;
        private object _lock = new object();
        public static AdministratorUser administrator;
        public static TeacherRegister teacher;
        public static Customer customer;
        public static StudentRegister student;
        public OperationModel(SystemAuthFactory systemAuthFactory)
        {
            this.systemAuthFactory = systemAuthFactory;
            systemUser = this.systemAuthFactory.CreateSystemUser();
            
            //systemUser.CreateUser(administrator); //EDITOR OPERATION BEFORE COMMENT
            systemUser.CreateUser(customer);
            register = this.systemAuthFactory.CreateRegister();
            //register.Regist(teacher); //EDITOR OPERATION BEFORE COMMENT
            register.Regist(student);
        }
        public void GetAll()
        {
            MessageBox.Show("Tüm operasyonlar gerçekleşti");
        }
    }
}
