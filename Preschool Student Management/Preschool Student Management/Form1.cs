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

        private void Form1_Load(object sender, EventArgs e)
        {
            //INSERT DATA
            //Utils.insertQuery("INSERT INTO preschool_student_management_db.student(full_name, age, address) VALUES('Nguyen F', 2, 'Quan 6')");

            //SELECT DATA

            List<string> response = Utils.selectQuery("SELECT * FROM student", "full_name");
            foreach (var i in response)
            {
                textBoxTest.Text += i.ToString();
            }

            //DELETE DATA
            //Utils.deleteQuery("DELETE FROM student WHERE id = 8");
        }
    }
}
