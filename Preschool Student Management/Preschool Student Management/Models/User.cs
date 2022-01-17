using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Preschool_Student_Management.ORM;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management.Models
{
	class User: Eloquent<User>
	{
		private int id;
		public int Id {
			get { return this.id; }
			set { this.id = value; }
		}

		private string username;
		public string Username
		{
			get { return this.username; }
			set { this.username = value; }
		}

		private string email;
		public string Email
		{
			get { return this.email; }
			set { this.email = value; }
		}

		private string password;
		public string Password
		{
			get { return this.password; }
			set { this.password = value; }
		}

		private int role;
		public int Role
		{
			get { return this.role; }
			set { this.role = value; }
		}

		private string createdAt;
		public string CreatedAt
		{
			get { return this.createdAt; }
			set { this.createdAt = value; }
		}

		public User() { }

		public User(int id, string username, string email, string password, int role, string createdAt) {
			this.id = id;
			this.username = username;
			this.email = email;
			this.password = password;
			this.role = role;
			this.createdAt = createdAt;
		}

		protected override User Initialize(MySqlDataReader reader) {
			return new User(
				int.Parse(reader["id"].ToString()),
				reader["username"].ToString(),
				reader["email"].ToString(),
				reader["password"].ToString(),
				int.Parse(reader["role"].ToString()),
				reader["created_at"].ToString()
				);
		}

		public override string TableName()
		{
			return "users";
		}
	}
}
