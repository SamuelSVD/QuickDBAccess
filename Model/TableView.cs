using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickDBAccess.Model
{
    public class TableView
    {
        [XmlAttribute]
        public string name = "";
        public Query ContentQuery = new Query();
        public Query OnDoubleClickQuery;
        public List<Query> buttonActions = new List<Query>();
    }
}
