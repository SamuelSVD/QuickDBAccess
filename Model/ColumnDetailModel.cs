using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	[XmlType(TypeName = "ColumnDetail")]
	public class ColumnDetailModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public bool hidden { get; set; } = false;
		public ColumnDetailModel() { }
		public ColumnDetailModel(ColumnDetailModel model ) {
			Name = model.Name;
			hidden = model.hidden;
		}
	}
}