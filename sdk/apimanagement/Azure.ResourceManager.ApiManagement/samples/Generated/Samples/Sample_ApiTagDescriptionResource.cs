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
    public partial class Sample_ApiTagDescriptionResource
    {
        // ApiManagementHeadApiTagDescription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadApiTagDescription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementHeadApiTagDescription.json
            // this example is just showing the usage of "ApiTagDescription_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagDescriptionResource created on azure
            // for more information of creating ApiTagDescriptionResource, please refer to the document of ApiTagDescriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string tagDescriptionId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiTagDescriptionResourceId = ApiTagDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagDescriptionId);
            ApiTagDescriptionResource apiTagDescription = client.GetApiTagDescriptionResource(apiTagDescriptionResourceId);

            // invoke the operation
            bool result = await apiTagDescription.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetApiTagDescription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiTagDescription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementGetApiTagDescription.json
            // this example is just showing the usage of "ApiTagDescription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagDescriptionResource created on azure
            // for more information of creating ApiTagDescriptionResource, please refer to the document of ApiTagDescriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d6bb8f1f7fab13dc67ec9b";
            string tagDescriptionId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier apiTagDescriptionResourceId = ApiTagDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagDescriptionId);
            ApiTagDescriptionResource apiTagDescription = client.GetApiTagDescriptionResource(apiTagDescriptionResourceId);

            // invoke the operation
            ApiTagDescriptionResource result = await apiTagDescription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiTagDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateApiTagDescription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateApiTagDescription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementCreateApiTagDescription.json
            // this example is just showing the usage of "ApiTagDescription_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagDescriptionResource created on azure
            // for more information of creating ApiTagDescriptionResource, please refer to the document of ApiTagDescriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5931a75ae4bbd512a88c680b";
            string tagDescriptionId = "tagId1";
            ResourceIdentifier apiTagDescriptionResourceId = ApiTagDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagDescriptionId);
            ApiTagDescriptionResource apiTagDescription = client.GetApiTagDescriptionResource(apiTagDescriptionResourceId);

            // invoke the operation
            ApiTagDescriptionCreateOrUpdateContent content = new ApiTagDescriptionCreateOrUpdateContent()
            {
                Description = "Some description that will be displayed for operation's tag if the tag is assigned to operation of the API",
                ExternalDocsUri = new Uri("http://some.url/additionaldoc"),
                ExternalDocsDescription = "Description of the external docs resource",
            };
            ArmOperation<ApiTagDescriptionResource> lro = await apiTagDescription.UpdateAsync(WaitUntil.Completed, content);
            ApiTagDescriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiTagDescriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteApiTagDescription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteApiTagDescription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementDeleteApiTagDescription.json
            // this example is just showing the usage of "ApiTagDescription_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiTagDescriptionResource created on azure
            // for more information of creating ApiTagDescriptionResource, please refer to the document of ApiTagDescriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "59d5b28d1f7fab116c282650";
            string tagDescriptionId = "59d5b28e1f7fab116402044e";
            ResourceIdentifier apiTagDescriptionResourceId = ApiTagDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, tagDescriptionId);
            ApiTagDescriptionResource apiTagDescription = client.GetApiTagDescriptionResource(apiTagDescriptionResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiTagDescription.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
