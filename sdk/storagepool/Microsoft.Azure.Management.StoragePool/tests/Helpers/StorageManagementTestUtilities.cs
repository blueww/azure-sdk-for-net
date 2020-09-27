// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Microsoft.StoragePool;
using ResourceGroups.Tests;

namespace Storage.Tests.Helpers
{
    public static class StorageManagementTestUtilities
    {
        public static bool IsTestTenant = false;
        private static HttpClientHandler Handler = null;

        // These should be filled in only if test tenant is true
#if DNX451
        private static string certName = null;
        private static string certPassword = null;
#endif
        private const string testSubscription = null;
        private static Uri testUri = null;

        // These are used to create default accounts
        public static string DefaultLocation = IsTestTenant ? null : "eastus2(stage)";
        public static string DefaultRGLocation = IsTestTenant ? null : "eastus2";
        //public static Dictionary<string, string> DefaultTags = new Dictionary<string, string> 
        //    {
        //        {"key1","value1"},
        //        {"key2","value2"}
        //    };

        public static ResourceManagementClient GetResourceManagementClient(MockContext context, RecordedDelegatingHandler handler)
        {
            if (IsTestTenant)
            {
                return null;
            }
            else
            {
                handler.IsPassThrough = true;
                ResourceManagementClient resourcesClient = context.GetServiceClient<ResourceManagementClient>(handlers: handler);
                return resourcesClient;
            }
        }

        //public static string GetTanentId()
        //{
        //    string tenantId = null;
        //    if (HttpMockServer.Mode == HttpRecorderMode.Record)
        //    {
        //        var environment = TestEnvironmentFactory.GetTestEnvironment();
        //        HttpMockServer.Variables[ConnectionStringKeys.AADTenantKey] = environment.Tenant;
        //        tenantId = environment.Tenant;
        //    }
        //    else if (HttpMockServer.Mode == HttpRecorderMode.Playback)
        //    {
        //        tenantId = HttpMockServer.Variables[ConnectionStringKeys.AADTenantKey];
        //    }
        //    return tenantId;
        //}

        //public static string GetServicePrincipalId()
        //{
        //    string servicePrincipalId = null;
        //    if (HttpMockServer.Mode == HttpRecorderMode.Record)
        //    {
        //        var environment = TestEnvironmentFactory.GetTestEnvironment();
        //        HttpMockServer.Variables[ConnectionStringKeys.ServicePrincipalKey] = environment.ConnectionString.KeyValuePairs.GetValueUsingCaseInsensitiveKey(ConnectionStringKeys.ServicePrincipalKey);
        //        servicePrincipalId = HttpMockServer.Variables[ConnectionStringKeys.ServicePrincipalKey];
        //    }
        //    else if (HttpMockServer.Mode == HttpRecorderMode.Playback)
        //    {
        //        servicePrincipalId = HttpMockServer.Variables[ConnectionStringKeys.ServicePrincipalKey];
        //    }
        //    return servicePrincipalId;
        //}

        //public static string GetServicePrincipalSecret()
        //{
        //    string servicePrincipalSecret = null;
        //    if (HttpMockServer.Mode == HttpRecorderMode.Record)
        //    {
        //        var environment = TestEnvironmentFactory.GetTestEnvironment();
        //        servicePrincipalSecret = environment.ConnectionString.KeyValuePairs.GetValueUsingCaseInsensitiveKey(ConnectionStringKeys.ServicePrincipalSecretKey);
        //    }
        //    else if (HttpMockServer.Mode == HttpRecorderMode.Playback)
        //    {
        //        servicePrincipalSecret = "xyz";
        //    }
        //    return servicePrincipalSecret;
        //}

        //public static string GetServicePrincipalObjectId()
        //{
        //    string servicePrincipalObjectId = null;
        //    if (HttpMockServer.Mode == HttpRecorderMode.Record)
        //    {
        //        var environment = TestEnvironmentFactory.GetTestEnvironment();
        //        HttpMockServer.Variables[ConnectionStringKeys.AADClientIdKey] = environment.ConnectionString.KeyValuePairs.GetValueUsingCaseInsensitiveKey(ConnectionStringKeys.AADClientIdKey);
        //        servicePrincipalObjectId = HttpMockServer.Variables[ConnectionStringKeys.AADClientIdKey];
        //    }
        //    else if (HttpMockServer.Mode == HttpRecorderMode.Playback)
        //    {
        //        servicePrincipalObjectId = HttpMockServer.Variables[ConnectionStringKeys.AADClientIdKey];
        //    }
        //    return servicePrincipalObjectId;
        //}

        //public static async Task<string> GetAccessToken(string authority, string resource, string scope)
        //{
        //    var context = new AuthenticationContext(authority, TokenCache.DefaultShared);
        //    string authClientId = GetServicePrincipalId();
        //    string authSecret = GetServicePrincipalSecret();
        //    var clientCredential = new ClientCredential(authClientId, authSecret);
        //    var result = await context.AcquireTokenAsync(resource, clientCredential).ConfigureAwait(false);
        //    return result.AccessToken;
        //}

        //public static DelegatingHandler[] GetHandlers()
        //{
        //    HttpMockServer server = HttpMockServer.CreateInstance();
        //    return new DelegatingHandler[] { server };
        //}

        public static StoragePoolManagementClient GetStoragePoolManagementClient(MockContext context, RecordedDelegatingHandler handler)
        {
            StoragePoolManagementClient storagePoolClient;
            if (IsTestTenant)
            {
                storagePoolClient = new StoragePoolManagementClient(new TokenCredentials("xyz"), GetHandler());
                storagePoolClient.SubscriptionId = testSubscription;
                storagePoolClient.BaseUri = testUri;
            }
            else
            {
                handler.IsPassThrough = true;
                storagePoolClient = context.GetServiceClient<StoragePoolManagementClient>(handlers: handler);
            }
            return storagePoolClient;
        }

        private static HttpClientHandler GetHandler() 
        {
#if DNX451
            if (Handler == null)
            {
                //talk to yugangw-msft, if the code doesn't work under dnx451 (same with net451)
                X509Certificate2 cert = new X509Certificate2(certName, certPassword);
                Handler = new System.Net.Http.WebRequestHandler();
                ((WebRequestHandler)Handler).ClientCertificates.Add(cert);
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => { return true; };
            }
#endif
            return Handler;
        }

        public static string CreateResourceGroup(ResourceManagementClient resourcesClient)
        {
            const string testPrefix = "res";
            var rgname = TestUtilities.GenerateName(testPrefix);

            if (!IsTestTenant)
            {
                var resourceGroup = resourcesClient.ResourceGroups.CreateOrUpdate(
                    rgname,
                    new ResourceGroup
                    {
                        Location = DefaultRGLocation
                    });
            }

            return rgname;
        }
    }
}
