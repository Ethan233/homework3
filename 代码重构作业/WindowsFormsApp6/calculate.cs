using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace WindowsFormsApp6
{
    public class calculate
    {
        //加载js引擎
        Microsoft.JScript.Vsa.VsaEngine ve = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();

        public string equal() 
        {
            try
            {
                //结果
                Program.result = Microsoft.JScript.Eval.JScriptEvaluate(Program.text, ve).ToString();
                Program.record[Program.RecordNum] = Program.text;
                Program.text = Program.result;
                Program.RecordNum++;
                Program.Precord = Program.RecordNum;;

            }
            catch (Exception)
            {
                Program.result = "输入错误！";
                Program.text = "";
                Program.tab = 0;
            }
            return Program.result;
        }
        internal static string move(int pnew)
        {
            Program.Precord = pnew;
            if (Program.Precord < 0)
            {
                Program.Precord = 0;
            }
            if (Program.Precord > Program.RecordNum)
            {
                Program.Precord = Program.RecordNum;
            }
            Program.text = Program.record[Program.Precord];

            return  Program.record[Program.Precord];
        }//左右移动

    }
}
