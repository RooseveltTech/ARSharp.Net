using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    
    using System;
    using System.Collections.Generic;
  
    using System.Text;
    using System.Threading.Tasks;
    class DivTag: GlobalAttributes
    {

        public void Open()
        {
            // Console.WriteLine("<div class=" + '\u0022' + classes + '\u0022' + " id=" + '\u0022' + id + '\u0022' + ">");
            Console.Write("<div "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Console.WriteLine("> ");
   
        }
        public void Close()
        {
            Console.WriteLine("</div>");
        }
    }
}
