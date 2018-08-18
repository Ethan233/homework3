using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Log
    {
        public void save()
        {
            string result1 = @"D:\history.txt";
            FileStream fs = new FileStream(result1, FileMode.Append);
            StreamWriter wr = null;
            wr = new StreamWriter(fs);
            wr.WriteLine(Program.record[Program.RecordNum - 1] + "=" +Program.result);
            wr.Close();
        }
    }
}
