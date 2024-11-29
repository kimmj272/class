using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //TestClass();
            TestClass2();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        public void TestClass()
        {
            txtResult.Text = "";
            Actor kMaster = new Actor();

            txtResult.Text += string.Format("Master HP = {0}\n", kMaster.m_HP);

            kMaster.SetDamage(50);
            txtResult.Text += string.Format("Master HP = {0}\n", kMaster.m_HP);

            txtResult.Text += "-----------------------------------\n";

            Actor kEnemy = new Actor();
            kEnemy.m_HP = 2000;
            kEnemy.m_Attack = 200;
            txtResult.Text += string.Format("Enemy HP = {0}\n", kEnemy.m_HP);

            kEnemy.SetDamage(100);
            txtResult.Text += string.Format("Enemy HP = {0}\n", kEnemy.m_HP);

            txtResult.Text += "-----------------------------------\n";

            Actor kActor = kMaster;
            kActor.AddHP(100);
            txtResult.Text += string.Format("Master HP = {0}\n", kActor.m_HP);

            kActor = kEnemy;
            kActor.AddHP(200);
            txtResult.Text += string.Format("Enemy HP = {0}\n", kActor.m_HP);

            txtResult.Text += "-----------------------------------\n";
        }

        public void TestClass2()
        {
            txtResult.Text = "";
            
            Animal a = new Animal();
            txtResult.Text += a.m_Name + "\n";
            a.m_Name = "강아지";
            txtResult.Text += a.m_Name + "\n";

            Animal b = new Animal();
            b.m_Name = "고양이"; 
            txtResult.Text += b.m_Name + "\n";

            Animal c = a;
            txtResult.Text += c.m_Name + "\n";
        }
    }
}
