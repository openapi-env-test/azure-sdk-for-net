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
    public partial class Sample_ApiManagementPortalDelegationSettingResource
    {
        // ApiManagementHeadDelegationSettings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadDelegationSettings()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementHeadDelegationSettings.json
            // this example is just showing the usage of "DelegationSettings_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalDelegationSettingResource created on azure
            // for more information of creating ApiManagementPortalDelegationSettingResource, please refer to the document of ApiManagementPortalDelegationSettingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementPortalDelegationSettingResourceId = ApiManagementPortalDelegationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementPortalDelegationSettingResource apiManagementPortalDelegationSetting = client.GetApiManagementPortalDelegationSettingResource(apiManagementPortalDelegationSettingResourceId);

            // invoke the operation
            bool result = await apiManagementPortalDelegationSetting.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementPortalSettingsGetDelegation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementPortalSettingsGetDelegation()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementPortalSettingsGetDelegation.json
            // this example is just showing the usage of "DelegationSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalDelegationSettingResource created on azure
            // for more information of creating ApiManagementPortalDelegationSettingResource, please refer to the document of ApiManagementPortalDelegationSettingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementPortalDelegationSettingResourceId = ApiManagementPortalDelegationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementPortalDelegationSettingResource apiManagementPortalDelegationSetting = client.GetApiManagementPortalDelegationSettingResource(apiManagementPortalDelegationSettingResourceId);

            // invoke the operation
            ApiManagementPortalDelegationSettingResource result = await apiManagementPortalDelegationSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPortalDelegationSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementPortalSettingsUpdateDelegation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementPortalSettingsUpdateDelegation()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementPortalSettingsUpdateDelegation.json
            // this example is just showing the usage of "DelegationSettings_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalDelegationSettingResource created on azure
            // for more information of creating ApiManagementPortalDelegationSettingResource, please refer to the document of ApiManagementPortalDelegationSettingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementPortalDelegationSettingResourceId = ApiManagementPortalDelegationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementPortalDelegationSettingResource apiManagementPortalDelegationSetting = client.GetApiManagementPortalDelegationSettingResource(apiManagementPortalDelegationSettingResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementPortalDelegationSettingData data = new ApiManagementPortalDelegationSettingData()
            {
                Uri = new Uri("http://contoso.com/delegation"),
                ValidationKey = "<validationKey>",
                IsSubscriptionDelegationEnabled = true,
                IsUserRegistrationDelegationEnabled = true,
            };
            await apiManagementPortalDelegationSetting.UpdateAsync(ifMatch, data);

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementPortalSettingsUpdateDelegation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementPortalSettingsUpdateDelegation()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementPortalSettingsPutDelegation.json
            // this example is just showing the usage of "DelegationSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalDelegationSettingResource created on azure
            // for more information of creating ApiManagementPortalDelegationSettingResource, please refer to the document of ApiManagementPortalDelegationSettingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementPortalDelegationSettingResourceId = ApiManagementPortalDelegationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementPortalDelegationSettingResource apiManagementPortalDelegationSetting = client.GetApiManagementPortalDelegationSettingResource(apiManagementPortalDelegationSettingResourceId);

            // invoke the operation
            ApiManagementPortalDelegationSettingData data = new ApiManagementPortalDelegationSettingData()
            {
                Uri = new Uri("http://contoso.com/delegation"),
                ValidationKey = "<validationKey>",
                IsSubscriptionDelegationEnabled = true,
                IsUserRegistrationDelegationEnabled = true,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ApiManagementPortalDelegationSettingResource> lro = await apiManagementPortalDelegationSetting.CreateOrUpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ApiManagementPortalDelegationSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPortalDelegationSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementListSecretsPortalSettings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecrets_ApiManagementListSecretsPortalSettings()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-05-01-preview/examples/ApiManagementListSecretsPortalSettingsValidationKey.json
            // this example is just showing the usage of "DelegationSettings_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalDelegationSettingResource created on azure
            // for more information of creating ApiManagementPortalDelegationSettingResource, please refer to the document of ApiManagementPortalDelegationSettingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            ResourceIdentifier apiManagementPortalDelegationSettingResourceId = ApiManagementPortalDelegationSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName);
            ApiManagementPortalDelegationSettingResource apiManagementPortalDelegationSetting = client.GetApiManagementPortalDelegationSettingResource(apiManagementPortalDelegationSettingResourceId);

            // invoke the operation
            PortalSettingValidationKeyContract result = await apiManagementPortalDelegationSetting.GetSecretsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
