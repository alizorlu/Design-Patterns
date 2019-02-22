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

namespace FACTORY.PATTERN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userLogBtn_Click(object sender, EventArgs e)
        {
            var logger = new UserLogger();
            var userlog = logger.CreateLog();
            userlog.LogDesc = "New  user log description";
            userlog.LogType = LogType.User;
            userlog.LogDevice = Environment.UserName;
            userlog.LogTime = DateTime.Now;
            logger.SaveLog(userlog);
            
        }

        private void adminLogBtn_Click(object sender, EventArgs e)
        {
            var logger = new UserLogger();
            var adminlog = logger.CreateLog();
            adminlog.LogDesc = "New admin log description";
            adminlog.LogType = LogType.Admin;
            adminlog.LogDevice = Environment.UserName;
            adminlog.LogTime = DateTime.Now;
            logger.SaveLog(adminlog);
        }
    }
    public enum LogType
    {
        Admin,User,File
    }
    public class Log
    {
        public string LogDesc { get; set; }
        public string LogDevice { get; set; }
        public DateTime LogTime { get; set; }
        public LogType LogType { get; set; }
        private static Log _log;
        private static object _lock = new object();
        private Log()
        {

        }
        public static Log CreateLog()
        {
            lock (_lock)
            {
                if (_log == null) _log = new Log();
                return _log;
            }
        }
    }
    public class Logger : ILoggerUserFactory
    {
        public ILogger CreateUserLogger()
        {
            return new UserLogger();
        }
        
    }
    public interface ILoggerUserFactory
    {
        ILogger CreateUserLogger();     
    }
    public interface ILogger
    {
        Log CreateLog();
        void SaveLog(Log log);
       
    }
    public class UserLogger : ILogger
    {
        public Log CreateLog()
        {
            Log log = Log.CreateLog();
            return log;
        }

        public void SaveLog(Log log)
        {
            LiteRepo<Log> logrepo = new LiteRepo<Log>(log);
            bool added = false;
            logrepo.Add(log, out added);
            MessageBox.Show("User log saved succesfull");
        }
    }
    public class AdminLogger : ILogger
    {
        public Log CreateLog()
        {
            return Log.CreateLog();
        }

        public void SaveLog(Log log)
        {
            LiteRepo<Log> logrepo = new LiteRepo<Log>(log);
            bool added = false;
            logrepo.Add(log, out added);
            MessageBox.Show("Admin log saved succesfull");
        }
    }


}
