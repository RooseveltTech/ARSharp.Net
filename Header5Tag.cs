using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    class Header5Tag : GlobalAttributes
    {
        public void H5(string text)
        {
            Console.Write("<h5 "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Console.WriteLine("> " + text + " </h5>");
        }
    }
}
