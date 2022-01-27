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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox_EmailDangKi.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng kí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                var mail = User.Query.Where("email", "=", email).First();
                if (mail == null) { MessageBox.Show("Email chưa được đăng kí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    MessageBox.Show( "Mật khẩu của bạn là: " + Utils.Decrypt(mail.GetAttribute("password")),  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }

            }
        }
       

    }
}
