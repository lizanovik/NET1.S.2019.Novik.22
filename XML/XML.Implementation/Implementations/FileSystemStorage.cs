using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML.Contracts;
using XML.Entities;
using XML.Interfaces;

namespace XML.Implementation.Implementations
{
    public class FileSystemStorage : IDataRetriever
    {
        private readonly string sourceFilePath;
        private readonly Parser parser;
        private readonly ILogger logger;

        public FileSystemStorage(string sourceFilePath, Parser parser, ILogger logger)
        {
            this.logger = logger ?? throw new ArgumentNullException($"{nameof(logger)} cannot be null");
            this.parser = parser ?? throw new ArgumentNullException($"{nameof(parser)} cannot be null");
            this.sourceFilePath = sourceFilePath ?? throw new ArgumentNullException($"{nameof(sourceFilePath)} cannot be null");
        }

        public IEnumerable<URL> LoadData()
        {
            IEnumerable<string> urlList = File.ReadLines(sourceFilePath);
            var parsedUrls = new List<URL>();

            foreach (var url in urlList)
            {
                if (url.Contains("https://"))
                {
                    parsedUrls.Add(parser.Parse(url));
                }
                else
                {
                    logger.Debug($"Cannot parse {nameof(url)}");
                }
            }

            return parsedUrls;
        }
    }
}
