using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Preschool_Student_Management.ORM;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management.Models
{
	public class Student : Eloquent<Student>
	{
		public Classroom Classroom;

		private User User;

		public override string TableName
		{
			get { return "students"; }
		}

		public Student WithUser()
		{
			this.selectedQueues.Add((students) => {
				var keys = new List<string>();
				foreach (var student in students)
				{
					keys.Add(student.GetAttribute("user_id"));
				}	

				var users = (new User()).WhereIn((new User()).KeyName, keys).Get();

				foreach (var student in students)
				{
					foreach (var user in users)
					{
						if (user.GetAttribute("id") == student.GetAttribute("user_id"))
						{
							student.User = user;
						}
					}
				}

				return students;
			});

			return this;
		}

		public Student WithClassroom() {
			this.selectedQueues.Add((students) => {
				var keys = new List<string>();
				foreach (var student in students)
				{
					keys.Add(student.GetAttribute("classroom_id"));
				}

				var classrooms = (new Classroom()).WhereIn((new Classroom()).KeyName, keys).Get();

				foreach (var student in students)
				{
					foreach (var classroom in classrooms)
					{
						if (classroom.GetAttribute("id") == student.GetAttribute("classroom_id"))
						{
							student.Classroom = classroom;
						}
					}
				}

				return students;
			});

			return this;
		}

		public List<Schedule> Schedules;
		/// <summary>
		/// With scheduels from A to B
		/// </summary>
		public Student WithSchedules(DateTime from, DateTime to) {
			this.selectedQueues.Add((students) => {
				var keys = new List<string>();
				var classroomKeys = new List<string>();
				foreach (var student in students)
				{
					keys.Add(student.Key);
					classroomKeys.Add(student.GetAttribute("classroom_id"));
				}

				Console.WriteLine(classroomKeys.Count);
				var schedules = Schedule.Query.Where("schedulable_type", "=", this.TableName)
					.WhereIn("schedulable_id", keys)
					.Where("started_at", ">=", from.ToString("yyyy/MM/dd HH:mm:ss"))
					.Where("started_at", "<=", to.ToString("yyyy/MM/dd HH:mm:ss"))
					.OrderBy("started_at")
					.Get();

				var classroomSchedules = Schedule.Query.Where("schedulable_type", "=", (new Classroom()).TableName)
					.WhereIn("schedulable_id", classroomKeys)
					.Where("started_at", ">=", from.ToString("yyyy/MM/dd HH:mm:ss"))
					.Where("started_at", "<=", to.ToString("yyyy/MM/dd HH:mm:ss"))
					.OrderBy("started_at")
					.Get();
				Console.WriteLine(Schedule.Query.Where("schedulable_type", "=", (new Classroom()).TableName)
					.WhereIn("schedulable_id", classroomKeys)
					.Where("started_at", ">=", from.ToString("yyyy/MM/dd HH:mm:ss"))
					.Where("started_at", "<=", to.ToString("yyyy/MM/dd HH:mm:ss"))
					.OrderBy("started_at").ToSql());
				Console.WriteLine(classroomSchedules.Count);

				foreach (var student in students)
				{
					student.Schedules = new List<Schedule>();

					foreach (var scheduel in schedules)
					{
						if (
							scheduel.GetAttribute("schedulable_id") == student.Key
						)
						{
							student.Schedules.Add(scheduel);
						}
					}

					foreach (var scheduel in classroomSchedules)
					{
						if (
							scheduel.GetAttribute("schedulable_id") == student.GetAttribute("classroom_id")
						)
						{
							student.Schedules.Add(scheduel);
						}
					}
				}

				return students;
			});

			return this;
		}

		public Schedule ClosestScheduel;
		/// <summary>
		/// With closet scheduel will occur in future
		/// </summary>
		public Student WithClosestScheduel(double future = 99)
		{
			this.WithSchedules(DateTime.Now, DateTime.Now.AddDays(future));

			this.selectedQueues.Add((students) => {

				foreach (var student in students)
				{
					foreach (var scheduel in student.Schedules)
					{
						student.ClosestScheduel = scheduel;

						if (
							student.ClosestScheduel.StartedAt > scheduel.StartedAt
						)
						{
							student.ClosestScheduel = scheduel;
						}
					}
				}

				return students;
			});

			return this;
		}
	}
}
