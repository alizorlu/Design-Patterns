using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROPERTY.PATTERN
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Id = Guid.NewGuid(),
                Lesson = "Math",
                Name = "Jane",
                Surname = "Carl",
                Phone = "+950 256 25 22",
                University = "Las Vegas"
            };
            Teacher newteacher = (Teacher)teacher.Clone();
            newteacher.Name = "Erkan";
            newteacher.Surname = "Tanyıldızı";
            newteacher.Lesson = "Algorithm Analys";
            MessageBox.Show($"Kayıt edilen öğretmen bilgisi:\n{newteacher.Name} {newteacher.Surname}\n{newteacher.Lesson}");
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Guid.NewGuid();
            Customer newcustomer = (Customer)customer.Clone();
            newcustomer.Name = "Ali";
            newcustomer.Surname = "Zorlu";
            newcustomer.TakenService = "Office 2020 Word Pro Series";
            newcustomer.TakenServiceDate = DateTime.Now;
            newcustomer
                .Phone = "0952 256 32 21";
            MessageBox.Show($"Kayıt edilen müşteri bilgisi:\n{newcustomer.Name} {newcustomer.Surname}\n{newcustomer.TakenService}");

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
         
        }
    }
}
