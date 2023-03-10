using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class TableView {
		[XmlAttribute]
		public string Name { get; set; } = "";
		//public Query ContentQuery { get; set; } = new Query();
		//public Query OnDoubleClickQuery { get; set; }
		//public List<Query> buttonActions { get; set; } = new List<Query>();
		public List<TableView> ChildTableViews { get; set; } = new List<TableView>();
		[XmlAttribute]
		public string ContentDataSourceName { get; set; } = "";
		public ButtonModel DoubleClickAction { get; set; }
		public List<ButtonModel> Buttons { get; set; } = new List<ButtonModel>();
		public List<ColumnDetail> ColumnDetails { get; set; } = new List<ColumnDetail>();
	}
}
