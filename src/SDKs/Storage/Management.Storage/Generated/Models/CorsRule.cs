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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies a CORS rule for the Blob service.
    /// </summary>
    public partial class CorsRule
    {
        /// <summary>
        /// Initializes a new instance of the CorsRule class.
        /// </summary>
        public CorsRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorsRule class.
        /// </summary>
        /// <param name="allowedOrigins">Required if CorsRule element is
        /// present. Specify the origin domains separated by comma, which will
        /// be allowed via CORS , or "*" to allow all domains.</param>
        /// <param name="allowedMethods">Required if CorsRule element is
        /// present. Specify the HTTP methods separated by comma, which will be
        /// allowed to be executed by the origin.</param>
        /// <param name="maxAgeInSeconds">Required if CorsRule element is
        /// present. The number of seconds that the client/browser should cache
        /// a preflight response.</param>
        /// <param name="exposedHeaders">Required if CorsRule element is
        /// present. Specify the response headers separated by comma, which
        /// will be exposed to CORS clients.</param>
        /// <param name="allowedHeaders">Required if CorsRule element is
        /// present. Specify the headers separated by comma, which will be
        /// allowed to be part of the cross-origin request.</param>
        public CorsRule(string allowedOrigins, string allowedMethods, int maxAgeInSeconds, string exposedHeaders, string allowedHeaders)
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            MaxAgeInSeconds = maxAgeInSeconds;
            ExposedHeaders = exposedHeaders;
            AllowedHeaders = allowedHeaders;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required if CorsRule element is present. Specify the
        /// origin domains separated by comma, which will be allowed via CORS ,
        /// or "*" to allow all domains.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOrigins")]
        public string AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. Specify the
        /// HTTP methods separated by comma, which will be allowed to be
        /// executed by the origin.
        /// </summary>
        [JsonProperty(PropertyName = "allowedMethods")]
        public string AllowedMethods { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. The number of
        /// seconds that the client/browser should cache a preflight response.
        /// </summary>
        [JsonProperty(PropertyName = "maxAgeInSeconds")]
        public int MaxAgeInSeconds { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. Specify the
        /// response headers separated by comma, which will be exposed to CORS
        /// clients.
        /// </summary>
        [JsonProperty(PropertyName = "exposedHeaders")]
        public string ExposedHeaders { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. Specify the
        /// headers separated by comma, which will be allowed to be part of the
        /// cross-origin request.
        /// </summary>
        [JsonProperty(PropertyName = "allowedHeaders")]
        public string AllowedHeaders { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AllowedOrigins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedOrigins");
            }
            if (AllowedMethods == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedMethods");
            }
            if (ExposedHeaders == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExposedHeaders");
            }
            if (AllowedHeaders == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedHeaders");
            }
        }
    }
}
