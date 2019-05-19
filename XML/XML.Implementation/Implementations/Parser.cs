using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML.Entities;

namespace XML.Contracts
{
    /// <summary>
    /// Parser of URL
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// The method that parses the url address according URL entity
        /// </summary>
        /// <param name="source">source string</param>
        /// <returns>URL entity</returns>
        public URL Parse(string source)
        {
            Validate(source);
            URL url = new URL {Protocol = source.Substring(0, 8)};
            var parsedString = source.Substring(8).Split('/', '?');
            url.Host = parsedString[0];
            for (int i = 1; i < parsedString.Length; i++)
            {
                if (!parsedString[i].Contains("="))
                {
                    url.Segments.Add(parsedString[i]);
                }
                else
                {
                    var parameters = parsedString[i].Split('=');
                    url.Parameters.Add(new KeyValuePair<string, string>(parameters[0], parameters[1]));
                }
            }

            return url;

        }

        private static void Validate(string source)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"{nameof(source)} cannot be null!");
            }

            if (source.Length == 0)
            {
                throw new ArgumentNullException($"{nameof(source)} cannot be empty!");
            }
        }
    }
}
