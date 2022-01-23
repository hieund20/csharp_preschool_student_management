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
	public partial class CreateVaccineSchedule : Form
	{
		private string scheduleType;
		private int scheduleId;

		public CreateVaccineSchedule(string scheduleType, int scheduleId)
		{
			this.scheduleType = scheduleType;
			this.scheduleId = scheduleId;

			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var name = this.txtName.Text;
			var description = this.txtDescription.Text;
			var timeFrom = DateTime.Today.AddHours(this.dtpTimeFrom.Value.Hour).AddMinutes(this.dtpTimeFrom.Value.Minute);
			var timeTo = DateTime.Today.AddHours(this.dtpTimeTo.Value.Hour).AddMinutes(this.dtpTimeTo.Value.Minute);
			var date = new DateTime(this.dtpDate.Value.Year, this.dtpDate.Value.Month, this.dtpDate.Value.Day);

			if (name == "")
			{
				MessageBox.Show("Tên là bắt buộc", "Error!");
				return;
			}
			if ((timeTo - timeFrom).TotalMinutes < 30)
			{
				MessageBox.Show("Khung giờ không hợp lệ", "Error!");
				return;
			}

			Schedule.Create(this.scheduleType, this.scheduleId, name, description, date, timeFrom, timeTo);

			MessageBox.Show("Tạo thành công schedules!", "Success!");
		}
	}
}
