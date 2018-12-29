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
    /// The Storage Account ManagementPolicies Rules, in JSON format. See more
    /// details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagementPoliciesRulesSetParameter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagementPoliciesRulesSetParameter class.
        /// </summary>
        public ManagementPoliciesRulesSetParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagementPoliciesRulesSetParameter class.
        /// </summary>
        /// <param name="version">The policy version expressed as x.x.</param>
        /// <param name="rules">The Storage Account ManagementPolicies Rules.
        /// See more details in:
        /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.</param>
        public ManagementPoliciesRulesSetParameter(string version = default(string), IList<ManagementPolicyRule> rules = default(IList<ManagementPolicyRule>))
        {
            Version = version;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the policy version expressed as x.x.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the Storage Account ManagementPolicies Rules. See more
        /// details in:
        /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public IList<ManagementPolicyRule> Rules { get; set; }

    }
}
