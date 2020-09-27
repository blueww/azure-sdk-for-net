// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Net;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using ResourceGroups.Tests;
using Storage.Tests.Helpers;
using Xunit;
using Microsoft.Azure.Management.Resources;
using Microsoft.StoragePool;

namespace StoragePool.Tests
{
    public class StoragePoolTests
    {
        // 
        [Fact]
        public void StoragePoolTest()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourcesClient = StorageManagementTestUtilities.GetResourceManagementClient(context, handler);
                var storagePoolMgmtClient = StorageManagementTestUtilities.GetStoragePoolManagementClient(context, handler);

                // Create resource group
                var rgName = StorageManagementTestUtilities.CreateResourceGroup(resourcesClient);
                try
                {


                    //storagePoolMgmtClient.DiskPools.CreateOrUpdate();
                    //storagePoolMgmtClient.IscsiTargets.CreateOrUpdate();                
                }
                finally
                {
                    // clean up
                    //storageMgmtClient.StorageAccounts.Delete(rgName, accountName);
                    resourcesClient.ResourceGroups.Delete(rgName);                     
                }
            }
        }
    }
}
