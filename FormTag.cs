using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    class FormTag : GlobalAttributes
    {
        public string action;
        public string method;
        public void Action(string action)
        {
            if (action == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("type=" + '\u0022' + action + '\u0022' + " ");
            }

        }
        public void Method(string method)
        {
            if (method == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("method=" + '\u0022' + method + '\u0022' + " ");
            }

        }
        public void Open()
        {
            // Console.WriteLine("<div class=" + '\u0022' + classes + '\u0022' + " id=" + '\u0022' + id + '\u0022' + ">");
            Console.Write("<form "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Method(method); Action(action); Console.WriteLine("> ");
        }
        public void Close()
        {
            Console.WriteLine("</form>");
        }
    }
}
