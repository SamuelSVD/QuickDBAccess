using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickDBAccess.Model
{
    public class Query
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public string command;
        public List<QueryParameter> parameters = new List<QueryParameter>();
    }
}
