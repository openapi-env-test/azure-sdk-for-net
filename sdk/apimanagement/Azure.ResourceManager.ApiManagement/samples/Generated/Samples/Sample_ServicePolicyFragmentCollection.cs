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
    public partial class Sample_ServicePolicyFragmentCollection
    {
        // ApiManagementListPolicyFragments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListPolicyFragments()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementListPolicyFragments.json
            // this example is just showing the usage of "PolicyFragment_ListByService" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation and iterate over the result
            await foreach (ServicePolicyFragmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyFragmentContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetPolicyFragment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetPolicyFragment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation
            string id = "policyFragment1";
            ServicePolicyFragmentResource result = await collection.GetAsync(id);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyFragmentContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetPolicyFragment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetPolicyFragment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation
            string id = "policyFragment1";
            bool result = await collection.ExistsAsync(id);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetPolicyFragment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetPolicyFragment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation
            string id = "policyFragment1";
            NullableResponse<ServicePolicyFragmentResource> response = await collection.GetIfExistsAsync(id);
            ServicePolicyFragmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyFragmentContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementGetPolicyFragmentFormat
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetPolicyFragmentFormat()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPolicyFragmentFormat.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation
            string id = "policyFragment1";
            PolicyFragmentContentFormat? format = PolicyFragmentContentFormat.Rawxml;
            ServicePolicyFragmentResource result = await collection.GetAsync(id, format: format);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyFragmentContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetPolicyFragmentFormat
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetPolicyFragmentFormat()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPolicyFragmentFormat.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation
            string id = "policyFragment1";
            PolicyFragmentContentFormat? format = PolicyFragmentContentFormat.Rawxml;
            bool result = await collection.ExistsAsync(id, format: format);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetPolicyFragmentFormat
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetPolicyFragmentFormat()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetPolicyFragmentFormat.json
            // this example is just showing the usage of "PolicyFragment_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation
            string id = "policyFragment1";
            PolicyFragmentContentFormat? format = PolicyFragmentContentFormat.Rawxml;
            NullableResponse<ServicePolicyFragmentResource> response = await collection.GetIfExistsAsync(id, format: format);
            ServicePolicyFragmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyFragmentContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreatePolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreatePolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementCreatePolicyFragment.json
            // this example is just showing the usage of "PolicyFragment_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this ServicePolicyFragmentResource
            ServicePolicyFragmentCollection collection = apiManagementService.GetServicePolicyFragments();

            // invoke the operation
            string id = "policyFragment1";
            PolicyFragmentContractData data = new PolicyFragmentContractData()
            {
                Value = "<fragment><json-to-xml apply=\"always\" consider-accept-header=\"false\" /></fragment>",
                Description = "A policy fragment example",
                Format = PolicyFragmentContentFormat.Xml,
            };
            ArmOperation<ServicePolicyFragmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, id, data);
            ServicePolicyFragmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyFragmentContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
