using Ninject;
using System.Configuration;
using System.IO;
using XML.Contracts;
using XML.DependencyResolver;
using XML.Interfaces;

namespace XML.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ConfigModule());
            IDataRetriever source = kernel.Get<IDataRetriever>();
            XmlCreator.Create(source.LoadData(), Path.Combine(Directory.GetCurrentDirectory(), ConfigurationManager.AppSettings["targetFilePath"]));
        }
    }
}
