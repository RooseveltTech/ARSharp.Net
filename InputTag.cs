using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    class InputTag : GlobalAttributes
    {
        public string type;
        public string value;
        public void Type(string type)
        {
            if (type == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("type=" + '\u0022' + type + '\u0022' + " ");
            }

        }
        public void Value(string value)
        {
            if (value == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("value=" + '\u0022' + value + '\u0022' + " ");
            }

        }
        public void Input()
        {
            Console.Write("<input "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Value(value);  Console.WriteLine("> ");
        }
    }
}
