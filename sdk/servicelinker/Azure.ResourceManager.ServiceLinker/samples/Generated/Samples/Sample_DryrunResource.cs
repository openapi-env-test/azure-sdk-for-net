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
using Azure.ResourceManager.ServiceLinker;
using Azure.ResourceManager.ServiceLinker.Models;

namespace Azure.ResourceManager.ServiceLinker.Samples
{
    public partial class Sample_DryrunResource
    {
        // GetDryrun
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDryrun()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/preview/2023-04-01-preview/examples/GetDryrun.json
            // this example is just showing the usage of "Linkers_GetDryrun" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DryrunResource created on azure
            // for more information of creating DryrunResource, please refer to the document of DryrunResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string dryrunName = "dryrunName";
            ResourceIdentifier dryrunResourceId = DryrunResource.CreateResourceIdentifier(resourceUri, dryrunName);
            DryrunResource dryrun = client.GetDryrunResource(dryrunResourceId);

            // invoke the operation
            DryrunResource result = await dryrun.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DryrunResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PatchDryrun
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchDryrun()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/preview/2023-04-01-preview/examples/PatchDryrun.json
            // this example is just showing the usage of "Linkers_UpdateDryrun" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DryrunResource created on azure
            // for more information of creating DryrunResource, please refer to the document of DryrunResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string dryrunName = "dryrunName";
            ResourceIdentifier dryrunResourceId = DryrunResource.CreateResourceIdentifier(resourceUri, dryrunName);
            DryrunResource dryrun = client.GetDryrunResource(dryrunResourceId);

            // invoke the operation
            DryrunPatch patch = new DryrunPatch()
            {
                Parameters = new CreateOrUpdateDryrunParameters()
                {
                    TargetService = new AzureResourceInfo()
                    {
                        Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.DocumentDb/databaseAccounts/test-acc/mongodbDatabases/test-db"),
                    },
                    AuthInfo = new SecretAuthInfo()
                    {
                        Name = "name",
                        SecretInfo = new RawValueSecretInfo()
                        {
                            Value = "secret",
                        },
                    },
                },
            };
            ArmOperation<DryrunResource> lro = await dryrun.UpdateAsync(WaitUntil.Completed, patch);
            DryrunResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DryrunResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteDryrun
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteDryrun()
        {
            // Generated from example definition: specification/servicelinker/resource-manager/Microsoft.ServiceLinker/preview/2023-04-01-preview/examples/DeleteDryrun.json
            // this example is just showing the usage of "Linkers_DeleteDryrun" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DryrunResource created on azure
            // for more information of creating DryrunResource, please refer to the document of DryrunResource
            string resourceUri = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/test-rg/providers/Microsoft.Web/sites/test-app";
            string dryrunName = "dryrunName";
            ResourceIdentifier dryrunResourceId = DryrunResource.CreateResourceIdentifier(resourceUri, dryrunName);
            DryrunResource dryrun = client.GetDryrunResource(dryrunResourceId);

            // invoke the operation
            await dryrun.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
