using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
using Preschool_Student_Management;

namespace Preschool_Student_Management.ORM
{
	abstract class Eloquent<T> where T : Eloquent<T>, new()
	{
		/// <summary>
		/// Used to build query
		/// </summary>
		public static T Query {
			get { return new T(); }
		}

		/// <summary>
		/// Contain all attibutes of the model
		/// </summary>
		protected Dictionary<string, string> attributes  = new Dictionary<string, string>();

		protected List<string> changedAttributeNames = new List<string>(); 

		/// <summary>
		/// Determine whether the model is exists in database
		/// </summary>
		protected bool exists = false;

		/// <summary>
		/// Get a given attribute of the model
		/// </summary>
		public string GetAttribute(string field) {
			return this.attributes[field];
		}

		/// <summary>
		/// Set a given attribute of the model
		/// </summary>
		public void SetAttribute(string field, string value)
		{
			this.attributes[field] = value;

			if (this.changedAttributeNames.Find((f) => f == field) == null)
			{
				this.changedAttributeNames.Add(field);
			}
		}

		/// <summary>
		/// Contain all where conditions of query builder
		/// </summary>
		protected List<Condition> conditions = new List<Condition> { };

		/// <summary>
		/// Contains all Function will called when select
		/// </summary>
		protected List<Func<List<T>, List<T>>> selectedQueues = new List<Func<List<T>, List<T>>> { };

		/// <summary>
		/// Return a table name
		/// </summary>
		abstract public string TableName {
			get;
		}

		/// <summary>
		/// Return primary key name of table
		/// </summary>
		public string KeyName {
			get { return "id"; }
		}

		public string Key 
		{
			get { return this.GetAttribute(this.KeyName); }
			set { this.SetAttribute(this.KeyName, value); }
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
			var query = "SELECT * FROM `" + this.TableName + "`";
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
		public List<T> Get(string raw = "")
		{
			List<T> models = new List<T>();

			var query = "";
			if (raw == "")
			{
				query = this.ToSql();
			}
			else
			{
				query = raw;
			}

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
					var model = new T();
					model.exists = true;
					for (int lp = 0; lp < reader.FieldCount; lp++)
					{
						model.attributes[reader.GetName(lp)] = reader.GetValue(lp).ToString();
					}
					models.Add(model);
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

		/// <summary>
		/// Add where by primary key name and get first result
		/// </summary>
		public T Find(string value) {
			return this.Where(this.KeyName, "=", value).First();
		}

		/// <summary>
		/// Save or create a model to database
		/// </summary>
		public void Save() {
			if (this.exists)
			{
				this.SaveAsUpate();
			}
			else 
			{
				this.SaveAsInsert();
			}

			this.changedAttributeNames = new List<string>();
			this.exists = true;
		}

		/// <summary>
		/// Save but insert data to database
		/// </summary>
		protected void SaveAsInsert() {
			var columns = "(";
			var values = "(";

			var isFirst = true;
			foreach (var attribute in this.attributes)
			{
				if (isFirst)
				{
					columns += "`" + attribute.Key + "`";
					values += "\"" + attribute.Value + "\"";
					isFirst = false;
				}
				else
				{
					columns += ", `" + attribute.Key + "`";
					values += ", \"" + attribute.Value + "\"";
				}
			}
			columns += ")";
			values += ")";

			Utils.insertQuery("INSERT INTO `" + this.TableName +"` " + columns + " VALUES " + values);
			this.attributes = Eloquent<T>.Query.OrderBy(this.KeyName, "DESC").First().attributes;
		}

		/// <summary>
		/// Save but update data in database
		/// </summary>
		protected void SaveAsUpate()
		{
			if (this.changedAttributeNames.Count == 0) {
				return;
			}

			var query = "UPDATE `" + this.TableName +"` SET";

			var isFirst = true;
			foreach (var name in this.changedAttributeNames)
			{
				if (isFirst)
				{
					query += " `" + name + "`=\"" + this.attributes[name] + "\"";
					isFirst = false;
				}
				else
				{
					query += ", `" + name + "`=\"" + this.attributes[name] + "\"";
				}
			}
			query += " WHERE `" + this.KeyName + "` = \"" + this.GetAttribute(this.KeyName) + "\"";
			Utils.insertQuery(query);
		}

		public void Delete() {
			var query = "DELETE FROM `" + this.TableName + "` WHERE `" + this.KeyName + "` = \"" + this.GetAttribute(this.KeyName) +"\"";
			Utils.deleteQuery(query);
		}
	}
}
