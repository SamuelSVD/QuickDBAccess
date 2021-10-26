using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDBAccess.Model
{
    public class QuickAccess
    {
        public SQLConnection Connection = new SQLConnection();
        public List<TableView> TableViews = new List<TableView>();
    }
}
