using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            while (a <= 31) {
                comboBox1.Items.Add(a);
                a++;
            }

            int b = 1;
            while (b <= 12)
            {
                comboBox2.Items.Add(b);
                b++;
            }
            
            int c = 1900;
            while (c <= 2024)
            {
                comboBox3.Items.Add(c);
                c++;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
