
using System.Text;

namespace taskDEV4
{
    class TagAndName
    {
        /// <summary>
        /// Method get tag and name
        /// </summary>
        public string GetTagAndName(string XMLstring)
        {
            StringBuilder Element = new StringBuilder("");
            int beginElement = XMLstring.IndexOf("<");
            int endElement = XMLstring.IndexOf(" ");
            int endElement1 = XMLstring.IndexOf("=");
            int endElement2 = XMLstring.IndexOf(">");
            for (int i = beginElement+1 ; i < endElement; i++)
                {
                    Element.Append(XMLstring[i]);
                }
            Element.Append("-");
            int endName = XMLstring.IndexOf(Element + "<");
            for (int i = endElement; i < endElement1; i++)
            {
                Element.Append(XMLstring[i]);
            }
            Element.Append("-");
            for (int i = endElement1+2; i < endElement2-1; i++) 
            {
                Element.Append(XMLstring[i]);
            }
            return Element.ToString();
        }
        /// <summary>
        /// Method delete tag and name from string
        /// </summary>
        public string DeltagAndName(string XMLstring,string TAN)
        {
            int a1= XMLstring.IndexOf("<");
            int a2= XMLstring.IndexOf(" ");
            StringBuilder temp = new StringBuilder("/");
            for(int i=a1+1;i<a2;i++)
            {
                temp.Append(XMLstring[i]);
            }
            int length = temp.Length;
            StringBuilder NewStr=new StringBuilder(XMLstring);
            int EndOfTheString = XMLstring.IndexOf(">")+1;
            NewStr.Remove(0, EndOfTheString);
            int EndOfTheString1 = XMLstring.IndexOf(temp.ToString());
            StringBuilder newstr2 = new StringBuilder(" ");
            for (int i=0;i< EndOfTheString1 - temp.Length - TAN.Length-1; i++) 
            {
                newstr2.Append(NewStr[i]);
            }
            return newstr2.ToString();
        }
        /// <summary>
        /// Method get value's
        /// </summary>
        public string getvalue(string XMLstring)
        {
            StringBuilder value = new StringBuilder("");
            int beginvalue = XMLstring.IndexOf("<");
            int endvalue = XMLstring.IndexOf(">");
            for (int i = beginvalue + 1; i < endvalue; i++) //+1 0
            {
                value.Append(XMLstring[i]);
            }
            value.Append("-");
            return value.ToString();
        }
        /// <summary>
        /// Method get Tag's
        /// </summary>
        public string GetTag(string XMLstring)
        {
            StringBuilder value = new StringBuilder("");

            int beginvalue = XMLstring.IndexOf("<");
            int endvalue = XMLstring.IndexOf(">");
            int endofthestring = XMLstring.IndexOf("/");
            for (int i = endvalue + 1; i < endofthestring - 1; i++) //+1 -1
            {
                value.Append(XMLstring[i]);
            }
            return value.ToString();
        }
        /// <summary>
        /// Method Delete tag's and value's
        /// </summary>
        public string delValue(string XMLstring, string temp, string Buffer)
        {
            StringBuilder newstr = new StringBuilder(XMLstring);
            int beginElement = XMLstring.IndexOf("<");
            int endElement = XMLstring.IndexOf("/" + temp);
            int length = (2 * temp.Length + 3 + Buffer.Length);
            newstr.Remove(beginElement, length);
            return newstr.ToString();
        }
    }
}
