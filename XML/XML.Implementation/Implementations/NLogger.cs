using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using ILogger = XML.Interfaces.ILogger;

namespace XML.Implementation.Implementations
{
    /// <summary>
    /// Custom logger based on NLog
    /// </summary>
    public class NLogger : ILogger
    {

        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// <inheritdoc cref="ILogger"/>
        /// </summary>
        public void Debug(string message)
            => logger.Debug(message);
        
        /// <summary>
        /// <inheritdoc cref="ILogger"/>
        /// </summary>
        public void Error(string message)
            => logger.Error(message);

        /// <summary>
        /// <inheritdoc cref="ILogger"/>
        /// </summary>
        public void Fatal(string message)
            => logger.Fatal(message);

        /// <summary>
        /// <inheritdoc cref="ILogger"/>
        /// </summary>
        public void Info(string message)
            => logger.Info(message);

        /// <summary>
        /// <inheritdoc cref="ILogger"/>
        /// </summary>
        public void Trace(string message)
            => logger.Trace(message);

        /// <summary>
        /// <inheritdoc cref="ILogger"/>
        /// </summary>
        public void Warn(string message)
            => logger.Warn(message);
    }
}
