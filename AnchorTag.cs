using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    class AnchorTag : GlobalAttributes
    {
        string href;

        public void Href(string href)
        {
            if (href == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("href=" + '\u0022' + href + '\u0022' + " ");
            }

        }
        public void A(string text)
        {
            Console.Write("<a "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Href(href); Console.WriteLine("> " + text + " </a>");
        }
    }
}
