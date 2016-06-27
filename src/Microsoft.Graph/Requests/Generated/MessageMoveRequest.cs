// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type MessageMoveRequest.
    /// </summary>
    public partial class MessageMoveRequest : BaseRequest, IMessageMoveRequest
    {
    
        /// <summary>
        /// Constructs a new MessageMoveRequest.
        /// </summary>
        public MessageMoveRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options,
            string destinationId = null)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new MessageMoveRequestBody();
            this.RequestBody.DestinationId = destinationId;
        }
    
        /// <summary>
        /// Gets the request body.
        /// </summary>
        public MessageMoveRequestBody RequestBody { get; private set; }
    
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public Task<Message> PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>TheMessage</returns>
        public Task<Message> PostAsync(CancellationToken cancellationToken)
        {
    
            return this.SendAsync<Message>(this.RequestBody, cancellationToken);
    
        }
    
        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageMoveRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageMoveRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    
    }
}