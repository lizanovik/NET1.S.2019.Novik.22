using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML.Interfaces
{
    /// <summary>
    /// The custom interface for like a NLog implementations.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Include high-volume information such as protocol payloads. This log level is typically only enabled during development
        /// </summary>
        /// <param name="message">trace message</param>
        void Trace(string message);

        /// <summary>
        /// Debugging information, less detailed than trace, typically not enabled in production environment.
        /// </summary>
        /// <param name="message">debug message</param>
        void Debug(string message);

        /// <summary>
        /// Information messages, which are normally enabled in production environment
        /// </summary>
        /// <param name="message">informational message</param>
        void Info (string message);

        /// <summary>
        /// Warning messages, typically for non-critical issues, which can be recovered or which are temporary failures
        /// </summary>
        /// <param name="message">warning message</param>
        void Warn (string message);

        /// <summary>
        /// Error messages - most of the time these are Exceptions
        /// </summary>
        /// <param name="message">error message</param>
        void Error(string message);

        /// <summary>
        /// Very serious errors
        /// </summary>
        /// <param name="message">fatal error message</param>
        void Fatal(string message);
    }
}
