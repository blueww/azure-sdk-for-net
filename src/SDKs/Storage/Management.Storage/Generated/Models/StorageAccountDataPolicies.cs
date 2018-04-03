// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Get Storage Account DataPolicies operation response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccountDataPolicies : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountDataPolicies class.
        /// </summary>
        public StorageAccountDataPolicies()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountDataPolicies class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Tags assigned to a resource; can be used for
        /// viewing and grouping a resource (across resource groups).</param>
        /// <param name="rules">The Storage Account DataPolicies Rules, in JSON
        /// format.</param>
        /// <param name="lastModifiedTime">Returns the date and time the
        /// DataPolicies was last modified.</param>
        public StorageAccountDataPolicies(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string rules = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?))
            : base(id, name, type, location, tags)
        {
            Rules = rules;
            LastModifiedTime = lastModifiedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Storage Account DataPolicies Rules, in JSON
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public string Rules { get; set; }

        /// <summary>
        /// Gets returns the date and time the DataPolicies was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

    }
}
