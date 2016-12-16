using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyProject
{
    public partial class Form1 : Form
    {
        private Connect myConn;
        public Form1()
        {
            InitializeComponent();

            myConn = new Connect();
        }

        //inserts Kids Department
        private void button1_Click(object sender, EventArgs e)
        {
            myConn.Insert();
        }

        //updates George Foreman Grill to 99.99
        private void button2_Click(object sender, EventArgs e)
        {
            myConn.Update();
        }

        //deletes item "Anker iPhone Charger"
        private void button3_Click(object sender, EventArgs e)
        {
            myConn.Delete();
        }

    }

   
}
