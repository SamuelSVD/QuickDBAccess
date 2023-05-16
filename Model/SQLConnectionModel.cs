using System;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "SQLConnection")]
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
		[XmlAttribute]
		public bool useIntegratedSecurity { get; set; } = false;
		[XmlIgnore]
		public string ConnectionString {
			get {
				if (useIntegratedSecurity) {
					return String.Format("Server = {0}; Database = {1}; Integrated Security=True;", server, database);
				} else {
					return String.Format("Server = {0}; Database = {1}; User Id = {2}; Password = {3}; ", server, database, user, password);
				}
			}
		}
		[XmlIgnore]
		public bool ConnectionValid = true;
		public SQLConnectionModel() {
		}
		public SQLConnectionModel(SQLConnectionModel model) {
			Apply(model);
		}
		public void Apply(SQLConnectionModel model) {
			this.Name = model.Name;
			this.server = model.server;
			this.database = model.database;
			this.user = model.user;
			this.password = model.password;
			this.useIntegratedSecurity = model.useIntegratedSecurity;
		}
		public void Invalidate() {
			ConnectionValid = false;
		}
		public void Validate() {
			ConnectionValid = true;
		}
	}
}
