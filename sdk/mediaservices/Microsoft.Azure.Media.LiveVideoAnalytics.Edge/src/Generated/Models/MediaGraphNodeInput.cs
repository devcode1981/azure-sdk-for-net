// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the input to any node in a media graph.
    /// </summary>
    public partial class MediaGraphNodeInput
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphNodeInput class.
        /// </summary>
        public MediaGraphNodeInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphNodeInput class.
        /// </summary>
        /// <param name="nodeName">The name of another node in the media graph,
        /// the output of which is used as input to this node.</param>
        /// <param name="outputSelectors">Allows for the selection of
        /// particular streams from another node.</param>
        public MediaGraphNodeInput(string nodeName = default(string), IList<MediaGraphOutputSelector> outputSelectors = default(IList<MediaGraphOutputSelector>))
        {
            NodeName = nodeName;
            OutputSelectors = outputSelectors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of another node in the media graph, the
        /// output of which is used as input to this node.
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets allows for the selection of particular streams from
        /// another node.
        /// </summary>
        [JsonProperty(PropertyName = "outputSelectors")]
        public IList<MediaGraphOutputSelector> OutputSelectors { get; set; }

    }
}