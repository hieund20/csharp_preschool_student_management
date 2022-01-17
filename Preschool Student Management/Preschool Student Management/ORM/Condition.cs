using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Student_Management.ORM
{
	class Condition
	{
		protected string condition;
		protected string concatenation;

		public Condition(string field,string comparation, string value, string concatenation = "AND") { 
			this.concatenation = concatenation;

			this.condition = "`" + field + "` " + comparation + " \"" + value + "\"";
		}

		public Condition(string field, List<string> values, string concatenation = "AND", bool negative = false)
		{
			this.concatenation = concatenation;

			if (values.Count == 0) {
				if (negative)
				{
					this.condition = "\"1\" = \"1\"";
				}
				else	
				{
					this.condition = "\"1\" = \"2\"";
				}
				return;
			}

			this.condition = "`" + field + "` " + (negative ? "NOT" : "") + " IN (";

			var isFist = true;
			foreach (var value in values) {
				if (isFist)
				{
					this.condition += "\"" + value + "\"";
					isFist = false;
				}
				else
				{
					this.condition += ", \"" + value + "\"";
				}
			}

			this.condition += ")";
		}

		/// <summary>
		/// Convert to string
		/// </summary>
		public string toString(bool isFirst = false ){
			if(isFirst){
				return "WHERE " + this.condition;
			}

			return this.concatenation + " " + this.condition;
		}
	}
}
