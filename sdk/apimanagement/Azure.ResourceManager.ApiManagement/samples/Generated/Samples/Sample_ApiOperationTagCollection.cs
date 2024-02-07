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

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiOperationTagCollection
    {
        // ApiManagementListApiOperationTags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListApiOperationTags()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementListApiOperationTags.json
            // this example is just showing the usage of "Tag_ListByOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceApiOperationResource created on azure
            // for more information of creating ServiceApiOperationResource, please refer to the document of ServiceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string operationId = "57d2ef278aa04f0888cba3f6";
            ResourceIdentifier serviceApiOperationResourceId = ServiceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId);
            ServiceApiOperationResource serviceApiOperation = client.GetServiceApiOperationResource(serviceApiOperationResourceId);

            // get the collection of this ApiOperationTagResource
            ApiOperationTagCollection collection = serviceApiOperation.GetApiOperationTags();

            // invoke the operation and iterate over the result
            await foreach (ApiOperationTagResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetApiOperationTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetApiOperationTag.json
            // this example is just showing the usage of "Tag_GetByOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceApiOperationResource created on azure
            // for more information of creating ServiceApiOperationResource, please refer to the document of ServiceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string operationId = "59d6bb8f1f7fab13dc67ec9a";
            ResourceIdentifier serviceApiOperationResourceId = ServiceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId);
            ServiceApiOperationResource serviceApiOperation = client.GetServiceApiOperationResource(serviceApiOperationResourceId);

            // get the collection of this ApiOperationTagResource
            ApiOperationTagCollection collection = serviceApiOperation.GetApiOperationTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            ApiOperationTagResource result = await collection.GetAsync(tagId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetApiOperationTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetApiOperationTag.json
            // this example is just showing the usage of "Tag_GetByOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceApiOperationResource created on azure
            // for more information of creating ServiceApiOperationResource, please refer to the document of ServiceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string operationId = "59d6bb8f1f7fab13dc67ec9a";
            ResourceIdentifier serviceApiOperationResourceId = ServiceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId);
            ServiceApiOperationResource serviceApiOperation = client.GetServiceApiOperationResource(serviceApiOperationResourceId);

            // get the collection of this ApiOperationTagResource
            ApiOperationTagCollection collection = serviceApiOperation.GetApiOperationTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            bool result = await collection.ExistsAsync(tagId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetApiOperationTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetApiOperationTag.json
            // this example is just showing the usage of "Tag_GetByOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceApiOperationResource created on azure
            // for more information of creating ServiceApiOperationResource, please refer to the document of ServiceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string operationId = "59d6bb8f1f7fab13dc67ec9a";
            ResourceIdentifier serviceApiOperationResourceId = ServiceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId);
            ServiceApiOperationResource serviceApiOperation = client.GetServiceApiOperationResource(serviceApiOperationResourceId);

            // get the collection of this ApiOperationTagResource
            ApiOperationTagCollection collection = serviceApiOperation.GetApiOperationTags();

            // invoke the operation
            string tagId = "59306a29e4bbd510dc24e5f9";
            NullableResponse<ApiOperationTagResource> response = await collection.GetIfExistsAsync(tagId);
            ApiOperationTagResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateApiOperationTag
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateApiOperationTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementCreateApiOperationTag.json
            // this example is just showing the usage of "Tag_AssignToOperation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceApiOperationResource created on azure
            // for more information of creating ServiceApiOperationResource, please refer to the document of ServiceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5931a75ae4bbd512a88c680b";
            string operationId = "5931a75ae4bbd512a88c680a";
            ResourceIdentifier serviceApiOperationResourceId = ServiceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId);
            ServiceApiOperationResource serviceApiOperation = client.GetServiceApiOperationResource(serviceApiOperationResourceId);

            // get the collection of this ApiOperationTagResource
            ApiOperationTagCollection collection = serviceApiOperation.GetApiOperationTags();

            // invoke the operation
            string tagId = "tagId1";
            ArmOperation<ApiOperationTagResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tagId);
            ApiOperationTagResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
