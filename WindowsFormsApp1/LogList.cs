using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class LogList
    {
        public List<LogList> logList = new List<LogList>();

        
        public string User { get; set; }
        public string PassWord { get; set; }

        public LogList(string user, string passWord)
        {
            User = user;
            PassWord = passWord;
        }

        public LogList()
        {

        }

        public void Inicializar()
        {
            string user = "Admin";
            string passWord = "Admin";
            LogList log = new LogList(user, passWord);
            logList.Add(log);
            user = "Clovis";
            passWord = "Picareta";
            LogList log1 = new LogList(user, passWord);
            logList.Add(log1);
            user = "Cleiton";
            passWord = "Manjadu";
            LogList log2 = new LogList(user, passWord);
            logList.Add(log2);
        }
    }
}
