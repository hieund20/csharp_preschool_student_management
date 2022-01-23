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
	public partial class UpdateScheduleForm : Form
	{
		private Schedule schedule;
		public UpdateScheduleForm(Schedule schedule)
		{
			this.schedule = schedule;
			InitializeComponent();
		}

		private void UpdateScheduleForm_Load(object sender, EventArgs e)
		{
			this.txtName.Text = schedule.GetAttribute("name");
			this.txtDescription.Text = schedule.GetAttribute("description");

			this.dtpDate.Value = schedule.StartedAt;
			this.dtpTimeFrom.Value = schedule.StartedAt;
			this.dtpTimeTo.Value = schedule.EndedAt;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
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

			this.schedule.SetAttribute("name", name);
			this.schedule.SetAttribute("description", description);
			this.schedule.StartedAt = new DateTime(date.Year, date.Month, date.Day, timeFrom.Hour, timeFrom.Minute, 0);
			this.schedule.EndedAt = new DateTime(date.Year, date.Month, date.Day, timeTo.Hour, timeTo.Minute, 0);

			this.schedule.Save();
			MessageBox.Show("Cập nhật thành công schedules!", "Success!");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			this.schedule.Delete();
			MessageBox.Show("Xoá thành công!", "Success!");
			this.Close();
		}

		private void btnDeleteFuture_Click(object sender, EventArgs e)
		{
			this.schedule.Delete();

			var deletedSchedules = Schedule.Query
				.Where("name", "=", this.schedule.GetAttribute("name"))
				.Where("description", "=", this.schedule.GetAttribute("description"))
				.Where("started_at", ">=", this.schedule.StartedAt.ToString("yyyy/MM/dd HH:mm:ss"))
				.Get();

			foreach(var schedule in deletedSchedules)
			{
				schedule.Delete();
			}

			MessageBox.Show("Xoá thành công " + (deletedSchedules.Count + 1).ToString() + " schedules!", "Success!");
			this.Close();
		}
	}
}
