using System;
using System.Collections.Generic;

namespace XML.Entities
{
    /// <summary>
    /// The URL entity.
    /// </summary>
    public class URL
    {
        #region Properties
        /// <summary>
        /// Transfer protocol
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Site
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Subcategory of site
        /// </summary>
        public List<string> Segments { get; set; } = new List<string>();

        /// <summary>
        /// Key-value segment
        /// </summary>
        public List<KeyValuePair<string, string>> Parameters
        { get; set; } = new List<KeyValuePair<string, string>>(); 
        #endregion
    }
}
