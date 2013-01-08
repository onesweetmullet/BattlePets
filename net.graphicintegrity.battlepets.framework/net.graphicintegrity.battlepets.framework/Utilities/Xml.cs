using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace net.graphicintegrity.battlepets.framework.Utilities
{
    public class Xml
    {
        public static int GetMaxID(XElement xml, string elementName, string attributeName)
        {
            var _maxID = xml.Elements(elementName).Max(i => (int)i.Attribute(attributeName));
            return (int)_maxID;
        }

        public static System.Collections.Generic.IEnumerable<XElement>
            GetMatchByID(XElement xml, string elementName, string attributeName, int searchTerm)
        {
            var _query = from _x in xml.Elements(elementName)
                         where int.Parse(_x.Attribute(attributeName).Value) == searchTerm
                         select _x;

            return _query;
        }

        public static System.Collections.Generic.IEnumerable<XElement> 
            GetMatchByName(XElement xml, string elementName, string attributeName, string searchTerm)
        {
            var _query = from _x in xml.Elements(elementName)
                         where _x.Attribute(attributeName).Value.ToString().ToLower() == searchTerm.ToLower()
                         select _x;

            return _query;
        }

        public static void UpdateXML
            (                
                Dictionary<string, string> attributes, 
                XElement elementToUpdate,                
                string xmlPath,
                XElement fullXML
            )
        {
            foreach (KeyValuePair<string, string> _dictionaryEntry in attributes)
            {
                elementToUpdate.SetAttributeValue(_dictionaryEntry.Key, _dictionaryEntry.Value);
            }
            
            fullXML.Save(System.IO.Path.GetFullPath(xmlPath));
        }


    }
}
