using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
    class ImageTag : GlobalAttributes
    {
        public string src;
        public string alt;
        public string width;
        public string height;
        public void Src(string src)
        {
            if (src == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("src=" + '\u0022' + src + '\u0022' + " ");
            }

        }
        public void Alt(string alt)
        {
            if (alt == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("alt=" + '\u0022' + alt + '\u0022' + " ");
            }

        }
        public void Width(string width)
        {
            if (width == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("src=" + '\u0022' + width + '\u0022' + " ");
            }

        }
        public void Height(string height)
        {
            if (height == null)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("src=" + '\u0022' + height + '\u0022' + " ");
            }

        }
        public void Img(string text)
        {
            Console.Write("<img "); Src(src); Alt(alt); Width(width); Height(height); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey); Console.WriteLine("> ");
        }
    }
}
