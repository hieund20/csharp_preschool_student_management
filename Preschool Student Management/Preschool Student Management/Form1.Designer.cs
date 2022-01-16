namespace Preschool_Student_Management
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Nguyễn A",
            "12/08/2008",
            "MAM1",
            "Nguyễn Văn A",
            "0123456789",
            "Quận Tân Bình"}, -1);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelLogoBrand = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTabClass = new System.Windows.Forms.Button();
            this.buttonTabVacxin = new System.Windows.Forms.Button();
            this.buttonTabTimeTable = new System.Windows.Forms.Button();
            this.buttonTabStudent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStudentPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTimePage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabVacxinPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabClassPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabStudentPage.SuspendLayout();
            this.tabTimePage.SuspendLayout();
            this.tabVacxinPage.SuspendLayout();
            this.tabClassPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panelLogoBrand);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonTabClass);
            this.panel1.Controls.Add(this.buttonTabVacxin);
            this.panel1.Controls.Add(this.buttonTabTimeTable);
            this.panel1.Controls.Add(this.buttonTabStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 681);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "PHẦN MỀM QUẢN LÝ\r\nHỌC SINH MẦM NON\r\n\r\n";
            // 
            // panelLogoBrand
            // 
            this.panelLogoBrand.BackColor = System.Drawing.Color.White;
            this.panelLogoBrand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoBrand.BackgroundImage")));
            this.panelLogoBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogoBrand.Location = new System.Drawing.Point(19, 23);
            this.panelLogoBrand.Name = "panelLogoBrand";
            this.panelLogoBrand.Size = new System.Drawing.Size(65, 64);
            this.panelLogoBrand.TabIndex = 7;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(12, 635);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTabClass
            // 
            this.buttonTabClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
            this.buttonTabClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabClass.FlatAppearance.BorderSize = 0;
            this.buttonTabClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabClass.ForeColor = System.Drawing.Color.White;
            this.buttonTabClass.Image = ((System.Drawing.Image)(resources.GetObject("buttonTabClass.Image")));
            this.buttonTabClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabClass.Location = new System.Drawing.Point(12, 403);
            this.buttonTabClass.Name = "buttonTabClass";
            this.buttonTabClass.Size = new System.Drawing.Size(248, 65);
            this.buttonTabClass.TabIndex = 5;
            this.buttonTabClass.Text = "QUẢN LÝ LỚP HỌC";
            this.buttonTabClass.UseVisualStyleBackColor = false;
            this.buttonTabClass.Click += new System.EventHandler(this.buttonTabClass_Click);
            // 
            // buttonTabVacxin
            // 
            this.buttonTabVacxin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
            this.buttonTabVacxin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabVacxin.FlatAppearance.BorderSize = 0;
            this.buttonTabVacxin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabVacxin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabVacxin.ForeColor = System.Drawing.Color.White;
            this.buttonTabVacxin.Image = ((System.Drawing.Image)(resources.GetObject("buttonTabVacxin.Image")));
            this.buttonTabVacxin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabVacxin.Location = new System.Drawing.Point(12, 332);
            this.buttonTabVacxin.Name = "buttonTabVacxin";
            this.buttonTabVacxin.Size = new System.Drawing.Size(248, 65);
            this.buttonTabVacxin.TabIndex = 4;
            this.buttonTabVacxin.Text = "QUẢN LÝ TT TIÊM CHỦNG";
            this.buttonTabVacxin.UseVisualStyleBackColor = false;
            this.buttonTabVacxin.Click += new System.EventHandler(this.buttonTabVacxin_Click);
            // 
            // buttonTabTimeTable
            // 
            this.buttonTabTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
            this.buttonTabTimeTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabTimeTable.FlatAppearance.BorderSize = 0;
            this.buttonTabTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabTimeTable.ForeColor = System.Drawing.Color.White;
            this.buttonTabTimeTable.Image = ((System.Drawing.Image)(resources.GetObject("buttonTabTimeTable.Image")));
            this.buttonTabTimeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabTimeTable.Location = new System.Drawing.Point(12, 261);
            this.buttonTabTimeTable.Name = "buttonTabTimeTable";
            this.buttonTabTimeTable.Size = new System.Drawing.Size(245, 65);
            this.buttonTabTimeTable.TabIndex = 3;
            this.buttonTabTimeTable.Text = "QUẢN LÝ THỜI GIAN BIỂU";
            this.buttonTabTimeTable.UseVisualStyleBackColor = false;
            this.buttonTabTimeTable.Click += new System.EventHandler(this.buttonTabTimeTable_Click);
            // 
            // buttonTabStudent
            // 
            this.buttonTabStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
            this.buttonTabStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabStudent.FlatAppearance.BorderSize = 0;
            this.buttonTabStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabStudent.ForeColor = System.Drawing.Color.White;
            this.buttonTabStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonTabStudent.Image")));
            this.buttonTabStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabStudent.Location = new System.Drawing.Point(12, 190);
            this.buttonTabStudent.Name = "buttonTabStudent";
            this.buttonTabStudent.Size = new System.Drawing.Size(248, 65);
            this.buttonTabStudent.TabIndex = 2;
            this.buttonTabStudent.Text = "QUẢN LÝ HỌC SINH";
            this.buttonTabStudent.UseVisualStyleBackColor = false;
            this.buttonTabStudent.Click += new System.EventHandler(this.buttonTabStudent_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.avatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(269, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 74);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(807, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giáo viên Ngọc Nữ";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Black;
            this.avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avatar.BackgroundImage")));
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Location = new System.Drawing.Point(931, 18);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(40, 40);
            this.avatar.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(269, 648);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 33);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "© 2022 - NDH - LVD - HVH - HLBD";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudentPage);
            this.tabControl.Controls.Add(this.tabTimePage);
            this.tabControl.Controls.Add(this.tabVacxinPage);
            this.tabControl.Controls.Add(this.tabClassPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(269, 74);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(995, 574);
            this.tabControl.TabIndex = 3;
            // 
            // tabStudentPage
            // 
            this.tabStudentPage.BackColor = System.Drawing.Color.White;
            this.tabStudentPage.Controls.Add(this.buttonAddStudent);
            this.tabStudentPage.Controls.Add(this.listView1);
            this.tabStudentPage.Controls.Add(this.label2);
            this.tabStudentPage.Location = new System.Drawing.Point(4, 22);
            this.tabStudentPage.Name = "tabStudentPage";
            this.tabStudentPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentPage.Size = new System.Drawing.Size(987, 548);
            this.tabStudentPage.TabIndex = 0;
            this.tabStudentPage.Text = "tabPage1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "QUẢN LÝ HỌC SINH";
            // 
            // tabTimePage
            // 
            this.tabTimePage.BackColor = System.Drawing.Color.White;
            this.tabTimePage.Controls.Add(this.label3);
            this.tabTimePage.Location = new System.Drawing.Point(4, 22);
            this.tabTimePage.Name = "tabTimePage";
            this.tabTimePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimePage.Size = new System.Drawing.Size(987, 548);
            this.tabTimePage.TabIndex = 1;
            this.tabTimePage.Text = "tabPage2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ THỜI GIAN BIỂU";
            // 
            // tabVacxinPage
            // 
            this.tabVacxinPage.BackColor = System.Drawing.Color.White;
            this.tabVacxinPage.Controls.Add(this.label4);
            this.tabVacxinPage.Location = new System.Drawing.Point(4, 22);
            this.tabVacxinPage.Name = "tabVacxinPage";
            this.tabVacxinPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabVacxinPage.Size = new System.Drawing.Size(987, 548);
            this.tabVacxinPage.TabIndex = 2;
            this.tabVacxinPage.Text = "tabPage3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "QUẢN LÝ THÔNG TIN TIÊM CHỦNG";
            // 
            // tabClassPage
            // 
            this.tabClassPage.BackColor = System.Drawing.Color.White;
            this.tabClassPage.Controls.Add(this.label5);
            this.tabClassPage.Location = new System.Drawing.Point(4, 22);
            this.tabClassPage.Name = "tabClassPage";
            this.tabClassPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassPage.Size = new System.Drawing.Size(987, 548);
            this.tabClassPage.TabIndex = 3;
            this.tabClassPage.Text = "tabPage4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(26, 132);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(941, 240);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học sinh";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã lớp";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Họ tên phụ huynh";
            this.columnHeader5.Width = 169;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Địa chỉ";
            this.columnHeader7.Width = 158;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddStudent.Location = new System.Drawing.Point(849, 81);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(118, 36);
            this.buttonAddStudent.TabIndex = 2;
            this.buttonAddStudent.Text = "Thêm học sinh";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabStudentPage.ResumeLayout(false);
            this.tabStudentPage.PerformLayout();
            this.tabTimePage.ResumeLayout(false);
            this.tabTimePage.PerformLayout();
            this.tabVacxinPage.ResumeLayout(false);
            this.tabVacxinPage.PerformLayout();
            this.tabClassPage.ResumeLayout(false);
            this.tabClassPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTabClass;
        private System.Windows.Forms.Button buttonTabVacxin;
        private System.Windows.Forms.Button buttonTabTimeTable;
        private System.Windows.Forms.Button buttonTabStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudentPage;
        private System.Windows.Forms.TabPage tabTimePage;
        private System.Windows.Forms.TabPage tabVacxinPage;
        private System.Windows.Forms.TabPage tabClassPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelLogoBrand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel avatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonAddStudent;
    }
}

