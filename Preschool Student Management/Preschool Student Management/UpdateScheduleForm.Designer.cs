
namespace Preschool_Student_Management
{
	partial class UpdateScheduleForm
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
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
			this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.btnDeleteFuture = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label6.Location = new System.Drawing.Point(27, 346);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 25);
			this.label6.TabIndex = 40;
			this.label6.Text = "Diễn ra:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label5.Location = new System.Drawing.Point(496, 283);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 25);
			this.label5.TabIndex = 39;
			this.label5.Text = "-";
			// 
			// dtpTimeTo
			// 
			this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeTo.Location = new System.Drawing.Point(522, 286);
			this.dtpTimeTo.Name = "dtpTimeTo";
			this.dtpTimeTo.Size = new System.Drawing.Size(337, 22);
			this.dtpTimeTo.TabIndex = 38;
			// 
			// dtpTimeFrom
			// 
			this.dtpTimeFrom.AllowDrop = true;
			this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeFrom.Location = new System.Drawing.Point(150, 286);
			this.dtpTimeFrom.Name = "dtpTimeFrom";
			this.dtpTimeFrom.Size = new System.Drawing.Size(334, 22);
			this.dtpTimeFrom.TabIndex = 37;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label4.Location = new System.Drawing.Point(27, 283);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 25);
			this.label4.TabIndex = 36;
			this.label4.Text = "Khung giờ:";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.Red;
			this.btnDelete.Location = new System.Drawing.Point(589, 410);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(132, 42);
			this.btnDelete.TabIndex = 35;
			this.btnDelete.Text = "Xoá";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.btnUpdate.Location = new System.Drawing.Point(727, 410);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(132, 42);
			this.btnUpdate.TabIndex = 34;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(150, 349);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(709, 22);
			this.dtpDate.TabIndex = 33;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(150, 113);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(709, 120);
			this.txtDescription.TabIndex = 32;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(150, 52);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(709, 22);
			this.txtName.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.label1.Location = new System.Drawing.Point(27, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 25);
			this.label1.TabIndex = 30;
			this.label1.Text = "Mô tả:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(85)))), ((int)(((byte)(159)))));
			this.lblName.Location = new System.Drawing.Point(27, 49);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(57, 25);
			this.lblName.TabIndex = 29;
			this.lblName.Text = "Tên:";
			// 
			// btnDeleteFuture
			// 
			this.btnDeleteFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteFuture.ForeColor = System.Drawing.Color.Red;
			this.btnDeleteFuture.Location = new System.Drawing.Point(317, 410);
			this.btnDeleteFuture.Name = "btnDeleteFuture";
			this.btnDeleteFuture.Size = new System.Drawing.Size(266, 42);
			this.btnDeleteFuture.TabIndex = 41;
			this.btnDeleteFuture.Text = "Xoá cả trong tương lai";
			this.btnDeleteFuture.UseVisualStyleBackColor = true;
			this.btnDeleteFuture.Click += new System.EventHandler(this.btnDeleteFuture_Click);
			// 
			// UpdateScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 500);
			this.Controls.Add(this.btnDeleteFuture);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpTimeTo);
			this.Controls.Add(this.dtpTimeFrom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblName);
			this.Name = "UpdateScheduleForm";
			this.Text = "UpdateScheduleForm";
			this.Load += new System.EventHandler(this.UpdateScheduleForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpTimeTo;
		private System.Windows.Forms.DateTimePicker dtpTimeFrom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnDeleteFuture;
	}
}