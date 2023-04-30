using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "QueryParameter")]
	public class QueryParameterModel {
		[XmlAttribute]
		public string type { get; set; } = "";
		[XmlAttribute]
		public string name { get; set; } = "";
		[XmlAttribute]
		public string autoSourceColumnName { get; set; } = "";
		[XmlIgnore]
		public Control c { get; set; }
		public QueryParameterModel() { }
		public QueryParameterModel(QueryParameterModel model) {
			type = model.type;
			name = model.name;
			autoSourceColumnName = model.autoSourceColumnName;
		}
		public void Apply(QueryParameterModel model) {
			type = model.type;
			name = model.name;
			autoSourceColumnName = model.autoSourceColumnName;
		}
		public SqlDbType getSqlDbType() {
			type = type.ToLower();
			SqlDbType val;
			if (!string.IsNullOrEmpty(type) && GetTypeNames().TryGetValue(type, out val)) {
				return val;
			}
			return SqlDbType.VarChar;
		}
		public static Dictionary<string, SqlDbType> GetTypeNames() {
			return new Dictionary<string, SqlDbType> {
				{ "bigint",  SqlDbType.BigInt },
				{ "bit",  SqlDbType.Bit },
				{"date",  SqlDbType.Date},
				{"time",  SqlDbType.Time},
				{"datetime",  SqlDbType.DateTime},
				{"float",  SqlDbType.Float },
				{"int",  SqlDbType.Int },
				{"real", SqlDbType.Real},
				{"smallint", SqlDbType.SmallInt},
				{"tinyint", SqlDbType.TinyInt},
				{"varchar", SqlDbType.VarChar},
			};
		}
		public object getValue() {
			switch(type) {
				case "bigint":
					return ((NumericUpDown)c).Value;
				case "bit":
					return ((CheckBox)c).Checked;
				case "date":
					return ((DateTimePicker)c).Value.Date;
				case "time":
					return ((DateTimePicker)c).Value.TimeOfDay;
				case "datetime":
					return ((DateTimePicker)c).Value;
				case "float":
					return float.Parse(((TextBox)c).Text);
				case "int":
					return ((NumericUpDown)c).Value;
				case "real":
					return double.Parse(((TextBox)c).Text);
				case "smallint":
					return ((NumericUpDown)c).Value;
				case "tinyint":
					return ((NumericUpDown)c).Value;
				case "varchar":
					return ((TextBox)c).Text;
			}
			return null;
		}
	}
}
