using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML.Interfaces
{
    public interface IXmlCreator
    {
        void CreateXml<T>(IEnumerable<T> sourceList, string destinationPath);
    }
}
