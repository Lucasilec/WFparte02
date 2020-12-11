using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LogList l1 = new LogList();
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f1.Show();
            f2 = (Form2)FindForm();
            f2.Hide();
            
            for (int i = 0; i < l1.logList.Count; i++)
            {
                string imput = l1.logList[i].User.ToString() + " " + l1.logList[i].PassWord.ToString();
                listBox1.Items.Add(imput);
            }
        }
    }
}
