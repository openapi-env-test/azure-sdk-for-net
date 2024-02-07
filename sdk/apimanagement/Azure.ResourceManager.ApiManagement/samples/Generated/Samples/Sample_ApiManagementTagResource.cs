// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementTagResource
    {
        // ApiManagementHeadTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityState_ApiManagementHeadTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementHeadTag.json
            // this example is just showing the usage of "Tag_GetEntityState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementTagResource created on azure
            // for more information of creating ApiManagementTagResource, please refer to the document of ApiManagementTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiManagementTagResourceId = ApiManagementTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId);
            ApiManagementTagResource apiManagementTag = client.GetApiManagementTagResource(apiManagementTagResourceId);

            // invoke the operation
            bool result = await apiManagementTag.GetEntityStateAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetTag.json
            // this example is just showing the usage of "Tag_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementTagResource created on azure
            // for more information of creating ApiManagementTagResource, please refer to the document of ApiManagementTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiManagementTagResourceId = ApiManagementTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId);
            ApiManagementTagResource apiManagementTag = client.GetApiManagementTagResource(apiManagementTagResourceId);

            // invoke the operation
            ApiManagementTagResource result = await apiManagementTag.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementUpdateTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementUpdateTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementUpdateTag.json
            // this example is just showing the usage of "Tag_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementTagResource created on azure
            // for more information of creating ApiManagementTagResource, please refer to the document of ApiManagementTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "temptag";
            ResourceIdentifier apiManagementTagResourceId = ApiManagementTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId);
            ApiManagementTagResource apiManagementTag = client.GetApiManagementTagResource(apiManagementTagResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementTagCreateOrUpdateContent content = new ApiManagementTagCreateOrUpdateContent()
            {
                DisplayName = "temp tag",
            };
            ApiManagementTagResource result = await apiManagementTag.UpdateAsync(ifMatch, content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementDeleteTag.json
            // this example is just showing the usage of "Tag_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementTagResource created on azure
            // for more information of creating ApiManagementTagResource, please refer to the document of ApiManagementTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "tagId1";
            ResourceIdentifier apiManagementTagResourceId = ApiManagementTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId);
            ApiManagementTagResource apiManagementTag = client.GetApiManagementTagResource(apiManagementTagResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementTag.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
