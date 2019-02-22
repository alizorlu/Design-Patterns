using Design_Patterns.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINGLETON.PATTERN
{
    public partial class Form1 : Form
    {
        SystemUsers _car = null;
        public Form1()
        {
            InitializeComponent();
            _car = SystemUsers.CreateUser();
        }

        

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            _car.email = emailTxt.Text;
        }

        private void cityCode_TextChanged(object sender, EventArgs e)
        {
            _car.city = sbyte.Parse(cityCode.Text);
        }

        private void birtDate_ValueChanged(object sender, EventArgs e)
        {
            _car.birthdate = birtDate.Value;
        }
        private void getModelBtn_Click(object sender, EventArgs e)
        {
            _car.Saved();
        }
    }
    class SystemUsers
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string email { get; set; }
        public sbyte city { get; set; }
        public DateTime birthdate { get; set; }

        private static object _lock = new object();
        private static SystemUsers newUser;
        private SystemUsers()
        {

        }
        public static SystemUsers CreateUser()
        {
            lock (_lock)
            {
                if (newUser == null) {
                    newUser = new SystemUsers();
                }
                return newUser;

            }
        }
        public void Saved()
        {
            LiteRepo<SystemUsers> repo = new LiteRepo<SystemUsers>(new SystemUsers());
            bool added = false;
            repo.Add(newUser, out added);
            if (added)
            {
                MessageBox.Show("Success");
            }else
            {
                MessageBox.Show("Error");
            }
        }
    }
    
}
