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
      
            Console.WriteLine("<!DOCTYPE html>");
            /* All ARSharp.Net Framework Code Begins from Here */
            string style = "<style>" +
                "body {" +
                "font - family: Arial;" +
                "margin: 0;" +
                "}" +
                ".header {padding: 60px;" +
                "text - align: center;" +
                "background: #1abc9c;" +
                "color: white;" +
                "font - size: 30px;" +
                "}" +
                ".content { padding: 20px; }" +
                "</style> ";


            //calling the Div Framework Tag
            DivTag div = new DivTag();
            //calling the Paragraph Framework Tag
            ParagraphTag p = new ParagraphTag();
            //calling the Paragraph Framework Tag
            TitleTag title = new TitleTag();
            BodyTag body = new BodyTag();
            HeadTag head = new HeadTag();
            HtmlTag html = new HtmlTag();
            Header1Tag h1 = new Header1Tag();

            //Main Code Starts here
            html.lang = "en";
            html.Open();
                head.Open();
                    title.Open();
                        p.P("ARSharp.NET Frame Work Page");
                    title.Close();
                    //Frame work template has not been implemeted for any Console.WriteLines
                    Console.WriteLine("<meta charset = \"UTF - 8\">");
                    Console.WriteLine("<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1\">");
            // Console.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"index.css\" media=\"screen\"/>");
            Console.WriteLine(style);
                head.Close();
                body.Open();
                    div.classes = "header";
                    div.Open();
                        h1.H1("This is a Simple ARSharp Framework Page");
                        p.P("Built from Scratch using C#, Cool Init?");
                    div.Close();
                    div.classes = "content";
                    div.Open();
                        h1.H1("This is a Simple ARSharp Framework Page");
                        p.P("What i Know about evolving!");
                        h1.H1("You're welcome to the First ARSharp Frame Work Template");
                        p.P("I know you might be confused on what ASRSharp Means");
                        h1.H1("About ARSharp!");
                        p.P("ARShpart means Abandy Roosevelt Sharp for Web, inspired from the Microsoft C# and ASP.NET");
                        h1.H1("What does ARSharp Do?");
                        p.P("ARSharp is a framework for removing the abtraction of OOP and Clases directly from you face.");
                        p.P("One key thing of a programming language is ABSTRACTION, imagine calling a Paragraph Tag with just \"p.P()\", Cool!! I Know right?");
                        h1.H1("Future of ARSharp");
                        p.P("This project intends to build a fullstack webpage using the ARSharp framework, currently the local Command Prompt handles the Compiling;" +
                            " The Compiler?Translator is currently worked on, please do feel to contact me if you would like to contribute."
                            + " The project intends to competite with .NET for Web and Jade or Pub (A JavaScript template engine)");
                        h1.H1("Contact");
                        p.P("Phone Number: +2348168187776");
                        p.P("Twitter: @dev_roosevelt");
                        p.P("LinkedIn: /rooseveltabandy");
                        p.P("Cheers!!! :)");
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


