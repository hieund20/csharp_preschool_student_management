using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preschool_Student_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hideTabHeader()
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideTabHeader();
            //INSERT DATA
            //Utils.insertQuery("INSERT INTO preschool_student_management_db.student(full_name, age, address) VALUES('Nguyen F', 2, 'Quan 6')");

            //SELECT DATA

            //List<string> response = Utils.selectQuery("SELECT * FROM student", "age");
            //foreach (var i in response)
            //{
            //    textBoxTest.Text += i.ToString();
            //}

            //DELETE DATA
            //Utils.deleteQuery("DELETE FROM student WHERE id = 8");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //DASHBOARD
        private void buttonTabStudent_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabStudentPage;
        }

        private void buttonTabTimeTable_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabTimePage;
        }

        private void buttonTabVacxin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabVacxinPage;
        }

        private void buttonTabClass_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabClassPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exitDialog = MessageBox.Show(
                "Bạn có chắc muốn thoát?", 
                "Xác nhận thoát ứng dụng" , 
                MessageBoxButtons.YesNo);
            if(exitDialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //Do not handle code
            }
        }
        //-----

        
    }
}
