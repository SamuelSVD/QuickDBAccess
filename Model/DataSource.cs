using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class DataSource {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public string ConnectionName { get; set; } = "";
		public Query Query { get; set; } = new Query();
	}
}
