using System.Collections.Generic;

namespace QuickDBAccess.Model {
	public class QuickAccess {
		public SQLConnection Connection = new SQLConnection();
		public List<TableView> TableViews = new List<TableView>();
	}
}
