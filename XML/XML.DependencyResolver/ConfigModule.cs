using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using XML.Implementation.Implementations;
using XML.Interfaces;

namespace XML.DependencyResolver
{
    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            var sourceFilePath = Path.Combine(Directory.GetCurrentDirectory(), ConfigurationManager.AppSettings["sourceFilePath"]);

            var targetFilePath = Path.Combine(Directory.GetCurrentDirectory(), ConfigurationManager.AppSettings["targetFilePath"]);
            
            this.Bind<IDataRetriever>().To<FileSystemStorage>()
                .WithConstructorArgument("sourceFilePath", sourceFilePath)
                .WithConstructorArgument("targetFilePath", targetFilePath);

            this.Bind<ILogger>().To<NLogger>();
        }
    }
}
