using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class ColumnDetail {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public bool hidden { get; set; } = false;
	}
}