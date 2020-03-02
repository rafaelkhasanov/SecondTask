using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SecondTask
{
    public class XMLData
    {
        public readonly string pathFile;
        public string ElementName { get; set; }
        public XDocument Document { get; set; }
        public IEnumerable<XElement> Elements { get; set; }

        public XMLData(string fileName)
        {
            pathFile = fileName;
            Document = XDocument.Load(fileName);
            ElementName = Document.Root.Name.ToString();
            Elements = Document.Elements(ElementName);
        }

        public XElement GetElementForName(string elementName)
        {
            return Elements.Select(c => c.Element(elementName)).FirstOrDefault();
        }

        public XAttribute GetAttributForName(string attributeName)
        {
            return Elements.Select(c => c.Attribute(attributeName)).FirstOrDefault();
        }

        public void SetValueAttributForName(string attributeName, string value)
        {
            Elements.Select(c => c.Attribute(attributeName)).FirstOrDefault().Value = value;
        }

        public void SetValueElementForName(string elementName, string value)
        {
            Elements.Select(c => c.Element(elementName)).FirstOrDefault().Value = value;
        }
        public void SaveXmlDocument()
        {
            Document.Save(pathFile);
        }

        
    }
}
