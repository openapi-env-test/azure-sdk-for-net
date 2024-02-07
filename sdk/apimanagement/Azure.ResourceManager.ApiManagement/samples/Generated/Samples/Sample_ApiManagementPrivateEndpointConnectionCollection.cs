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
    public partial class Sample_ApiManagementPrivateEndpointConnectionCollection
    {
        // ApiManagementListPrivateEndpointConnections
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListPrivateEndpointConnections()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementListPrivateEndpointConnections.json
            // this example is just showing the usage of "PrivateEndpointConnection_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementPrivateEndpointConnectionResource
            ApiManagementPrivateEndpointConnectionCollection collection = apiManagementService.GetApiManagementPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (ApiManagementPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementPrivateEndpointConnectionResource
            ApiManagementPrivateEndpointConnectionCollection collection = apiManagementService.GetApiManagementPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ApiManagementPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementPrivateEndpointConnectionResource
            ApiManagementPrivateEndpointConnectionCollection collection = apiManagementService.GetApiManagementPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementPrivateEndpointConnectionResource
            ApiManagementPrivateEndpointConnectionCollection collection = apiManagementService.GetApiManagementPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            NullableResponse<ApiManagementPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            ApiManagementPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementApproveOrRejectPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementApproveOrRejectPrivateEndpointConnection()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementApproveOrRejectPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementServiceResource created on azure
            // for more information of creating ApiManagementServiceResource, please refer to the document of ApiManagementServiceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementServiceResourceId = ApiManagementServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementServiceResource apiManagementService = client.GetApiManagementServiceResource(apiManagementServiceResourceId);

            // get the collection of this ApiManagementPrivateEndpointConnectionResource
            ApiManagementPrivateEndpointConnectionCollection collection = apiManagementService.GetApiManagementPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ApiManagementPrivateEndpointConnectionCreateOrUpdateContent content = new ApiManagementPrivateEndpointConnectionCreateOrUpdateContent()
            {
                Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/privateEndpointConnections/connectionName"),
                PrivateLinkServiceConnectionState = new ApiManagementPrivateLinkServiceConnectionState()
                {
                    Status = ApiManagementPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "The Private Endpoint Connection is approved.",
                },
            };
            ArmOperation<ApiManagementPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, content);
            ApiManagementPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
