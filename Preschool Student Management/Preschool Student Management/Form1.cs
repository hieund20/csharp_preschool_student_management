using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Preschool_Student_Management.Models;

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
        private void loadStudentListToListView()
        {
            var studentList = Student.Query.Get();
            foreach (var student in studentList)
            {
                ListViewItem newItem = listViewStudent.Items.Add(student.GetAttribute("id").ToString());
                newItem.SubItems.Add(student.GetAttribute("first_name").ToString() + " " + student.GetAttribute("last_name").ToString());
                newItem.SubItems.Add(student.GetAttribute("birth_date").ToString());
                newItem.SubItems.Add(student.GetAttribute("classroom_id").ToString());
                newItem.SubItems.Add(student.GetAttribute("parent_first_name").ToString() +" " + student.GetAttribute("parent_last_name").ToString());
                newItem.SubItems.Add(student.GetAttribute("parent_phone_number").ToString());
                newItem.SubItems.Add(student.GetAttribute("address").ToString());
            }
        }

        private void resetStudentTextboxList()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            dateTimePickerDOB.Value = DateTime.Now;
            textBoxClassID.Text = "";
            textBoxParrentFirstName.Text = "";
            textBoxParrentLastName.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
        }

        private void buttonAddStudent_Click_1(object sender, EventArgs e)
        {
            int newId = int.Parse(Student.Query.OrderBy("id", "DESC").First().GetAttribute("id"));
            newId++;
            ListViewItem newItem = listViewStudent.Items.Add(newId.ToString());
            newItem.SubItems.Add(textBoxFirstName.Text + " " + textBoxLastName.Text);
            newItem.SubItems.Add(dateTimePickerDOB.Value.ToShortDateString());
            newItem.SubItems.Add(textBoxClassID.Text);
            newItem.SubItems.Add(textBoxParrentFirstName.Text + " " + textBoxParrentLastName.Text);
            newItem.SubItems.Add(textBoxPhoneNumber.Text);
            newItem.SubItems.Add(textBoxAddress.Text);

            var student = new Student();
            student.SetAttribute("first_name", textBoxFirstName.Text);
            student.SetAttribute("last_name", textBoxLastName.Text);
            student.SetAttribute("birth_date", dateTimePickerDOB.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            student.SetAttribute("parent_first_name", textBoxParrentFirstName.Text);
            student.SetAttribute("parent_last_name", textBoxParrentLastName.Text);
            student.SetAttribute("parent_phone_number", textBoxPhoneNumber.Text);
            student.SetAttribute("address", textBoxAddress.Text);
            student.SetAttribute("classroom_id", textBoxClassID.Text);
            student.SetAttribute("created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            student.SetAttribute("user_id", "1");

            student.Save();
            resetStudentTextboxList();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count > 0) {
                textBoxFirstName.Text = listViewStudent.SelectedItems[0].SubItems[1].Text;
                dateTimePickerDOB.Text = listViewStudent.SelectedItems[0].SubItems[2].Text;
                textBoxClassID.Text = listViewStudent.SelectedItems[0].SubItems[3].Text;
                textBoxParrentFirstName.Text = listViewStudent.SelectedItems[0].SubItems[4].Text;
                textBoxPhoneNumber.Text = listViewStudent.SelectedItems[0].SubItems[5].Text;
                textBoxAddress.Text = listViewStudent.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count > 0)
            {
                listViewStudent.SelectedItems[0].SubItems[1].Text = textBoxFirstName.Text;
                listViewStudent.SelectedItems[0].SubItems[2].Text = dateTimePickerDOB.Value.ToShortDateString();
                listViewStudent.SelectedItems[0].SubItems[3].Text = textBoxClassID.Text;
                listViewStudent.SelectedItems[0].SubItems[4].Text = textBoxParrentFirstName.Text;
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
                //listViewStudent.Items.Remove(listViewStudent.SelectedItems[0]);
                resetStudentTextboxList();

                string idSelected = listViewStudent.SelectedItems[0].SubItems[0].Text;
                Student.Query.Where(Student.Query.KeyName, "=", idSelected).Delete();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng để xóa !", "Thông báo");
            }
        }
        //========================//

        private void Form1_Load(object sender, EventArgs e)
        {
            hideTabHeader();
            loadStudentListToListView();
        }

        private void textBoxFullname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
