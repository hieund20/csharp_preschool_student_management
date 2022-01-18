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
            //Update on UI
            ListViewItem newItem = listViewStudent.Items.Add(newId.ToString());
            newItem.SubItems.Add(textBoxFirstName.Text + " " + textBoxLastName.Text);
            newItem.SubItems.Add(dateTimePickerDOB.Value.ToShortDateString());
            newItem.SubItems.Add(textBoxClassID.Text);
            newItem.SubItems.Add(textBoxParrentFirstName.Text + " " + textBoxParrentLastName.Text);
            newItem.SubItems.Add(textBoxPhoneNumber.Text);
            newItem.SubItems.Add(textBoxAddress.Text);

            //Update under database
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
            //Have 1 error, when click twice to another row
            if (listViewStudent.SelectedItems.Count > 0) {
                try
                {
                    string idSelected = listViewStudent.SelectedItems[0].SubItems[0].Text;
                    Student studentSelected = Student.Query.Where("id", "=", idSelected).First();

                    textBoxFirstName.Text = studentSelected.GetAttribute("first_name");
                    textBoxLastName.Text = studentSelected.GetAttribute("last_name");
                    dateTimePickerDOB.Text = listViewStudent.SelectedItems[0].SubItems[2].Text;
                    textBoxClassID.Text = listViewStudent.SelectedItems[0].SubItems[3].Text;
                    textBoxParrentFirstName.Text = studentSelected.GetAttribute("parent_first_name");
                    textBoxParrentLastName.Text = studentSelected.GetAttribute("parent_last_name");
                    textBoxPhoneNumber.Text = listViewStudent.SelectedItems[0].SubItems[5].Text;
                    textBoxAddress.Text = listViewStudent.SelectedItems[0].SubItems[6].Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }              
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count > 0)
            {
                try
                {
                    string idSelected = listViewStudent.SelectedItems[0].SubItems[0].Text;
                    Student studentSelected = Student.Query.Where("id", "=", idSelected).First();

                    //Update on UI
                    listViewStudent.SelectedItems[0].SubItems[1].Text = textBoxFirstName.Text + " " + textBoxLastName.Text;
                    listViewStudent.SelectedItems[0].SubItems[2].Text = dateTimePickerDOB.Value.ToShortDateString();
                    listViewStudent.SelectedItems[0].SubItems[3].Text = textBoxClassID.Text;
                    listViewStudent.SelectedItems[0].SubItems[4].Text = textBoxParrentFirstName.Text + " " + textBoxParrentLastName.Text;
                    listViewStudent.SelectedItems[0].SubItems[5].Text = textBoxPhoneNumber.Text;
                    listViewStudent.SelectedItems[0].SubItems[6].Text = textBoxAddress.Text;

                    //Update under database
                    studentSelected.SetAttribute("first_name", textBoxFirstName.Text);
                    studentSelected.SetAttribute("last_name", textBoxLastName.Text);
                    studentSelected.SetAttribute("birth_date", dateTimePickerDOB.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    studentSelected.SetAttribute("parent_first_name", textBoxParrentFirstName.Text);
                    studentSelected.SetAttribute("parent_last_name", textBoxParrentLastName.Text);
                    studentSelected.SetAttribute("parent_phone_number", textBoxPhoneNumber.Text);
                    studentSelected.SetAttribute("address", textBoxAddress.Text);
                    studentSelected.SetAttribute("classroom_id", textBoxClassID.Text);
                    studentSelected.SetAttribute("created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    studentSelected.SetAttribute("user_id", "1");
                    studentSelected.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }             
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
                //Update under database
                string idSelected = listViewStudent.SelectedItems[0].SubItems[0].Text;
                Student studentSelected = Student.Query.Where("id", "=", idSelected).First();
                studentSelected.Delete();

                //Update on UI
                listViewStudent.Items.Remove(listViewStudent.SelectedItems[0]);
                resetStudentTextboxList();
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
