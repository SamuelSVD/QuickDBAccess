using QuickDBAccess.Forms;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "TableView")]
	public class TableViewModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		public List<TableViewModel> ChildTableViews { get; set; } = new List<TableViewModel>();
		[XmlAttribute]
		public string ContentDataSourceName { get; set; } = "";
		public ButtonModel DoubleClickAction { get; set; }
		public List<ButtonModel> Buttons { get; set; } = new List<ButtonModel>();
		public List<ColumnDetailModel> ColumnDetails { get; set; } = new List<ColumnDetailModel>();
		[XmlIgnore]
		public TabPage TabPage { get; set; }
		[XmlIgnore]
		public TableViewForm View { get; set; }
	}
}
