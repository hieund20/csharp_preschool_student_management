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

        //Student Management Screen Tab
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //Row 1
            //Col 1
            Label firtNameLabel = new Label()
            {
                Text = "Họ",
                Location = new Point(20, 50),
            };
            TextBox firtNameTextBox = new TextBox()
            {
                Size = new Size(250, 50),
                Location = new Point(20, 75),
            };
            //Col 2
            Label lastNameLabel = new Label()
            {
                Text = "Tên",
                Location = new Point(300, 50),
            };
            TextBox lastNameTextBox = new TextBox()
            {
                Size = new Size(250, 50),
                Location = new Point(300, 75),
            };
            //Row 2
            //Col 1
            Label dobLabel = new Label()
            {
                Text = "Ngày sinh",
                Location = new Point(20, 115),
            };
            TextBox dobTextBox = new TextBox()
            {
                Size = new Size(250, 50),
                Location = new Point(20, 140),
            };
            //Col 2
            Label phoneNumberLabel = new Label()
            {
                Text = "Số điện thoại",
                Location = new Point(300, 115),
            };
            TextBox phoneNumberTextBox = new TextBox()
            {
                Size = new Size(250, 50),
                Location = new Point(300, 140),
            };
            //Row 3
            //Col 1
            Label classIDLabel = new Label()
            {
                Text = "Mã lớp",
                Location = new Point(20, 185),
            };
            TextBox classIDTextBox = new TextBox()
            {
                Size = new Size(250, 50),
                Location = new Point(20, 210),
            };
            //Col 2
            Label addressLabel = new Label()
            {
                Text = "Địa chỉ",
                Location = new Point(300, 185),
            };
            TextBox addressTextBox = new TextBox()
            {
                Size = new Size(250, 50),
                Location = new Point(300, 210),
            };
            //Row 4
            //Col 1
            Label parrentNameLabel = new Label()
            {
                Text = "Họ tên phụ huynh",
                Location = new Point(20, 255),
            };
            TextBox parrentNameTextBox = new TextBox()
            {
                Size = new Size(250, 50),
                Location = new Point(20, 280),
            };

            Button addNewButton = new Button()
            {
                Text = "Thêm",
                Size = new Size(90, 40),
                Location = new Point(350, 350),
                BackColor = Color.FromArgb(29, 85, 159),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
            };
            Button cancelButton = new Button()
            {
                Text = "Hủy bỏ",
                Size = new Size(90, 40),
                Location = new Point(461, 350),
                BackColor = Color.FromArgb(29, 85, 159),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
            };
            Form addStudentForm = new Form()
            {
                Size = new Size(600, 450),
                StartPosition = FormStartPosition.CenterScreen,
                Text = "Thêm thông tin học sinh",
                BackColor = Color.White,
            };


            addStudentForm.Controls.Add(firtNameLabel);
            addStudentForm.Controls.Add(firtNameTextBox);
            addStudentForm.Controls.Add(lastNameLabel);
            addStudentForm.Controls.Add(lastNameTextBox);

            addStudentForm.Controls.Add(dobLabel);
            addStudentForm.Controls.Add(dobTextBox);
            addStudentForm.Controls.Add(phoneNumberLabel);
            addStudentForm.Controls.Add(phoneNumberTextBox);

            addStudentForm.Controls.Add(classIDLabel);
            addStudentForm.Controls.Add(classIDTextBox);
            addStudentForm.Controls.Add(addressLabel);
            addStudentForm.Controls.Add(addressTextBox);

            addStudentForm.Controls.Add(parrentNameLabel);
            addStudentForm.Controls.Add(parrentNameTextBox);

            addStudentForm.Controls.Add(addNewButton);
            addStudentForm.Controls.Add(cancelButton);

            addStudentForm.Show();
        }
        //-----



    }
}
