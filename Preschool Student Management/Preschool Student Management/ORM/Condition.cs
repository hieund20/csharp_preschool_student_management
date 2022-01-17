using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preschool_Student_Management.ORM
{
	class Condition
	{
		protected string field;
		protected string comparation = "=";
		protected string value;
		protected string concatenation = "AND";

		public Condition(string field,string comparation, string value, string concatenation = "AND") { 
			this.field = field;
			this.comparation = comparation;
			this.value = value;
			this.concatenation = concatenation;
		}

		/// <summary>
		/// Convert to string
		/// </summary>
		public string toString(bool isFirst = false ){
			var result = "`"+this.field + "` " + this.comparation + " \"" + this.value + "\"";

			if(isFirst){
				return "WHERE " + result;
			}

			return this.concatenation + " " + result;
		}
	}
}
