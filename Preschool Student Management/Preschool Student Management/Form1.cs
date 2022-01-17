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
        //========================//

        //STUDENT MANAGEMENT TAB
        int studentID = 0; //Mock data
        private void resetStudentTextboxList()
        {
            textBoxFullname.Text = "";
            dateTimePickerDOB.Value = DateTime.Now;
            textBoxClassID.Text = "";
            textBoxParrentName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
        }

        private void buttonAddStudent_Click_1(object sender, EventArgs e)
        {
            studentID++;
            ListViewItem newItem = listViewStudent.Items.Add(studentID.ToString());
            newItem.SubItems.Add(textBoxFullname.Text);
            newItem.SubItems.Add(dateTimePickerDOB.Value.ToShortDateString());
            newItem.SubItems.Add(textBoxClassID.Text);
            newItem.SubItems.Add(textBoxParrentName.Text);
            newItem.SubItems.Add(textBoxPhoneNumber.Text);
            newItem.SubItems.Add(textBoxAddress.Text);

            resetStudentTextboxList();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count > 0) {
                textBoxFullname.Text = listViewStudent.SelectedItems[0].SubItems[1].Text;
                dateTimePickerDOB.Text = listViewStudent.SelectedItems[0].SubItems[2].Text;
                textBoxClassID.Text = listViewStudent.SelectedItems[0].SubItems[3].Text;
                textBoxParrentName.Text = listViewStudent.SelectedItems[0].SubItems[4].Text;
                textBoxPhoneNumber.Text = listViewStudent.SelectedItems[0].SubItems[5].Text;
                textBoxAddress.Text = listViewStudent.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count > 0)
            {
                listViewStudent.SelectedItems[0].SubItems[1].Text = textBoxFullname.Text;
                listViewStudent.SelectedItems[0].SubItems[2].Text = dateTimePickerDOB.Value.ToShortDateString();
                listViewStudent.SelectedItems[0].SubItems[3].Text = textBoxClassID.Text;
                listViewStudent.SelectedItems[0].SubItems[4].Text = textBoxParrentName.Text;
                listViewStudent.SelectedItems[0].SubItems[5].Text = textBoxPhoneNumber.Text;
                listViewStudent.SelectedItems[0].SubItems[6].Text = textBoxAddress.Text;
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng để sửa !", "Thông báo");
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count > 0)
            {
                listViewStudent.Items.Remove(listViewStudent.SelectedItems[0]);
                resetStudentTextboxList();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng để xóa !", "Thông báo");
            }
        }
        //========================//



    }
}
