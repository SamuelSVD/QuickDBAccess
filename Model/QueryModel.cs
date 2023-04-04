using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class QueryModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public string Command { get; set; } = "";
		public List<QueryParameterModel> Parameters { get; set; } = new List<QueryParameterModel>();
		public List<QueryParameterModel> ParentParameters { get; set; } = new List<QueryParameterModel>();
	}
}
