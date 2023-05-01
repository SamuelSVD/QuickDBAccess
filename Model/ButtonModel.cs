using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class ButtonModel {
		[XmlAttribute]
		public string Text { get; set; } = "";
		[XmlAttribute]
		public string DataSourceName { get; set; } = "";
		public ButtonModel() { }
		public ButtonModel(ButtonModel model) {
			Text = model.Text;
			DataSourceName = model.DataSourceName;
		}
		internal void Apply(ButtonModel model) {
			Text = model.Text;
			DataSourceName = model.DataSourceName;
		}
	}
}
