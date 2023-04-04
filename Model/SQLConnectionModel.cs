using System;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName="SQLConnection")]
	public class SQLConnectionModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public string server { get; set; } = "";
		[XmlAttribute]
		public string database { get; set; } = "";
		[XmlAttribute]
		public string user { get; set; } = "";
		[XmlAttribute]
		public string password { get; set; } = "";
		public string ConnectionString() {
			return String.Format("Server = {0}; Database = {1}; User Id = {2}; Password = {3}; ", server, database, user, password);
		}
	}
}
