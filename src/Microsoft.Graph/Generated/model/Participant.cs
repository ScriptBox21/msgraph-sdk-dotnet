// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Participant.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Participant : Entity
    {
    
		///<summary>
		/// The Participant constructor
		///</summary>
        public Participant()
        {
            this.ODataType = "microsoft.graph.participant";
        }
	
        /// <summary>
        /// Gets or sets info.
        /// The participant of the participant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "info", Required = Newtonsoft.Json.Required.Default)]
        public ParticipantInfo Info { get; set; }
    
        /// <summary>
        /// Gets or sets recording info.
        /// Information about whether the participant has recording capability.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recordingInfo", Required = Newtonsoft.Json.Required.Default)]
        public RecordingInfo RecordingInfo { get; set; }
    
        /// <summary>
        /// Gets or sets media streams.
        /// The list of media streams.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaStreams", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MediaStream> MediaStreams { get; set; }
    
        /// <summary>
        /// Gets or sets is muted.
        /// true if the participant is muted (client or server muted).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMuted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMuted { get; set; }
    
        /// <summary>
        /// Gets or sets is in lobby.
        /// true if the participant is in lobby.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isInLobby", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsInLobby { get; set; }
    
    }
}
