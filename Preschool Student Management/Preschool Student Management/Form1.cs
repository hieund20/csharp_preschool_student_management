using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        //DASHBOARD
        private void buttonTabStudent_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabStudentPage;
        }

        private void buttonTabClass_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabClassPage;
        }

        private void buttonTabUser_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabUser;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var exitDialog = MessageBox.Show(
               "Bạn có chắc muốn thoát?",
               "Xác nhận thoát ứng dụng",
               MessageBoxButtons.YesNo);
            if (exitDialog == DialogResult.Yes)
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
            var studentList = Student.Query.WithClosestScheduel().Get();
            foreach (var student in studentList)
            {
                ListViewItem newItem = listViewStudent.Items.Add(student.GetAttribute("id").ToString());
                newItem.SubItems.Add(student.GetAttribute("first_name").ToString());
                newItem.SubItems.Add(student.GetAttribute("last_name").ToString());
                string birthDateFormat = DateTime.Parse(student.GetAttribute("birth_date")).ToString("yyyy-MM-dd");
                newItem.SubItems.Add(birthDateFormat);
                newItem.SubItems.Add(student.GetAttribute("classroom_id").ToString());
                newItem.SubItems.Add(student.GetAttribute("parent_first_name").ToString());
                newItem.SubItems.Add(student.GetAttribute("parent_last_name").ToString());
                newItem.SubItems.Add(student.GetAttribute("parent_phone_number").ToString());
                newItem.SubItems.Add(student.GetAttribute("address").ToString());
                if (student.ClosestScheduel == null)
                {
                    newItem.SubItems.Add("Không có sự kiện nào sắp diễn ra");
                    newItem.SubItems.Add("Chưa xác định");
                    newItem.SubItems.Add("Chưa xác định");
                }
                else
                {
                    newItem.SubItems.Add(student.ClosestScheduel.GetAttribute("name"));
                    newItem.SubItems.Add(student.ClosestScheduel.StartedAt.ToString());
                    newItem.SubItems.Add(student.ClosestScheduel.EndedAt.ToString());
                }
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
            if (textBoxFirstName.Text == "" || 
                textBoxLastName.Text == "" || 
                textBoxClassID.Text == "" || 
                textBoxParrentFirstName.Text == "" || 
                textBoxParrentLastName.Text == "" ||
                textBoxPhoneNumber.Text == "" ||
                textBoxAddress.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ các trường dữ liệu !", "Thông báo");
            }
            else
            {
                int newId = int.Parse(Student.Query.OrderBy("id", "DESC").First().GetAttribute("id"));
                newId++;
                //Update on UI
                ListViewItem newItem = listViewStudent.Items.Add(newId.ToString());
                newItem.SubItems.Add(textBoxFirstName.Text);
                newItem.SubItems.Add(textBoxLastName.Text);
                newItem.SubItems.Add(dateTimePickerDOB.Value.ToShortDateString());
                newItem.SubItems.Add(textBoxClassID.Text);
                newItem.SubItems.Add(textBoxParrentFirstName.Text);
                newItem.SubItems.Add(textBoxParrentLastName.Text);
                newItem.SubItems.Add(textBoxPhoneNumber.Text);
                newItem.SubItems.Add(textBoxAddress.Text);

                //Update under database
                var student = new Student();
                student.SetAttribute("first_name", textBoxFirstName.Text);
                student.SetAttribute("last_name", textBoxLastName.Text);
                student.SetAttribute("birth_date", dateTimePickerDOB.Value.ToString("yyyy-MM-dd"));
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
        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count <= 0) {
                return;
            }
            else
            {
                try
                {
                    
                    textBoxFirstName.Text = listViewStudent.SelectedItems[0].SubItems[1].Text;
                    textBoxLastName.Text = listViewStudent.SelectedItems[0].SubItems[2].Text;
                    dateTimePickerDOB.Text = listViewStudent.SelectedItems[0].SubItems[3].Text;
                    textBoxClassID.Text = listViewStudent.SelectedItems[0].SubItems[4].Text;
                    textBoxParrentFirstName.Text = listViewStudent.SelectedItems[0].SubItems[5].Text;
                    textBoxParrentLastName.Text = listViewStudent.SelectedItems[0].SubItems[6].Text;
                    textBoxPhoneNumber.Text = listViewStudent.SelectedItems[0].SubItems[7].Text;
                    textBoxAddress.Text = listViewStudent.SelectedItems[0].SubItems[8].Text;
                }
                catch (Exception ex)
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
                    Student studentSelected = Student.Query.WithClassroom().WithUser().Where("id", "=", idSelected).First();

                    //Update on UI
                    listViewStudent.SelectedItems[0].SubItems[1].Text = textBoxFirstName.Text;
                    listViewStudent.SelectedItems[0].SubItems[2].Text = textBoxLastName.Text;
                    listViewStudent.SelectedItems[0].SubItems[3].Text = dateTimePickerDOB.Value.ToShortDateString();
                    listViewStudent.SelectedItems[0].SubItems[4].Text = textBoxClassID.Text;
                    listViewStudent.SelectedItems[0].SubItems[5].Text = textBoxParrentFirstName.Text;
                    listViewStudent.SelectedItems[0].SubItems[6].Text = textBoxParrentLastName.Text;
                    listViewStudent.SelectedItems[0].SubItems[7].Text = textBoxPhoneNumber.Text;
                    listViewStudent.SelectedItems[0].SubItems[8].Text = textBoxAddress.Text;

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
                var confirmDialog = MessageBox.Show(
                "Bạn có chắc muốn xóa dòng này?",
                "Xác nhận xóa thông tin",
                MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
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
                    //Do not handle code
                }           
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng để xóa !", "Thông báo");
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchQuery = textBoxSearch.Text;

                if (searchQuery != "")
                {
                    var studentQueryBuilder = Student.Query.WithUser().WithClassroom().Where("last_name", "=", searchQuery);
                    List<Student> studentListResult = studentQueryBuilder.Get();
                    listViewStudent.Items.Clear();
                    foreach (var student in studentListResult)
                    {
                        ListViewItem newItem = listViewStudent.Items.Add(student.GetAttribute("id").ToString());
                        newItem.SubItems.Add(student.GetAttribute("first_name").ToString());
                        newItem.SubItems.Add(student.GetAttribute("last_name").ToString());
                        string birthDateFormat = DateTime.Parse(student.GetAttribute("birth_date")).ToString("yyyy-MM-dd");
                        newItem.SubItems.Add(birthDateFormat);
                        newItem.SubItems.Add(student.GetAttribute("classroom_id").ToString());
                        newItem.SubItems.Add(student.GetAttribute("parent_first_name").ToString());
                        newItem.SubItems.Add(student.GetAttribute("parent_last_name").ToString());
                        newItem.SubItems.Add(student.GetAttribute("parent_phone_number").ToString());
                        newItem.SubItems.Add(student.GetAttribute("address").ToString());
                    }
                }
                else
                {
                    listViewStudent.Items.Clear();
                    loadStudentListToListView();
                }             
                textBoxSearch.Text = "";
            }
        }

        private void buttonShowNearEvent_Click(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                try
                {
                    string idSelected = listViewStudent.SelectedItems[0].SubItems[0].Text;
                    var scheduleForm = new ScheduleForm(Student.Query.Find(idSelected));
                    scheduleForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }               
            }
        }

        //========================//

        //USER MANAGEMENT TAB
        private void loadUsertListToListView()
        {
            var userList = User.Query.Get();
            foreach (var user in userList)
            {
                ListViewItem newItem = listView1.Items.Add(user.GetAttribute("id").ToString());
                newItem.SubItems.Add(user.GetAttribute("name").ToString());
                newItem.SubItems.Add(user.GetAttribute("username").ToString());              
                newItem.SubItems.Add(user.GetAttribute("email").ToString());

                
                newItem.SubItems.Add((user.GetAttribute("password".ToString())));
                string role = user.GetAttribute("role").ToString();
                if (role == "1")
                {
                    newItem.SubItems.Add("admin");
                }
                else
                    newItem.SubItems.Add("Giáo viên");
                string format = "yyyy-MM-dd HH:mm:ss";
                string created = DateTime.Parse(user.GetAttribute("created_at")).ToString(format);              
                newItem.SubItems.Add(created);

            }
        }

        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                {
                    addUserbtn.Enabled = false;
                    editUserbtn.Enabled = true;
                    removeUserbtn.Enabled = true;
                    try
                    {

                        nametxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
                        usernametxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
                        emailtxt.Text = listView1.SelectedItems[0].SubItems[3].Text;
                        passtxt.Text = listView1.SelectedItems[0].SubItems[4].Text;
                        string role = listView1.SelectedItems[0].SubItems[5].Text;
                        if (role == "admin")
                        {
                            radioButton1.Checked = true;
                        }
                        else if (role == "Giáo viên")
                            radioButton2.Checked = true;
                        createdtime.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[6].Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                }
            }
            else
            {
                resetUserTextboxList();
                editUserbtn.Enabled = false;
                addUserbtn.Enabled = true;
                removeUserbtn.Enabled = false;
            }
            
        }

        private void resetUserTextboxList()
        {
            nametxt.Text = "";
            usernametxt.Text = "";
            createdtime.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            passtxt.Text = "";
            emailtxt.Text = "";
        }

        private void addUserbtn_Click(object sender, EventArgs e)
        {
            if (nametxt.Text == "" ||
            usernametxt.Text == "" ||
            emailtxt.Text == "" ||
            passtxt.Text == "" ||
            (radioButton1.Checked == false && radioButton2.Checked == false)       
            )
            {
                MessageBox.Show("Bạn phải nhập đủ các trường dữ liệu !", "Thông báo");
            }
            else
            {
               
                //Update under database
                var user = new User();
                user.SetAttribute("name", nametxt.Text);
                user.SetAttribute("username", usernametxt.Text);
                user.SetAttribute("email", emailtxt.Text);
                user.SetAttribute("password", hasspass(passtxt.Text));
                if (radioButton1.Checked == true)
                {
                    user.SetAttribute("role", "1");
                }
                else if (radioButton2.Checked == true)
                { user.SetAttribute("role", "2"); }             
                user.SetAttribute("created_at", createdtime.Value.ToString("yyyy-MM-dd  HH:mm:ss"));
                user.Save();
                // load listview
                updateUserList();
                resetUserTextboxList();
            }
        }

        private void editUserbtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    string idSelected = listView1.SelectedItems[0].SubItems[0].Text;
                    User user = User.Query.Where("id", "=", idSelected).First();
                    //Update under database
                    user.SetAttribute("name", nametxt.Text);
                    user.SetAttribute("username", usernametxt.Text);
                    user.SetAttribute("email",emailtxt.Text);
                    if(user.GetAttribute("password").CompareTo(passtxt.Text) == 0)
                    {
                        user.SetAttribute("password", passtxt.Text);
                    }
                    else
                    {
                        user.SetAttribute("password", hasspass(passtxt.Text));
                    }
                    
                    if (radioButton1.Checked == true)
                    {
                        user.SetAttribute("role", "1");
                    }
                    else if (radioButton2.Checked == true)
                    { user.SetAttribute("role", "2"); }
                    user.SetAttribute("created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    user.Save();
                    resetUserTextboxList();
                    updateUserList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            
        }
       
        private void removeUserbtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var confirmDialog = MessageBox.Show(
                "Bạn có chắc muốn xóa dòng này?",
                "Xác nhận xóa thông tin",
                MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    //Update under database
                    string idSelected = listView1.SelectedItems[0].SubItems[0].Text;
                    User user = User.Query.Where("id", "=", idSelected).First();
                    user.Delete();

                    //Update on UI
                 
                    resetUserTextboxList();
                    updateUserList();
                    addUserbtn.Enabled = true;
                    editUserbtn.Enabled = false;
                    removeUserbtn.Enabled = false;
                }
                else
                {
                    //Do not handle code
                }
            }
            
        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (searchtxt.Text == "")
                {
                    updateUserList();
                }
                else { 
                    var userQuery = User.Query.Where("name", "=", searchtxt.Text);
                    List<User> userListResult = userQuery.Get();
                    listView1.Items.Clear();
                    foreach (var user in userListResult)
                    {

                        ListViewItem newItem = listView1.Items.Add(user.GetAttribute("id").ToString());
                        newItem.SubItems.Add(user.GetAttribute("name").ToString());
                        newItem.SubItems.Add(user.GetAttribute("username").ToString());
                        newItem.SubItems.Add(user.GetAttribute("email").ToString());
                        newItem.SubItems.Add(user.GetAttribute("password").ToString());
                        string role = user.GetAttribute("role").ToString();
                        if (role == "1")
                        {
                            newItem.SubItems.Add("admin");
                        }
                        else
                            newItem.SubItems.Add("Giáo viên");
                        string format = "yyyy-MM-dd HH:mm:ss";
                        string created = DateTime.Parse(user.GetAttribute("created_at")).ToString(format);
                        newItem.SubItems.Add(created);
                    }
                    searchtxt.Text = "";
                   }

        }
            
        }

        private void updateUserList()
        {
            listView1.Items.Clear();
            loadUsertListToListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateUserList();
        }

        private string hasspass(string a)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(a);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        //========================//

        //CLASS MANAGEMENT TAB
        private void resetClassTextboxList()
        {
            textBoxShortClassName.Text = "";
            textBoxClassName.Text = "";
            dateTimePickerClass.Value = DateTime.Now;
        }

        private void loadClassListToListView()
        {
            try
            {
                var classQueryBuilder = Classroom.Query.WithClosestScheduel();
                List<Classroom> classListResult = classQueryBuilder.Get();

                foreach (var singleClass in classListResult)
                {
                    ListViewItem newItem = listViewClass.Items.Add(singleClass.GetAttribute("id").ToString());
                    newItem.SubItems.Add(singleClass.GetAttribute("code").ToString());
                    newItem.SubItems.Add(singleClass.GetAttribute("name").ToString());
                    string createdDateFormat = DateTime.Parse(singleClass.GetAttribute("created_at")).ToString("yyyy-MM-dd");
                    newItem.SubItems.Add(createdDateFormat);
                    if (singleClass.ClosestScheduel == null)
                    {
                        newItem.SubItems.Add("Không có sự kiện nào sắp diễn ra");
                        newItem.SubItems.Add("Chưa xác định");
                        newItem.SubItems.Add("Chưa xác định");
                    }
                    else
                    {
                        newItem.SubItems.Add(singleClass.ClosestScheduel.GetAttribute("name"));
                        newItem.SubItems.Add(singleClass.ClosestScheduel.StartedAt.ToString());
                        newItem.SubItems.Add(singleClass.ClosestScheduel.EndedAt.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }          
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxShortClassName.Text == "" ||
                    textBoxClassName.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ các trường dữ liệu !", "Thông báo");
                }
                else
                {
                    int newId = int.Parse(Classroom.Query.OrderBy("id", "DESC").First().GetAttribute("id"));
                    newId++;
                    //Update on UI
                    ListViewItem newItem = listViewClass.Items.Add(newId.ToString());
                    newItem.SubItems.Add(textBoxShortClassName.Text);
                    newItem.SubItems.Add(textBoxClassName.Text);
                    newItem.SubItems.Add(dateTimePickerClass.Value.ToShortDateString());

                    //Update under database
                    var classroom = new Classroom();
                    classroom.SetAttribute("code", textBoxShortClassName.Text);
                    classroom.SetAttribute("name", textBoxClassName.Text);
                    classroom.SetAttribute("created_at", dateTimePickerDOB.Value.ToString("yyyy-MM-dd"));
                    classroom.SetAttribute("user_id", "1");
                    classroom.Save();

                    resetClassTextboxList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void listViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                try
                {
                    textBoxShortClassName.Text = listViewClass.SelectedItems[0].SubItems[1].Text;
                    textBoxClassName.Text = listViewClass.SelectedItems[0].SubItems[2].Text;
                    dateTimePickerClass.Text = listViewClass.SelectedItems[0].SubItems[3].Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void buttonEditClass_Click(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count > 0)
            {
                try
                {
                    string idSelected = listViewClass.SelectedItems[0].SubItems[0].Text;
                    Classroom classSelected = Classroom.Query.Where("id", "=", idSelected).First();

                    //Update on UI
                    listViewClass.SelectedItems[0].SubItems[1].Text = textBoxShortClassName.Text;
                    listViewClass.SelectedItems[0].SubItems[2].Text = textBoxClassName.Text;
                    listViewClass.SelectedItems[0].SubItems[3].Text = dateTimePickerClass.Value.ToShortDateString();

                    //Update under database
                    classSelected.SetAttribute("code", textBoxShortClassName.Text);
                    classSelected.SetAttribute("name", textBoxClassName.Text);
                    classSelected.SetAttribute("created_at", dateTimePickerClass.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    classSelected.SetAttribute("user_id", "1");
                    classSelected.Save();
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

        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count > 0)
            {
                var confirmDialog = MessageBox.Show(
                "Bạn có chắc muốn xóa dòng này?",
                "Xác nhận xóa thông tin",
                MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    //Update under database
                    string idSelected = listViewClass.SelectedItems[0].SubItems[0].Text;
                    Classroom classSelected = Classroom.Query.Where("id", "=", idSelected).First();
                    classSelected.Delete();

                    //Update on UI
                    listViewClass.Items.Remove(listViewClass.SelectedItems[0]);
                    resetClassTextboxList();
                }
                else
                {
                    //Do not handle code
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 dòng để xóa !", "Thông báo");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                string searchQuery = textBoxClassSearch.Text;
                if(searchQuery != "")
                {
                    var classQueryBuilder = Classroom.Query.Where("code", "=", searchQuery);
                    List<Classroom> classListResult = classQueryBuilder.Get();
                    listViewClass.Items.Clear();
                    foreach (var singleClass in classListResult)
                    {
                        ListViewItem newItem = listViewClass.Items.Add(singleClass.GetAttribute("id").ToString());
                        newItem.SubItems.Add(singleClass.GetAttribute("code").ToString());
                        newItem.SubItems.Add(singleClass.GetAttribute("name").ToString());
                        string createdDateFormat = DateTime.Parse(singleClass.GetAttribute("created_at")).ToString("yyyy-MM-dd");
                        newItem.SubItems.Add(createdDateFormat);
                    }
                }
                else
                {
                    listViewClass.Items.Clear();
                    loadClassListToListView();
                }
                textBoxClassSearch.Text = "";
            }
        }

        private void buttonShowClassEvent_Click(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                try
                {
                    string idSelected = listViewClass.SelectedItems[0].SubItems[0].Text;
                    var scheduleForm = new ScheduleForm(Classroom.Query.Find(idSelected));
                    scheduleForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        //========================//

        private void Form1_Load(object sender, EventArgs e)
        {
            hideTabHeader();
            loadStudentListToListView();
            loadUsertListToListView();
            loadClassListToListView();
        }

       
    }

}
