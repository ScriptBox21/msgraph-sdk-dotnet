// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PrintTaskTriggerWithReferenceRequestBuilder.
    /// </summary>
    public partial class PrintTaskTriggerWithReferenceRequestBuilder : BaseRequestBuilder, IPrintTaskTriggerWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrintTaskTriggerWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrintTaskTriggerWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrintTaskTriggerWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrintTaskTriggerWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new PrintTaskTriggerWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the printTaskTrigger.
        /// </summary>
        /// <returns>The <see cref="IPrintTaskTriggerReferenceRequestBuilder"/>.</returns>
        public IPrintTaskTriggerReferenceRequestBuilder Reference
        {
            get
            {
                return new PrintTaskTriggerReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
