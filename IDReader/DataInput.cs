using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace IDReader
{
    class DataInput
    {
        readonly string dir = @"C:\AGVIDReader\Data\";
        readonly char delimiter = ';';
        readonly string[] cols =
            {"LoadID",
            "Target",
            "OrderNumber",
            "Data1",
            "Data2",
            "Date",
            "Time",
            "Data3",
            "Data4"};
        string currFile;

        public DataInput()
        {
            currFile = "";
        }

        public string GetFile()
        {
            var directory = new DirectoryInfo(dir);

            if(!directory.Exists)
            {
                return "Directory not found!";
            }

            if(directory.GetFiles().Length == 0)
            {
                return "Directory is empty!";
            }

            var file = (from f in directory.GetFiles() orderby f.LastWriteTime descending select f).First();

            if (file.Length > 0)
            {
                currFile = file.FullName;

                return "Loaded file: " + file.Name + " (File Last Write Time: " + file.LastWriteTime +")";
            }

            else
            {
                return "File " + file.Name + " is empty! (File Last Write Time: " + file.LastWriteTime + ")";
            }
        }

        public DataTable GetData()
        {
            DataTable dt = new DataTable("Data");

            foreach (string col in cols)
            {
                dt.Columns.Add(col, typeof(string));
            }

            string[] lines = File.ReadAllLines(currFile);

            if( lines.Length > 0)
            {
                foreach (string line in lines)
                {
                    var row = line.Split(delimiter);

                    DataRow dr = dt.NewRow();

                    for(int i=0; i < cols.Length; i++)
                    {
                        dr[i] = row[i].ToString();
                    }

                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
