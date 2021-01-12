// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with AfdErrorResponse
    /// information.
    /// </summary>
    public partial class AfdErrorResponseException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public AfdErrorResponse Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the AfdErrorResponseException class.
        /// </summary>
        public AfdErrorResponseException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AfdErrorResponseException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public AfdErrorResponseException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AfdErrorResponseException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public AfdErrorResponseException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
