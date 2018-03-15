using System;
using System.Collections;
using System.IO;

namespace taskDEV4
{ /// <summary>
  /// EntryPoint
  /// </summary>
    class EnteryPoint
    {
        static void Main(string[] args)
        {
            ArrayList result = new ArrayList();
            string XMLstring = File.ReadAllText(args[0]);
            parseXML parsing = new parseXML();
            XMLstring = parsing.DelFirstStringFromXMLFile(XMLstring);
            string Element = parsing.GetElement(XMLstring);
            XMLstring = parsing.DelElement(XMLstring, Element);
            TagAndName b = new TagAndName();
            string TAN;
            TAN = b.GetTagAndName(XMLstring);
            XMLstring = b.DeltagAndName(XMLstring, TAN);
            while (XMLstring != String.Empty)
            {
                if (XMLstring != String.Empty)
                {
                    string temp, Buffer;
                    temp = b.getvalue(XMLstring);
                    Buffer = b.GetTag(XMLstring);
                    result.Add(Element + "-" + TAN + "-" + temp);
                    XMLstring = b.delValue(XMLstring, temp, Buffer);
                }
                else
                {
                    result.Sort();
                }
            }
            Console.ReadLine();
        }
    }
}
