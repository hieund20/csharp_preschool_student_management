using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Preschool_Student_Management.ORM;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management.Models
{
	class Student : Eloquent<Student>
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
	}
}
