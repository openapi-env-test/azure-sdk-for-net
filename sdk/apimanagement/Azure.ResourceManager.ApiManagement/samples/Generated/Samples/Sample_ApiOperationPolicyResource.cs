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
    public partial class Sample_ApiOperationPolicyResource
    {
        // ApiManagementHeadApiOperationPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementHeadApiOperationPolicy.json
            // this example is just showing the usage of "ApiOperationPolicy_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationPolicyResource created on azure
            // for more information of creating ApiOperationPolicyResource, please refer to the document of ApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b539c53f5b0062040001";
            string operationId = "5600b53ac53f5b0062080006";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiOperationPolicyResourceId = ApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, policyId);
            ApiOperationPolicyResource apiOperationPolicy = client.GetApiOperationPolicyResource(apiOperationPolicyResourceId);

            // invoke the operation
            bool result = await apiOperationPolicy.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetApiOperationPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetApiOperationPolicy.json
            // this example is just showing the usage of "ApiOperationPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationPolicyResource created on azure
            // for more information of creating ApiOperationPolicyResource, please refer to the document of ApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b539c53f5b0062040001";
            string operationId = "5600b53ac53f5b0062080006";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiOperationPolicyResourceId = ApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, policyId);
            ApiOperationPolicyResource apiOperationPolicy = client.GetApiOperationPolicyResource(apiOperationPolicyResourceId);

            // invoke the operation
            ApiOperationPolicyResource result = await apiOperationPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateApiOperationPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementCreateApiOperationPolicy.json
            // this example is just showing the usage of "ApiOperationPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationPolicyResource created on azure
            // for more information of creating ApiOperationPolicyResource, please refer to the document of ApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b57e7e8880006a040001";
            string operationId = "5600b57e7e8880006a080001";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiOperationPolicyResourceId = ApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, policyId);
            ApiOperationPolicyResource apiOperationPolicy = client.GetApiOperationPolicyResource(apiOperationPolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData()
            {
                Value = "<policies> <inbound /> <backend>    <forward-request />  </backend>  <outbound /></policies>",
                Format = PolicyContentFormat.Xml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ApiOperationPolicyResource> lro = await apiOperationPolicy.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ApiOperationPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteApiOperationPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteApiOperationPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementDeleteApiOperationPolicy.json
            // this example is just showing the usage of "ApiOperationPolicy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiOperationPolicyResource created on azure
            // for more information of creating ApiOperationPolicyResource, please refer to the document of ApiOperationPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "testapi";
            string operationId = "testoperation";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiOperationPolicyResourceId = ApiOperationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, operationId, policyId);
            ApiOperationPolicyResource apiOperationPolicy = client.GetApiOperationPolicyResource(apiOperationPolicyResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiOperationPolicy.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
