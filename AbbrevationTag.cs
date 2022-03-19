using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    class AbbrevationTag : GlobalAttributes
    {
        public void Abbr(string text)
        {
            Console.Write("<abbr "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Console.WriteLine("> " + text + " </abbr>");
        }
    }
}
