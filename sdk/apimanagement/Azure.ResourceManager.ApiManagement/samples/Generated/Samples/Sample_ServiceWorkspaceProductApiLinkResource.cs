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
    public partial class Sample_ServiceWorkspaceProductApiLinkResource
    {
        // ApiManagementGetWorkspaceProductApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetWorkspaceProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetWorkspaceProductApiLink.json
            // this example is just showing the usage of "WorkspaceProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductApiLinkResource created on azure
            // for more information of creating ServiceWorkspaceProductApiLinkResource, please refer to the document of ServiceWorkspaceProductApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            string apiLinkId = "link1";
            ResourceIdentifier serviceWorkspaceProductApiLinkResourceId = ServiceWorkspaceProductApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId, apiLinkId);
            ServiceWorkspaceProductApiLinkResource serviceWorkspaceProductApiLink = client.GetServiceWorkspaceProductApiLinkResource(serviceWorkspaceProductApiLinkResourceId);

            // invoke the operation
            ServiceWorkspaceProductApiLinkResource result = await serviceWorkspaceProductApiLink.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateWorkspaceProductApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateWorkspaceProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementCreateWorkspaceProductApiLink.json
            // this example is just showing the usage of "WorkspaceProductApiLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductApiLinkResource created on azure
            // for more information of creating ServiceWorkspaceProductApiLinkResource, please refer to the document of ServiceWorkspaceProductApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            string apiLinkId = "link1";
            ResourceIdentifier serviceWorkspaceProductApiLinkResourceId = ServiceWorkspaceProductApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId, apiLinkId);
            ServiceWorkspaceProductApiLinkResource serviceWorkspaceProductApiLink = client.GetServiceWorkspaceProductApiLinkResource(serviceWorkspaceProductApiLinkResourceId);

            // invoke the operation
            ProductApiLinkContractData data = new ProductApiLinkContractData()
            {
                ApiId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/workspaces/wks1/apis/echo-api",
            };
            ArmOperation<ServiceWorkspaceProductApiLinkResource> lro = await serviceWorkspaceProductApiLink.UpdateAsync(WaitUntil.Completed, data);
            ServiceWorkspaceProductApiLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteWorkspaceProductApiLink
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteWorkspaceProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementDeleteWorkspaceProductApiLink.json
            // this example is just showing the usage of "WorkspaceProductApiLink_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductApiLinkResource created on azure
            // for more information of creating ServiceWorkspaceProductApiLinkResource, please refer to the document of ServiceWorkspaceProductApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            string apiLinkId = "link1";
            ResourceIdentifier serviceWorkspaceProductApiLinkResourceId = ServiceWorkspaceProductApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId, apiLinkId);
            ServiceWorkspaceProductApiLinkResource serviceWorkspaceProductApiLink = client.GetServiceWorkspaceProductApiLinkResource(serviceWorkspaceProductApiLinkResourceId);

            // invoke the operation
            await serviceWorkspaceProductApiLink.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
