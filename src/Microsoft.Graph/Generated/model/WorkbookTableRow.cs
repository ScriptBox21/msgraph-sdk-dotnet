// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook Table Row.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookTableRow : Entity
    {
    
		///<summary>
		/// The WorkbookTableRow constructor
		///</summary>
        public WorkbookTableRow()
        {
            this.ODataType = "microsoft.graph.workbookTableRow";
        }
	
        /// <summary>
        /// Gets or sets index.
        /// Returns the index number of the row within the rows collection of the table. Zero-indexed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "index", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Index { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// Represents the raw values of the specified range. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "values", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Values { get; set; }
    
    }
}

