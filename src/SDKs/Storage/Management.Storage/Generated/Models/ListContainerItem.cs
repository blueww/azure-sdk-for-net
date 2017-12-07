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
    /// TODO
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ListContainerItem : BlobResource
    {
        /// <summary>
        /// Initializes a new instance of the ListContainerItem class.
        /// </summary>
        public ListContainerItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListContainerItem class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="publicAccess">TODO. Possible values include:
        /// 'container', 'blob'</param>
        /// <param name="leaseStatus">TODO. Possible values include: 'locked',
        /// 'unlocked'</param>
        /// <param name="leaseState">TODO. Possible values include:
        /// 'available', 'leased', 'expired', 'breaking', 'broken'</param>
        /// <param name="leaseDuration">TODO. Possible values include:
        /// 'infinite', 'fixed'</param>
        /// <param name="metadata">TODO</param>
        /// <param name="immutabilityPolicy">TODO</param>
        /// <param name="legalHold">TODO</param>
        public ListContainerItem(string id = default(string), string name = default(string), string type = default(string), PublicAccess? publicAccess = default(PublicAccess?), System.DateTime? lastModifiedTime = default(System.DateTime?), LeaseStatus? leaseStatus = default(LeaseStatus?), LeaseState? leaseState = default(LeaseState?), LeaseDuration? leaseDuration = default(LeaseDuration?), IDictionary<string, string> metadata = default(IDictionary<string, string>), ImmutabilityPolicyProperties immutabilityPolicy = default(ImmutabilityPolicyProperties), LegalHold legalHold = default(LegalHold))
            : base(id, name, type)
        {
            PublicAccess = publicAccess;
            LastModifiedTime = lastModifiedTime;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            Metadata = metadata;
            ImmutabilityPolicy = immutabilityPolicy;
            LegalHold = legalHold;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets TODO. Possible values include: 'container', 'blob'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicAccess")]
        public PublicAccess? PublicAccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets TODO. Possible values include: 'locked', 'unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "properties.leaseStatus")]
        public LeaseStatus? LeaseStatus { get; private set; }

        /// <summary>
        /// Gets TODO. Possible values include: 'available', 'leased',
        /// 'expired', 'breaking', 'broken'
        /// </summary>
        [JsonProperty(PropertyName = "properties.leaseState")]
        public LeaseState? LeaseState { get; private set; }

        /// <summary>
        /// Gets TODO. Possible values include: 'infinite', 'fixed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.leaseDuration")]
        public LeaseDuration? LeaseDuration { get; private set; }

        /// <summary>
        /// Gets or sets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.immutabilityPolicy")]
        public ImmutabilityPolicyProperties ImmutabilityPolicy { get; private set; }

        /// <summary>
        /// Gets TODO
        /// </summary>
        [JsonProperty(PropertyName = "properties.LegalHold")]
        public LegalHold LegalHold { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ImmutabilityPolicy != null)
            {
                ImmutabilityPolicy.Validate();
            }
        }
    }
}
