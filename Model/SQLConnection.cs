﻿using System;
using System.Xml.Serialization;

namespace QuickDBAccess.Model {
	public class SQLConnection {
		[XmlAttribute]
		public string server = "";
		[XmlAttribute]
		public string database = "";
		[XmlAttribute]
		public string user = "";
		[XmlAttribute]
		public string password = "";
		public string ConnectionString() {
			return String.Format("Server = {0}; Database = {1}; User Id = {2}; Password = {3}; ", server, database, user, password);
		}
	}
}
