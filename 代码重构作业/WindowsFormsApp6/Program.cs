using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{

    static class Program
    {
        public static int tab = 0;
        public static string result;
        //记录指针
        public static int Precord = 0;
        //记录数
        public static int RecordNum = 0;
        //存储记录
        public static String[] record = new String[10];
        //存储表达式
        public static String[] texts = new String[10000];
        public static string text = "";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
