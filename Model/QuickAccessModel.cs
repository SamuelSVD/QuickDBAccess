using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "QuickAccess")]
	public class QuickAccessModel {
		[XmlAttribute]
		public string ProjectName = string.Empty;
		public List<SQLConnectionModel> Connections { get; set; } = new List<SQLConnectionModel>();
		public List<DataSourceModel> DataSources { get; set; } = new List<DataSourceModel>();
		public List<TableViewModel> TableViews { get; set; } = new List<TableViewModel>();
		public SQLConnectionModel ConnectionByName(string ConnectionName) {
			return Connections.Find(t => t.Name == ConnectionName);
		}
		public DataSourceModel DataSourceByName(string DataSourceName) {
			return DataSources.Find(t => t.Name == DataSourceName);
		}
	}
}
