using System.Collections.Generic;

namespace QuickDBAccess.Model {
	public class QuickAccess {
		public List<SQLConnection> Connections { get; set; } = new List<SQLConnection>();
		public List<DataSource> DataSources { get; set; } = new List<DataSource>();
		public List<TableView> TableViews { get; set; } = new List<TableView>();
		public SQLConnection ConnectionByName(string ConnectionName) {
			return Connections.Find(t => t.Name == ConnectionName);
		}
		public DataSource DataSourceByName(string DataSourceName) {
			return DataSources.Find(t => t.Name == DataSourceName);
		}
	}
}
