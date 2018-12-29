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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object to define the number of days after last modification.
    /// </summary>
    public partial class DateAfterModification
    {
        /// <summary>
        /// Initializes a new instance of the DateAfterModification class.
        /// </summary>
        public DateAfterModification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DateAfterModification class.
        /// </summary>
        /// <param name="daysAfterModificationGreaterThan">Integer value
        /// indicating the age in days after last modification</param>
        public DateAfterModification(int? daysAfterModificationGreaterThan = default(int?))
        {
            DaysAfterModificationGreaterThan = daysAfterModificationGreaterThan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets integer value indicating the age in days after last
        /// modification
        /// </summary>
        [JsonProperty(PropertyName = "daysAfterModificationGreaterThan")]
        public int? DaysAfterModificationGreaterThan { get; set; }

    }
}
