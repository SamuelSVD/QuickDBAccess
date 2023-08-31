using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDBAccess.Model {
	public class DataFilterModel {
		public int ColumnIndex = -1;
		public string Text = string.Empty;
		public ComparisonExpression Expression = DataFilterModel.ComparisonExpression.Contains;
		public DataFilterModel() { }
		public DataFilterModel(DataFilterModel model) {
			this.ColumnIndex = model.ColumnIndex;
			this.Text = model.Text;
			this.Expression = model.Expression;
		}
		public enum ComparisonExpression {
			Contains = 1,
			Equals = 2,
			NotEquals = 3
		}
	}
}
