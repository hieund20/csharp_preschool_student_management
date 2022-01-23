
namespace Preschool_Student_Management
{
	partial class CreateLearningScheduleForm
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
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbSunday = new System.Windows.Forms.CheckBox();
			this.cbSaturday = new System.Windows.Forms.CheckBox();
			this.cbFriday = new System.Windows.Forms.CheckBox();
			this.cbThursday = new System.Windows.Forms.CheckBox();
			this.cbWednesday = new System.Windows.Forms.CheckBox();
			this.cbTuesday = new System.Windows.Forms.CheckBox();
			this.cbMonday = new System.Windows.Forms.CheckBox();
			this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.lblName.Location = new System.Drawing.Point(30, 44);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(57, 25);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Tên:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label1.Location = new System.Drawing.Point(30, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mô tả:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(153, 47);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(709, 22);
			this.txtName.TabIndex = 2;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(153, 108);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(709, 120);
			this.txtDescription.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbSunday);
			this.groupBox1.Controls.Add(this.cbSaturday);
			this.groupBox1.Controls.Add(this.cbFriday);
			this.groupBox1.Controls.Add(this.cbThursday);
			this.groupBox1.Controls.Add(this.cbWednesday);
			this.groupBox1.Controls.Add(this.cbTuesday);
			this.groupBox1.Controls.Add(this.cbMonday);
			this.groupBox1.Location = new System.Drawing.Point(35, 314);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(827, 91);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lặp lại";
			// 
			// cbSunday
			// 
			this.cbSunday.AutoSize = true;
			this.cbSunday.Location = new System.Drawing.Point(724, 38);
			this.cbSunday.Name = "cbSunday";
			this.cbSunday.Size = new System.Drawing.Size(87, 21);
			this.cbSunday.TabIndex = 1;
			this.cbSunday.Text = "Chủ nhật";
			this.cbSunday.UseVisualStyleBackColor = true;
			// 
			// cbSaturday
			// 
			this.cbSaturday.AutoSize = true;
			this.cbSaturday.Location = new System.Drawing.Point(611, 38);
			this.cbSaturday.Name = "cbSaturday";
			this.cbSaturday.Size = new System.Drawing.Size(82, 21);
			this.cbSaturday.TabIndex = 1;
			this.cbSaturday.Text = "Thứ bảy";
			this.cbSaturday.UseVisualStyleBackColor = true;
			// 
			// cbFriday
			// 
			this.cbFriday.AutoSize = true;
			this.cbFriday.Location = new System.Drawing.Point(490, 38);
			this.cbFriday.Name = "cbFriday";
			this.cbFriday.Size = new System.Drawing.Size(82, 21);
			this.cbFriday.TabIndex = 1;
			this.cbFriday.Text = "Thứ sáu";
			this.cbFriday.UseVisualStyleBackColor = true;
			// 
			// cbThursday
			// 
			this.cbThursday.AutoSize = true;
			this.cbThursday.Location = new System.Drawing.Point(366, 38);
			this.cbThursday.Name = "cbThursday";
			this.cbThursday.Size = new System.Drawing.Size(86, 21);
			this.cbThursday.TabIndex = 1;
			this.cbThursday.Text = "Thứ năm";
			this.cbThursday.UseVisualStyleBackColor = true;
			// 
			// cbWednesday
			// 
			this.cbWednesday.AutoSize = true;
			this.cbWednesday.Location = new System.Drawing.Point(252, 38);
			this.cbWednesday.Name = "cbWednesday";
			this.cbWednesday.Size = new System.Drawing.Size(71, 21);
			this.cbWednesday.TabIndex = 1;
			this.cbWednesday.Text = "Thứ tư";
			this.cbWednesday.UseVisualStyleBackColor = true;
			// 
			// cbTuesday
			// 
			this.cbTuesday.AutoSize = true;
			this.cbTuesday.Location = new System.Drawing.Point(136, 38);
			this.cbTuesday.Name = "cbTuesday";
			this.cbTuesday.Size = new System.Drawing.Size(75, 21);
			this.cbTuesday.TabIndex = 1;
			this.cbTuesday.Text = "Thứ ba";
			this.cbTuesday.UseVisualStyleBackColor = true;
			// 
			// cbMonday
			// 
			this.cbMonday.AutoSize = true;
			this.cbMonday.Location = new System.Drawing.Point(35, 38);
			this.cbMonday.Name = "cbMonday";
			this.cbMonday.Size = new System.Drawing.Size(78, 21);
			this.cbMonday.TabIndex = 0;
			this.cbMonday.Text = "Thứ hai";
			this.cbMonday.UseVisualStyleBackColor = true;
			// 
			// dtpDateFrom
			// 
			this.dtpDateFrom.Location = new System.Drawing.Point(81, 442);
			this.dtpDateFrom.Name = "dtpDateFrom";
			this.dtpDateFrom.Size = new System.Drawing.Size(321, 22);
			this.dtpDateFrom.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label2.Location = new System.Drawing.Point(30, 439);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Từ:";
			// 
			// dtpDateTo
			// 
			this.dtpDateTo.Location = new System.Drawing.Point(556, 442);
			this.dtpDateTo.Name = "dtpDateTo";
			this.dtpDateTo.Size = new System.Drawing.Size(305, 22);
			this.dtpDateTo.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label3.Location = new System.Drawing.Point(492, 440);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Đến:";
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.btnCreate.Location = new System.Drawing.Point(730, 493);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(132, 42);
			this.btnCreate.TabIndex = 7;
			this.btnCreate.Text = "Tạo";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.Red;
			this.btnClose.Location = new System.Drawing.Point(592, 493);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 42);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Huỷ";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label4.Location = new System.Drawing.Point(30, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "Khung giờ:";
			// 
			// dtpTimeFrom
			// 
			this.dtpTimeFrom.AllowDrop = true;
			this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeFrom.Location = new System.Drawing.Point(153, 257);
			this.dtpTimeFrom.Name = "dtpTimeFrom";
			this.dtpTimeFrom.Size = new System.Drawing.Size(334, 22);
			this.dtpTimeFrom.TabIndex = 10;
			// 
			// dtpTimeTo
			// 
			this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeTo.Location = new System.Drawing.Point(525, 257);
			this.dtpTimeTo.Name = "dtpTimeTo";
			this.dtpTimeTo.Size = new System.Drawing.Size(337, 22);
			this.dtpTimeTo.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label5.Location = new System.Drawing.Point(499, 254);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 25);
			this.label5.TabIndex = 12;
			this.label5.Text = "-";
			// 
			// CreateLearningScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 561);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpTimeTo);
			this.Controls.Add(this.dtpTimeFrom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpDateTo);
			this.Controls.Add(this.dtpDateFrom);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblName);
			this.Name = "CreateLearningScheduleForm";
			this.Text = "Create Leaning Schedule";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbSunday;
		private System.Windows.Forms.CheckBox cbSaturday;
		private System.Windows.Forms.CheckBox cbFriday;
		private System.Windows.Forms.CheckBox cbThursday;
		private System.Windows.Forms.CheckBox cbWednesday;
		private System.Windows.Forms.CheckBox cbTuesday;
		private System.Windows.Forms.CheckBox cbMonday;
		private System.Windows.Forms.DateTimePicker dtpDateFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpDateTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpTimeFrom;
		private System.Windows.Forms.DateTimePicker dtpTimeTo;
		private System.Windows.Forms.Label label5;
	}
}