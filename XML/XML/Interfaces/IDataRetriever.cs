using System.Collections.Generic;
using XML.Entities;

namespace XML.Interfaces
{
    /// <summary>
    /// The interface for custom data retriever.
    /// </summary>
    public interface IDataRetriever
    {
        /// <summary>
        /// Loading data from source
        /// </summary>
        /// <returns>Interpreted to URL loaded data</returns>
        IEnumerable<URL> LoadData();
    }
}
