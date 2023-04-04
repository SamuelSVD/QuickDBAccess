using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "ColumnDetail")]
	public class ColumnDetailModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public bool hidden { get; set; } = false;
	}
}