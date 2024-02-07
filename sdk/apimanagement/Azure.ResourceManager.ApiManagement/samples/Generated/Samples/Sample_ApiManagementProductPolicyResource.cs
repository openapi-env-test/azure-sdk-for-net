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
    public partial class Sample_ApiManagementProductPolicyResource
    {
        // ApiManagementHeadProductPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementHeadProductPolicy.json
            // this example is just showing the usage of "ProductPolicy_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductPolicyResource created on azure
            // for more information of creating ApiManagementProductPolicyResource, please refer to the document of ApiManagementProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "unlimited";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiManagementProductPolicyResourceId = ApiManagementProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, policyId);
            ApiManagementProductPolicyResource apiManagementProductPolicy = client.GetApiManagementProductPolicyResource(apiManagementProductPolicyResourceId);

            // invoke the operation
            bool result = await apiManagementProductPolicy.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetProductPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetProductPolicy.json
            // this example is just showing the usage of "ProductPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductPolicyResource created on azure
            // for more information of creating ApiManagementProductPolicyResource, please refer to the document of ApiManagementProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "kjoshiarmTemplateProduct4";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiManagementProductPolicyResourceId = ApiManagementProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, policyId);
            ApiManagementProductPolicyResource apiManagementProductPolicy = client.GetApiManagementProductPolicyResource(apiManagementProductPolicyResourceId);

            // invoke the operation
            ApiManagementProductPolicyResource result = await apiManagementProductPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateProductPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementCreateProductPolicy.json
            // this example is just showing the usage of "ProductPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductPolicyResource created on azure
            // for more information of creating ApiManagementProductPolicyResource, please refer to the document of ApiManagementProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "5702e97e5157a50f48dce801";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiManagementProductPolicyResourceId = ApiManagementProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, policyId);
            ApiManagementProductPolicyResource apiManagementProductPolicy = client.GetApiManagementProductPolicyResource(apiManagementProductPolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData()
            {
                Value = "<policies>\r\n  <inbound>\r\n    <rate-limit calls=\"{{call-count}}\" renewal-period=\"15\"></rate-limit>\r\n    <log-to-eventhub logger-id=\"16\">\r\n                      @( string.Join(\",\", DateTime.UtcNow, context.Deployment.ServiceName, context.RequestId, context.Request.IpAddress, context.Operation.Name) ) \r\n                  </log-to-eventhub>\r\n    <quota-by-key calls=\"40\" counter-key=\"cc\" renewal-period=\"3600\" increment-count=\"@(context.Request.Method == &quot;POST&quot; ? 1:2)\" />\r\n    <base />\r\n  </inbound>\r\n  <backend>\r\n    <base />\r\n  </backend>\r\n  <outbound>\r\n    <base />\r\n  </outbound>\r\n</policies>",
                Format = PolicyContentFormat.Xml,
            };
            ArmOperation<ApiManagementProductPolicyResource> lro = await apiManagementProductPolicy.UpdateAsync(WaitUntil.Completed, data);
            ApiManagementProductPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteProductPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteProductPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementDeleteProductPolicy.json
            // this example is just showing the usage of "ProductPolicy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementProductPolicyResource created on azure
            // for more information of creating ApiManagementProductPolicyResource, please refer to the document of ApiManagementProductPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiManagementProductPolicyResourceId = ApiManagementProductPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, policyId);
            ApiManagementProductPolicyResource apiManagementProductPolicy = client.GetApiManagementProductPolicyResource(apiManagementProductPolicyResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementProductPolicy.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
