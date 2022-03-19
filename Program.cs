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
            //Specify the Path to the File Location you are about to create;
            string fileLocation = @"C:\Users\USER\Documents\ARS\";
            //specify the name of file and extention you are about to create or edit
            string nameOfFile = "index.html";
            //creating a path for the ARSharp.NET Framework
            string path = $"{fileLocation}{nameOfFile}";
            Console.Write("");
            Console.Write("");
            Console.Write("");

            /* All ARSharp.Net Framework Code Begins from Here */



            //calling the Div Framework Tag
            DivTag div = new DivTag();
            //calling the Paragraph Framework Tag
            ParagraphTag p = new ParagraphTag();
            //calling the Paragraph Framework Tag
            BodyTag body = new BodyTag();
            HeadTag head = new HeadTag();
            HtmlTag html = new HtmlTag();

            //Main Code Starts here
            html.Open();
                head.Open();
                head.Close();
                body.Open();
                    div.classes = "my man is cool oo";
                    div.title = "halsalinman";
                    div.Open();
                    div.classes = "";
                        div.Open();
                        div.Close();
                    div.Close();
                body.Close();
            html.Close();












































































































































            /* All ARSharp.Net Framework Ends Here
             *Do not Edit Beyound this line :) 
             Thank you.
            Don't even think about it!!! 
            High level warning
             */

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c TextCode.exe" + $"> {path}";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
        }
    }
}


