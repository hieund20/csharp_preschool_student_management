
namespace Preschool_Student_Management
{
	partial class CreateVaccineSchedule
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
			this.label5 = new System.Windows.Forms.Label();
			this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
			this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label5.Location = new System.Drawing.Point(498, 259);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 25);
			this.label5.TabIndex = 27;
			this.label5.Text = "-";
			// 
			// dtpTimeTo
			// 
			this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeTo.Location = new System.Drawing.Point(524, 262);
			this.dtpTimeTo.Name = "dtpTimeTo";
			this.dtpTimeTo.Size = new System.Drawing.Size(337, 22);
			this.dtpTimeTo.TabIndex = 26;
			// 
			// dtpTimeFrom
			// 
			this.dtpTimeFrom.AllowDrop = true;
			this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeFrom.Location = new System.Drawing.Point(152, 262);
			this.dtpTimeFrom.Name = "dtpTimeFrom";
			this.dtpTimeFrom.Size = new System.Drawing.Size(334, 22);
			this.dtpTimeFrom.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label4.Location = new System.Drawing.Point(29, 259);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 25);
			this.label4.TabIndex = 24;
			this.label4.Text = "Khung giờ:";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.Red;
			this.btnClose.Location = new System.Drawing.Point(591, 386);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 42);
			this.btnClose.TabIndex = 23;
			this.btnClose.Text = "Huỷ";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.btnCreate.Location = new System.Drawing.Point(729, 386);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(132, 42);
			this.btnCreate.TabIndex = 22;
			this.btnCreate.Text = "Tạo";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(152, 325);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(709, 22);
			this.dtpDate.TabIndex = 19;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(152, 89);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(709, 120);
			this.txtDescription.TabIndex = 16;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(152, 28);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(709, 22);
			this.txtName.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label1.Location = new System.Drawing.Point(29, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Mô tả:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.lblName.Location = new System.Drawing.Point(29, 25);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(57, 25);
			this.lblName.TabIndex = 13;
			this.lblName.Text = "Tên:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label6.Location = new System.Drawing.Point(29, 322);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 25);
			this.label6.TabIndex = 28;
			this.label6.Text = "Diễn ra:";
			// 
			// CreateVaccineSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 476);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpTimeTo);
			this.Controls.Add(this.dtpTimeFrom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblName);
			this.Name = "CreateVaccineSchedule";
			this.Text = "Create Vaccine Schedule";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpTimeTo;
		private System.Windows.Forms.DateTimePicker dtpTimeFrom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label6;
	}
}