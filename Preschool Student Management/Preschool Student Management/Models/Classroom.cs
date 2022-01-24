using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Preschool_Student_Management.ORM;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Preschool_Student_Management.Models
{
	public class Classroom : Eloquent<Classroom>
	{

		/// <summary>
		/// Owner of the model
		/// </summary>
		public User User;

		/// <summary>
		/// Students of the model
		/// </summary>
		public List<Student> Students;

		public override string TableName
		{
			get { return "classrooms"; }
		}

		public Classroom WithUser() {
			this.selectedQueues.Add((classrooms) => {
				var keys = new List<string>();
				foreach (var classroom in classrooms) {
					keys.Add(classroom.GetAttribute("user_id"));
				}

				var users = (new User()).WhereIn((new User()).KeyName, keys).Get();

				foreach (var classroom in classrooms)
				{
					foreach (var user in users)
					{
						if (user.GetAttribute("id") == classroom.GetAttribute("user_id")) {
							classroom.User = user;
						}
					}
				}

				return classrooms;
			});

			return this;
		}

		public Classroom WithStudents() {
			this.selectedQueues.Add((classrooms) => {
				var keys = new List<string>();
				foreach (var classroom in classrooms)
				{
					keys.Add(classroom.GetAttribute("id"));
				}

				var students = (new Student()).WhereIn("classroom_id", keys).Get();

				foreach (var classroom in classrooms)
				{
					if (classroom.Students == null)
					{
						classroom.Students = new List<Student>();
					}

					foreach (var student in students)
					{
						if (student.GetAttribute("classroom_id") == classroom.GetAttribute("id"))
						{

							classroom.Students.Add(student);
						}
					}
				}

				return classrooms;
			});

			return this;
		}

		public List<Schedule> Schedules;
		/// <summary>
		/// With scheduels from A to B
		/// </summary>
		public Classroom WithSchedules(DateTime from, DateTime to) {
			this.selectedQueues.Add((classrooms) => {
				var keys = new List<string>();
				foreach (var classroom in classrooms)
				{
					keys.Add(classroom.Key);
				}

				var schedules = Schedule.Query.Where("schedulable_type", "=", this.TableName)
					.WhereIn("schedulable_id", keys)
					.Where("started_at", ">=", from.ToString("yyyy/MM/dd HH:mm:ss"))
					.Where("started_at", "<=", to.ToString("yyyy/MM/dd HH:mm:ss"))
					.OrderBy("started_at")
					.Get();

                //MessageBox.Show(Schedule.Query.Where("schedulable_type", "=", this.TableName)
                //    .WhereIn("schedulable_id", keys)
                //    .Where("started_at", ">=", from.ToString("yyyy/MM/dd HH:mm:ss"))
                //    .Where("started_at", "<=", to.ToString("yyyy/MM/dd HH:mm:ss"))
                //    .OrderBy("started_at").ToSql());

                foreach (var classroom in classrooms)
				{
					classroom.Schedules = new List<Schedule>();

					foreach (var scheduel in schedules)
					{
						if (
							scheduel.GetAttribute("schedulable_id") == classroom.Key
						)
						{
							classroom.Schedules.Add(scheduel);
						}
					}
				}

				return classrooms;
			});

			return this;
		}

		public Schedule ClosestScheduel;
		/// <summary>
		/// With closet scheduel will occur in future
		/// </summary>
		public Classroom WithClosestScheduel(double future = 99 )
		{
			this.WithSchedules(DateTime.Now, DateTime.Now.AddDays(future));

			this.selectedQueues.Add((classrooms) => {

				foreach (var classroom in classrooms)
				{
					foreach (var scheduel in classroom.Schedules)
					{
						classroom.ClosestScheduel = scheduel;

						if (
							classroom.ClosestScheduel.StartedAt > scheduel.StartedAt
						)
						{
							classroom.ClosestScheduel = scheduel;
                        }
					}
				}

                
                return classrooms;
			});

			return this;
            
		}
        
	}
}
