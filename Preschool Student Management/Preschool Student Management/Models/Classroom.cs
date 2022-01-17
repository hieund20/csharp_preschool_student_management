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
		private int id;
		public int Id {
			get { return this.id; }
			set { this.id = value; }
		}

		private string code;
		public string Code
		{
			get { return this.code; }
			set { this.code = value; }
		}

		private string name;
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		private string createdAt;
		public string CreatedAt
		{
			get { return this.createdAt; }
			set { this.createdAt = value; }
		}

		private int userId;
		public int UserId
		{
			get { return this.userId; }
			set { this.userId = value; }
		}

		private User user;
		public User User
		{
			get { return this.user; }
			set { this.user = value; }
		}

		private List<Student> students;
		public List<Student> Students
		{
			get { return this.students; }
			set { this.students = value; }
		}

		public Classroom() { }

		public Classroom(int id, string code, string name, string createdAt, int userId) {
			this.id = id;
			this.code = code;
			this.name = name;
			this.createdAt = createdAt;
			this.userId = userId;
		}

		protected override Classroom Initialize(MySqlDataReader reader) {
			return new Classroom(
				int.Parse(reader["id"].ToString()),
				reader["code"].ToString(),
				reader["name"].ToString(),
				reader["created_at"].ToString(),
				int.Parse(reader["user_id"].ToString())
				);
		}

		public override string TableName()
		{
			return "classrooms";
		}

		public Classroom WithUser() {
			this.selectedQueues.Add((classrooms) => {
				var keys = new List<string>();
				foreach (var classroom in classrooms) {
					keys.Add(classroom.UserId.ToString());
				}

				var users = (new User()).WhereIn((new User()).KeyName(), keys).Get();

				foreach (var classroom in classrooms)
				{
					foreach (var user in users)
					{
						if (user.Id == classroom.UserId) {
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
					keys.Add(classroom.Id.ToString());
				}

				var students = (new Student()).WhereIn("classroom_id", keys).Get();

				foreach (var classroom in classrooms)
				{
					foreach (var student in students)
					{
						if (student.ClassroomId == classroom.Id)
						{
							if (classroom.students == null) {
								classroom.students = new List<Student>();
							}

							classroom.students.Add(student);
						}
					}
				}

				return classrooms;
			});

			return this;
		}
	}
}
