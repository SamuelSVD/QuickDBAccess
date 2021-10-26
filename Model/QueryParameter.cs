using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuickDBAccess.Model
{
    public class QueryParameter
    {
        [XmlAttribute]
        public string type;
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public string autoSourceColumnName;
        [XmlIgnore]
        public Control c;
        public SqlDbType getSqlDbType()
        {
            if (type == "int")
            {
                return SqlDbType.Int;
            }
            if (type == "datetime")
            {
                return SqlDbType.DateTime;
            }
            return SqlDbType.VarChar;
        }
        public string getValue()
        {
            if (c.GetType().Equals(typeof(TextBox))) return ((TextBox)c).Text;
            if (c.GetType().Equals(typeof(DateTimePicker))) return ((DateTimePicker)c).Text;
            if (c.GetType().Equals(typeof(NumericUpDown))) return ((NumericUpDown)c).Value.ToString();
            else return null;
        }
    }
}
