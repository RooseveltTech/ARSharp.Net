using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    using System;
    class GlobalAttributes
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
        public void Class(string classes="")
        {
            if(classes == null )
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
            if (dataCustomValue == null || dataCustomText==null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("data-"+ dataCustomValue + "=" +'\u0022'  + dataCustomText + '\u0022' + " ");
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

    }
}
