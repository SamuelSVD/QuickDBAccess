using QuickDBAccess.Forms;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "TableView")]
	public class TableViewModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public string ContentDataSourceName { get; set; } = "";
		public List<TableViewModel> ChildTableViews { get; set; } = new List<TableViewModel>();
		public ButtonModel DoubleClickAction { get; set; }
		public List<ButtonModel> Buttons { get; set; } = new List<ButtonModel>();
		public List<ColumnDetailModel> ColumnDetails { get; set; } = new List<ColumnDetailModel>();
		[XmlIgnore]
		public TabPage TabPage { get; set; }
		[XmlIgnore]
		public TableViewForm View { get; set; }
		public TableViewModel() { }
		public TableViewModel(TableViewModel model) {
			Apply(model);
		}

		internal void Apply(TableViewModel model) {
			Name = model.Name;
			ContentDataSourceName = model.ContentDataSourceName;
			ChildTableViews.Clear();
			foreach (TableViewModel child in model.ChildTableViews) {
				ChildTableViews.Add(new TableViewModel(child));
			}
			if (model.DoubleClickAction != null) {
				DoubleClickAction = new ButtonModel(model.DoubleClickAction);
			} else {
				DoubleClickAction = null;
			}
			Buttons.Clear();
			foreach (ButtonModel button in model.Buttons) {
				Buttons.Add(new ButtonModel(button));
			}
			ColumnDetails.Clear();
			foreach (ColumnDetailModel column in model.ColumnDetails) {
				ColumnDetails.Add(new ColumnDetailModel(column));
			}
		}

		internal bool UsesDataSource(DataSourceModel dataSource) {
			return ContentDataSourceName == dataSource.Name || ChildTableViews.Exists(t => t.UsesDataSource(dataSource));
		}
	}
}
