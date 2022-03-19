using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    class HeadTag : GlobalAttributes
    {
        public void Open()
        {
            // Console.WriteLine("<div class=" + '\u0022' + classes + '\u0022' + " id=" + '\u0022' + id + '\u0022' + ">");
            Console.Write("<head "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Console.WriteLine("> ");

        }
        public void Close()
        {
            Console.WriteLine("</head>");
        }
    }
}
