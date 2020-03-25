// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomServiceException.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Resources.Exceptions
{
    using System;

    /// <summary>
    /// Class for Custom Service Exception
    /// </summary>
    public class CustomServiceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceException" /> class.
        /// </summary>
        public CustomServiceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceException" /> class.
        /// </summary>
        /// <param name="message">string message</param>
        public CustomServiceException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceException" /> class.
        /// </summary>
        /// <param name="message">String Message</param>
        /// <param name="innerException">Inner Exception</param>
        public CustomServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
