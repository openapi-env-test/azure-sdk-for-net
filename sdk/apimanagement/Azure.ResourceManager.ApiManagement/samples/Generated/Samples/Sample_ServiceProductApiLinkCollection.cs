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
    public partial class Sample_ServiceProductApiLinkCollection
    {
        // ApiManagementListProductApiLinks
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListProductApiLinks()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementListProductApiLinks.json
            // this example is just showing the usage of "ProductApiLink_ListByProduct" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductResource created on azure
            // for more information of creating ServiceProductResource, please refer to the document of ServiceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "product1";
            ResourceIdentifier serviceProductResourceId = ServiceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId);
            ServiceProductResource serviceProduct = client.GetServiceProductResource(serviceProductResourceId);

            // get the collection of this ServiceProductApiLinkResource
            ServiceProductApiLinkCollection collection = serviceProduct.GetServiceProductApiLinks();

            // invoke the operation and iterate over the result
            await foreach (ServiceProductApiLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProductApiLinkContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetProductApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetProductApiLink.json
            // this example is just showing the usage of "ProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductResource created on azure
            // for more information of creating ServiceProductResource, please refer to the document of ServiceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            ResourceIdentifier serviceProductResourceId = ServiceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId);
            ServiceProductResource serviceProduct = client.GetServiceProductResource(serviceProductResourceId);

            // get the collection of this ServiceProductApiLinkResource
            ServiceProductApiLinkCollection collection = serviceProduct.GetServiceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            ServiceProductApiLinkResource result = await collection.GetAsync(apiLinkId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetProductApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetProductApiLink.json
            // this example is just showing the usage of "ProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductResource created on azure
            // for more information of creating ServiceProductResource, please refer to the document of ServiceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            ResourceIdentifier serviceProductResourceId = ServiceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId);
            ServiceProductResource serviceProduct = client.GetServiceProductResource(serviceProductResourceId);

            // get the collection of this ServiceProductApiLinkResource
            ServiceProductApiLinkCollection collection = serviceProduct.GetServiceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            bool result = await collection.ExistsAsync(apiLinkId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetProductApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetProductApiLink.json
            // this example is just showing the usage of "ProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductResource created on azure
            // for more information of creating ServiceProductResource, please refer to the document of ServiceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            ResourceIdentifier serviceProductResourceId = ServiceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId);
            ServiceProductResource serviceProduct = client.GetServiceProductResource(serviceProductResourceId);

            // get the collection of this ServiceProductApiLinkResource
            ServiceProductApiLinkCollection collection = serviceProduct.GetServiceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            NullableResponse<ServiceProductApiLinkResource> response = await collection.GetIfExistsAsync(apiLinkId);
            ServiceProductApiLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProductApiLinkContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateProductApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementCreateProductApiLink.json
            // this example is just showing the usage of "ProductApiLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductResource created on azure
            // for more information of creating ServiceProductResource, please refer to the document of ServiceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            ResourceIdentifier serviceProductResourceId = ServiceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId);
            ServiceProductResource serviceProduct = client.GetServiceProductResource(serviceProductResourceId);

            // get the collection of this ServiceProductApiLinkResource
            ServiceProductApiLinkCollection collection = serviceProduct.GetServiceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            ProductApiLinkContractData data = new ProductApiLinkContractData()
            {
                ApiId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/apis/echo-api",
            };
            ArmOperation<ServiceProductApiLinkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, apiLinkId, data);
            ServiceProductApiLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
