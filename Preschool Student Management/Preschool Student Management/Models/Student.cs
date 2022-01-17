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
		private int id;
		public int Id {
			get { return this.id; }
			set { this.id = value; }
		}

		private string firstName;
		public string FirstName
		{
			get { return this.firstName; }
			set { this.firstName = value; }
		}

		private string lastName;
		public string LastName
		{
			get { return this.lastName; }
			set { this.lastName = value; }
		}

		private string birthDate;
		public string BirthDate
		{
			get { return this.birthDate; }
			set { this.birthDate = value; }
		}

		private string parentFirstName;
		public string ParentFirstName
		{
			get { return this.parentFirstName; }
			set { this.parentFirstName = value; }
		}

		private string parentLastName;
		public string ParentLastName
		{
			get { return this.parentLastName; }
			set { this.parentLastName = value; }
		}

		private string parentPhoneNumber;
		public string ParentPhoneNumber
		{
			get { return this.parentPhoneNumber; }
			set { this.parentPhoneNumber = value; }
		}

		private string address;
		public string Address
		{
			get { return this.address; }
			set { this.address = value; }
		}

		private int classroomId;
		public int ClassroomId
		{
			get { return this.classroomId; }
			set { this.classroomId = value; }
		}

		private Classroom classroom;
		public Classroom Classroom
		{
			get { return this.classroom; }
			set { this.classroom = value; }
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

		public Student() { }

		public Student(int id, string firstName, string lastName, string birthDate, string parentFirstName, string parentLastName, string parentPhoneNumber, string address, int classroomId, string createdAt, int userId) {
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
			this.birthDate = birthDate;
			this.parentFirstName = parentFirstName;
			this.parentLastName = parentLastName;
			this.parentPhoneNumber = parentPhoneNumber;
			this.address = address;
			this.classroomId = classroomId;
			this.createdAt = createdAt;
			this.userId = userId;
		}

		protected override Student Initialize(MySqlDataReader reader) {
			return new Student(
				int.Parse(reader["id"].ToString()),
				reader["first_name"].ToString(),
				reader["last_name"].ToString(),
				reader["birth_date"].ToString(),
				reader["parent_first_name"].ToString(),
				reader["parent_last_name"].ToString(),
				reader["parent_phone_number"].ToString(),
				reader["address"].ToString(),
				int.Parse(reader["classroom_id"].ToString()),
				reader["created_at"].ToString(),
				int.Parse(reader["user_id"].ToString())
				);
		}

		public override string TableName()
		{
			return "students";
		}

		public Student WithUser()
		{
			this.selectedQueues.Add((students) => {
				var keys = new List<string>();
				foreach (var student in students)
				{
					keys.Add(student.UserId.ToString());
				}	

				var users = (new User()).WhereIn((new User()).KeyName(), keys).Get();

				foreach (var student in students)
				{
					foreach (var user in users)
					{
						if (user.Id == student.UserId)
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
					keys.Add(student.ClassroomId.ToString());
				}

				var classrooms = (new Classroom()).WhereIn((new Classroom()).KeyName(), keys).Get();

				foreach (var student in students)
				{
					foreach (var classroom in classrooms)
					{
						if (classroom.Id == student.ClassroomId)
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
