using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace IDReader
{
    class DataSearch
    {
        public DataSearch()
        {
        }

        public string SearchForID(DataTable dt, string id)
        {
            StringBuilder result = new StringBuilder();
            string expr = "LoadID = '" + id +"'";

            DataRow[] found = dt.Select(expr);

            if(found.Length == 0 )
            {
                return "ID Not Found";
            }

            foreach(DataRow dr in found)
            {
                for(int i = 0; i < dt.Columns.Count; i++)
                {
                    result.Append(dt.Columns[i].ColumnName);
                    result.Append(": ");
                    result.AppendLine(dr.ItemArray[i].ToString());
                }
                result.AppendLine("----------");
            }

            return result.ToString();
        }
    }
}
