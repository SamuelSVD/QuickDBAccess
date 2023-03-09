using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class Query {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public string Command { get; set; } = "";
		public List<QueryParameter> Parameters { get; set; } = new List<QueryParameter>();
		public List<QueryParameter> ParentParameters { get; set; } = new List<QueryParameter>();
	}
}
