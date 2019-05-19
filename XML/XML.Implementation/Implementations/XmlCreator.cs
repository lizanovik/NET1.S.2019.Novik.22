using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XML.Entities;
using XML.Interfaces;

namespace XML.Implementation.Implementations
{
    /// <summary>
    /// Class-interpreter url to xml
    /// </summary>
    public static class XmlCreator//: IXmlCreator
    {
        /// <summary>
        /// The method that creates Xml from list of urls.
        /// </summary>
        /// <param name="sourceList">Url list</param>
        /// <param name="destinationPath">destination path</param>
        public static void CreateXml(IEnumerable<URL> sourceList, string destinationPath)
        {
            XDocument document = new XDocument();
            XElement root = new XElement("urlAddresses");
                //var urlList = sourceList as IEnumerable<URL>;

            foreach (var item in sourceList)
            {
                root.Add(CreateXmlElement(item));
            }

            document.Add(root);
            document.Save(destinationPath);
        }

        private static XElement CreateXmlElement(URL url)
        {
            XElement xElement = new XElement("urlAdresses");
            XElement content = new XElement("host", new XAttribute("name", url.Host));
            xElement.Add(content);
            XElement uri = new XElement("uri");
            foreach (var item in url.Segments)
            {
                uri.Add(new XElement("segment", item));
            }

            xElement.Add(uri);
            XElement parameters = new XElement("parameters");
            foreach (var item in url.Parameters)
            {
                parameters.Add(new XElement("parameter", new XAttribute("value", item.Value),
                    new XAttribute("key", item.Key)));
            }

            xElement.Add(parameters);
            return xElement;
        }
    }
}
