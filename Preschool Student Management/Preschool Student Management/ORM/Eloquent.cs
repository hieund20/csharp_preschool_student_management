using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Preschool_Student_Management.ORM
{
	abstract class Eloquent<T> where T : Eloquent<T>, new()
	{
		protected List<Condition> conditions = new List<Condition> { };
		protected List<Func<List<T>, List<T>>> selectedQueues = new List<Func<List<T>, List<T>>> { };

		/// <summary>
		/// Initialize a model form result select query
		/// </summary>
		abstract protected T Initialize(MySqlDataReader reader);

		/// <summary>
		/// Return a table name
		/// </summary>
		abstract public string TableName();

		/// <summary>
		/// Return primary key name of table
		/// </summary>
		public string KeyName() {
			return "id";
		}


		/// <summary>
		/// Add a compare condition to query
		/// </summary>
		public Eloquent<T> Where(string field, string compare , string value , string concatenation = "AND")
		{
			Condition condition = new Condition(field,compare, value, concatenation);
			this.conditions.Add(condition);

			return this;
		}

		public Eloquent<T> WhereIn(string field, List<string> values, string concatenation = "AND")
		{
			Condition condition = new Condition(field, values, concatenation);
			this.conditions.Add(condition);

			return this;
		}

		public Eloquent<T> WhereNotIn(string field, List<string> values, string concatenation = "AND")
		{
			Condition condition = new Condition(field, values, concatenation, true);
			this.conditions.Add(condition);

			return this;
		}

		protected string order = "";
		/// <summary>
		/// Add a order by to query
		/// </summary>
		public Eloquent<T> OrderBy(string field, string type = "ASC") {
			type = type.ToUpper();
			this.order = "ORDER BY `" + field + "` " + type;

			return this;
		}

		protected string limit = "";
		/// <summary>
		/// Add a order by to query
		/// </summary>
		public Eloquent<T> Limit(int amount)
		{
			this.limit = "LIMIT " + amount.ToString();

			return this;
		}

		protected string offset = "";
		/// <summary>
		/// Add a order by to query
		/// </summary>
		public Eloquent<T> Offset(int offset)
		{
			this.offset = "OFFSET " + offset.ToString();

			return this;
		}

		/// <summary>
		/// Get result of query
		/// </summary>
		public string ToSql() {
			var query = "SELECT * FROM `" + this.TableName() + "`";
			var isFirst = true;
			foreach (Condition condition in this.conditions)
			{
				query += " " + condition.toString(isFirst);
				isFirst = false;
			}

			if (this.order != "") {
				query += " " + this.order;
			}

			if (this.limit != "")
			{
				query += " " + this.limit;
			}

			if (this.offset != "")
			{
				query += " " + this.offset;
			}

			return query;
		}

		/// <summary>
		/// Get result of query
		/// </summary>
		public List<T> Get()
		{
			List<T> models = new List<T>();
			var query = this.ToSql();

			var connection = DBUtils.getDBConnection();
			connection.Open();
			try
			{
				MySqlCommand command = new MySqlCommand();
				command.Connection = connection;
				command.CommandText = query;

				MySqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					models.Add(this.Initialize(reader));
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error when execute select query: " + ex);
			}

			foreach (var callable in this.selectedQueues) {
				models = callable(models);
			}

			return models;
		}

		/// <summary>
		/// Get sliced result
		/// </summary>
		public List<T> Slice(int start, int end) {
			return this.Limit(end - start + 1).Offset(start).Get();
		}

		/// <summary>
		/// Get first result
		/// </summary>
		public T First() {
			var result = this.Limit(1).Get();
			if (result.Count > 0) {
				return result[0];
			}

			return null;
		}
	}
}
