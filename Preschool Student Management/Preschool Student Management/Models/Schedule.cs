using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Preschool_Student_Management.ORM;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management.Models
{
	class Schedule : Eloquent<Schedule>
	{
		private int id;
		public int Id {
			get { return this.id; }
			set { this.id = value; }
		}

		private string name;
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		private string description;
		public string Description
		{
			get { return this.description; }
			set { this.description = value; }
		}

		private int type;
		public int Password
		{
			get { return this.type; }
			set { this.type = value; }
		}

		private string startedAt;
		public string StartedAt
		{
			get { return this.startedAt; }
			set { this.startedAt = value; }
		}

		private string endedAt;
		public string EndedAt
		{
			get { return this.endedAt; }
			set { this.endedAt = value; }
		}

		private int schedulableId;
		public int SchedulableId
		{
			get { return this.schedulableId; }
			set { this.schedulableId = value; }
		}

		private string schedulableType;
		public string SchedulableType
		{
			get { return this.schedulableType; }
			set { this.schedulableType = value; }
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

		public Schedule() { }

		public Schedule(int id, string name, string description, int type, string startedAt, string endedAt, int schedulableId, string schedulableType, string createdAt, int userId) {
			this.id = id;
			this.name = name;
			this.description = description;
			this.type = type;
			this.startedAt = startedAt;
			this.endedAt = endedAt;
			this.schedulableId = schedulableId;
			this.schedulableType = schedulableType;
			this.createdAt = createdAt;
			this.userId = userId;
		}

		protected override Schedule Initialize(MySqlDataReader reader) {
			return new Schedule(
				int.Parse(reader["id"].ToString()),
				reader["name"].ToString(),
				reader["description"].ToString(),
				int.Parse(reader["type"].ToString()),
				reader["started_at"].ToString(),
				reader["ended_at"].ToString(),
				int.Parse(reader["schedulable_id"].ToString()),
				reader["schedulable_type"].ToString(),
				reader["createdAt"].ToString(),
				int.Parse(reader["user_id"].ToString())
				);
		}

		public override string TableName()
		{
			return "schedules";
		}

		public Schedule WithUser()
		{
			this.selectedQueues.Add((models) => {
				var keys = new List<string>();
				foreach (var model in models)
				{
					keys.Add(model.UserId.ToString());
				}

				var users = (new User()).WhereIn((new User()).KeyName(), keys).Get();

				foreach (var model in models)
				{
					foreach (var user in users)
					{
						if (user.Id == model.UserId)
						{
							model.User = user;
						}
					}
				}

				return models;
			});

			return this;
		}
	}
}
