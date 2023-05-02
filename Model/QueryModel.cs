using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class QueryModel {
		[XmlAttribute]
		public string Name { get; set; } = "";
		[XmlAttribute]
		public string Command { get; set; } = "";
		public List<QueryParameterModel> Parameters { get; set; } = new List<QueryParameterModel>();
		public List<QueryParameterModel> ParentParameters { get; set; } = new List<QueryParameterModel>();
		public QueryModel() { }	
		public QueryModel(QueryModel model) {
			Apply(model);
		}
		public void Apply(QueryModel model) {
			Name = model.Name;
			Command = model.Command;
			Parameters.Clear();
			foreach (QueryParameterModel parameter in model.Parameters) {
				Parameters.Add(new QueryParameterModel(parameter));
			}
			ParentParameters.Clear();
			foreach (QueryParameterModel parameter in model.ParentParameters) {
				ParentParameters.Add(new QueryParameterModel(parameter));
			}
		}
	}
}
