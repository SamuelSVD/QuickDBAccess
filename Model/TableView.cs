using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class TableView {
		[XmlAttribute]
		public string name = "";
		public Query ContentQuery = new Query();
		public Query OnDoubleClickQuery;
		public List<Query> buttonActions = new List<Query>();
	}
}
