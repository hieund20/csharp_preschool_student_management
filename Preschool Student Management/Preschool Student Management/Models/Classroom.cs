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
	class Classroom : Eloquent<Classroom>
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
	}
}
