using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "DataSource")]
	public class DataSourceModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public string ConnectionName { get; set; } = "";
		public QueryModel Query { get; set; } = new QueryModel();

		public DataSourceModel() { }
		public DataSourceModel(DataSourceModel model) {
			Name = model.Name;
			ConnectionName = model.ConnectionName;
			Query.Command = model.Query.Command;
		}
		internal void Apply(DataSourceModel model) {
			Name = model.Name;
			ConnectionName = model.ConnectionName;
			Query.Command = model.Query.Command;
		}
	}
}
