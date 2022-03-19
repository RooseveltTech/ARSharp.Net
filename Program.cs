using System;
using System.CodeDom.Compiler;
using System.IO;
using Microsoft.CSharp;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TextCode
{

    class Program : GlobalAttributes
    {
        [STAThread]
        static void Main(string[] args)
        {
            //   Process pr = new Process();
            // pr.StartInfo.FileName = "cmd.exe";
            //  pr.StartInfo.Arguments = "/K C:\\Users\\USER\\source\\repos\\TextCode\\bin\\Debug\\TextCode.exe>C:\\files.txt";
            //  pr.Start();
            string name = "index";

            DivTag p1 = new DivTag();
            
            p1.classes = "my man is cool oo";
            p1.title = "halsalinman";
            p1.Open();

            p1.Close();
            // System.Diagnostics.Process process = new System.Diagnostics.Process();
            // System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //   startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //  startInfo.FileName = "cmd.exe";
            //  startInfo.Arguments = "/K C:\\Users\\USER\\source\\repos\\TextCode\\bin\\Debug\\TextCode.exe > C:\\file.txt";
            //  process.StartInfo = startInfo;
            //  process.Start();
            //  process.WaitForExit();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c TextCode.exe" + "> index.txt";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
        }
    }
}


