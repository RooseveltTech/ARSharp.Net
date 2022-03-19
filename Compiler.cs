
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Documents;
using System.Reflection;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Diagnostics;
using System.CodeDom;

namespace TextCode
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.Windows.Documents;
    using System.Reflection;
    using System.CodeDom.Compiler;
    using Microsoft.CSharp;
    using System.Diagnostics;
    using System.CodeDom;
    public partial class Compiler : Form
    {
        public string id;
        public string content;
        public string classes;
        public string accesskey;
        public string draggable;
        public string hidden;
        public string style;
        public string contenteditable;
        public string dataCustomValue;
        public string dataCustomText;
        public string dir;
        public string lang;
        public string spellcheck;
        public string tabindex;
        public string title;
        public string translate;
        public string name;
        public string breaks;
        public string value;



        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        String path = "";
        private BindingFlags userParameters;

        public Compiler()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Click += new System.EventHandler(this.button1_Click);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // to open a new file //

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("You need to save first");
            }
            else
            {
                richTextBox1.Text = string.Empty;
               // Text = "Untitled";
            }
        }

        // to open a file//

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt|PDF file|*.pdf|Word File|*.doc|HTML file|*.html|ARS file|*.ars", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        richTextBox1.Text = await sr.ReadToEndAsync();
                    }
                }
            }


        }

        internal void openToolStripMenuItem1_Click(object sender, object e)
        {
            throw new NotImplementedException();
        }

        
        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                }

            }
            else
            {
                MessageBox.Show("The file is empty");
            }
        }

        // to save a file //

     

        // to exit and close notepad//

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // to perform undo operation on the text//

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        // to perform redo operation//

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        // to cut some data from the textbox //

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        // to copy some data in the textbox //

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        // to paste some copied data//

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        // to select all the text in the text field //

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        // to display date and time //

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        // for font options //

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        // for providing color to the text //

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(richTextBox1.Text);
                        MessageBox.Show("File Save Successfully", "2x0 Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        richTextBox1.Text = "";
                    }
                }
            }
        }

        public async void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (path == String.Empty)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        path = sfd.FileName;
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(richTextBox1.Text);
                            MessageBox.Show("File Save Successfully", "ARSharp Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          


             
                        }
                       
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(richTextBox1.Text);
                    MessageBox.Show("File Save Successfully", "ARSharp Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    richTextBox1.Text = "";
                }
            }
        }

        private void selectAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Compiler_Load(object sender, EventArgs e)
        {

        }





        public void Id(string id)

        {
            if (id == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("id=" + '\u0022' + id + '\u0022' + " ");
            }


        }
        public void Text(string text)
        {
            Console.WriteLine(text);
        }
        public void Class(string classes = "")
        {
            if (classes == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("class=" + '\u0022' + classes + '\u0022' + " ");
            }

        }
        public void Draggable(string draggable)
        {
            if (draggable == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("draggable=" + '\u0022' + draggable + '\u0022' + " ");
            }

        }
        public void Content(string content)
        {
            if (content == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("content=" + '\u0022' + content + '\u0022' + " ");
            }

        }
        public void Accesskey(string accesskey)
        {
            if (accesskey == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("accesskey=" + '\u0022' + accesskey + '\u0022' + " ");
            }

        }
        public void Hidden(string hidden)
        {
            if (hidden == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("hidden=" + '\u0022' + hidden + '\u0022' + " ");
            }

        }
        public void Style(string style)
        {
            if (style == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("style=" + '\u0022' + style + '\u0022' + " ");
            }

        }
        public void Contenteditable(string contenteditable)
        {
            if (contenteditable == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("contenteditable=" + '\u0022' + contenteditable + '\u0022' + " ");
            }

        }
        public void DataCustom(string dataCustomValue, string dataCustomText)
        {
            if (dataCustomValue == null || dataCustomText == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("data-" + dataCustomValue + "=" + '\u0022' + dataCustomText + '\u0022' + " ");
            }

        }
        public void Dir(string dir)
        {
            if (dir == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("dir=" + '\u0022' + dir + '\u0022' + " ");
            }

        }
        public void Lang(string lang)
        {
            if (lang == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("lang=" + '\u0022' + lang + '\u0022' + " ");
            }

        }
        public void Spellcheck(string spellcheck)
        {
            if (spellcheck == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("spellcheck=" + '\u0022' + spellcheck + '\u0022' + " ");
            }

        }
        public void Tabindex(string tabindex)
        {
            if (tabindex == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("tabindex=" + '\u0022' + tabindex + '\u0022' + " ");
            }

        }
        public void Title(string title)
        {
            if (title == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("title=" + '\u0022' + title + '\u0022' + " ");
            }

        }
        public void Translate(string translate)
        {
            if (translate == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("translate=" + '\u0022' + translate + '\u0022' + " ");
            }

        }
        public void Name(string name)
        {
            if (translate == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("name=" + '\u0022' + name + '\u0022' + " ");
            }

        }
        public void Data(string value)
        {
            if (translate == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("value=" + '\u0022' + value + '\u0022' + " ");
            }

        }
        public void br()
        {

            Console.WriteLine("<br>");

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

       

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "Out.exe";
            Button ButtonObject = (Button)sender;

            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            //Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;



            string source1 = File.ReadAllText(@"C:\Users\USER\source\repos\TextCode\GlobalAttributes.cs");
            string source2 = File.ReadAllText(@"C:\Users\USER\source\repos\TextCode\DivTag.cs");
            string source3 = File.ReadAllText(@"C:\Users\USER\Desktop\hello.cs");
            var references = new string[] { "System.dll", "System.Core.Dll" };
            var results = CompileCsharpSource(new[] { source1, source2, source3 }, "App.exe", references);


          //  parameters.ReferencedAssemblies.AddRange(references);
          //  string outputDirectory = Directory.GetCurrentDirectory();
           // parameters.OutputAssembly = Path.Combine(outputDirectory, "Test.dll");

          //  CompilerResults results = icc.CompileAssemblyFromSource(parameters, richTextBox1.Text);

            if (results.Errors.Count > 0)
            {
               
                foreach (CompilerError CompErr in results.Errors)
                {
                    MessageBox.Show(richTextBox1.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine);
                }
            }
            else
            {
                //Successful Compile
              
                MessageBox.Show("Success!");
                //If we clicked run then launch our EXE
                if (ButtonObject.Text == "Run") {
                    Process.Start(Output);
                } 
            }
        }

        private static CompilerResults CompileCsharpSource(string[] sources, string output, params string[] references)
        {
            var parameters = new CompilerParameters(references, output);
            parameters.GenerateExecutable = true;
            using (var provider = new CSharpCodeProvider())
                return provider.CompileAssemblyFromSource(parameters, sources);
           
        }
    }
}
