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
		public User User;
		public override string TableName
		{
			get { return "schedules"; }
		}

		public Schedule WithUser()
		{
			this.selectedQueues.Add((models) => {
				var keys = new List<string>();
				foreach (var model in models)
				{
					keys.Add(model.GetAttribute("user_id"));
				}

				var users = (new User()).WhereIn((new User()).KeyName, keys).Get();

				foreach (var model in models)
				{
					foreach (var user in users)
					{
						if (user.GetAttribute("id") == model.GetAttribute("user_id"))
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
