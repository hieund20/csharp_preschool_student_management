using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Preschool_Student_Management.ORM;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management.Models
{
	public class User: Eloquent<User>
	{

		public override string TableName
		{
			get { return "users"; }
		}
	}
}
