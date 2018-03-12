using System.Text;

namespace taskDEV4
{
    class parseXML
    {
        /// <summary>
        /// Method delete first string
        /// </summary>
        public string DelFirstStringFromXMLFile(string XMLstring)
        {
            string newstring, parsestring;
            parsestring = XMLstring;
            parsestring = parsestring.Remove(0, 39).Trim();//DEL FIRST STRING
            newstring = parsestring;
            return newstring;
        }
        /// <summary>
        /// Method get first tag
        /// </summary>
        public string GetElement(string XMLstring)
        {
            StringBuilder Element=new StringBuilder("");
            int beginElement = XMLstring.IndexOf("<");
            int endElement = XMLstring.IndexOf(">");
            for (int i = beginElement +1; i < endElement; i++) 
            {
                Element.Append(XMLstring[i]);
            }
            return Element.ToString();
        }
        /// <summary>
        /// Method delete first tag from string
        /// </summary>
        public string DelElement(string XMLstring,string Element)
        {
            StringBuilder newStr = new StringBuilder(XMLstring);
            int beginElement = XMLstring.IndexOf("<");
            int endElement = XMLstring.IndexOf(">");
            int length = endElement - beginElement;
            newStr.Remove(beginElement,length+1);
            StringBuilder newstr2 = new StringBuilder("");
            Element = "/" + Element;
            int endofthestring = XMLstring.IndexOf(Element);
            for (int i=0;i<endofthestring-Element.Length-2;i++)
            {
                newstr2.Append(newStr[i]);
            }
            return newstr2.ToString();
        }
    }
}

