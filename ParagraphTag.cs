using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCode
{
   // class Paragraph : MainContent
   // {
        
    //    public void P(string classes, string id, string content)
    //    {
      
      //      Console.WriteLine("<p class=" + '\u0022' + classes + '\u0022' + " id="+ '\u0022' + id + '\u0022' + "> " + content + " </p>");
            
        //}
    //}
    class ParagraphTag : Compiler
    {
        public void P(string text)
        {
            Console.Write("<p "); Class(classes); Id(id); Draggable(draggable); Content(content); DataCustom(dataCustomValue, dataCustomText); Name(name); Translate(translate); Title(title); Tabindex(tabindex); Lang(lang); Dir(dir); Spellcheck(spellcheck); Contenteditable(contenteditable); Style(style); Hidden(hidden); Accesskey(accesskey);    Console.WriteLine( "> " + text + " </p>");
        }
    }
}
