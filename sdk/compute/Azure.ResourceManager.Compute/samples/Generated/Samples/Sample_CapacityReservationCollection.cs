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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_CapacityReservationCollection
    {
        // Create or update a capacity reservation .
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateACapacityReservation()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-09-01/examples/capacityReservationExamples/CapacityReservation_CreateOrUpdate.json
            // this example is just showing the usage of "CapacityReservations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string capacityReservationGroupName = "myCapacityReservationGroup";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // get the collection of this CapacityReservationResource
            CapacityReservationCollection collection = capacityReservationGroup.GetCapacityReservations();

            // invoke the operation
            string capacityReservationName = "myCapacityReservation";
            CapacityReservationData data = new CapacityReservationData(new AzureLocation("westus"), new ComputeSku()
            {
                Name = "Standard_DS1_v2",
                Capacity = 4,
            })
            {
                Zones =
{
"1"
},
                Tags =
{
["department"] = "HR",
},
            };
            ArmOperation<CapacityReservationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, capacityReservationName, data);
            CapacityReservationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityReservationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a capacity reservation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetACapacityReservation()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-09-01/examples/capacityReservationExamples/CapacityReservation_Get.json
            // this example is just showing the usage of "CapacityReservations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string capacityReservationGroupName = "myCapacityReservationGroup";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // get the collection of this CapacityReservationResource
            CapacityReservationCollection collection = capacityReservationGroup.GetCapacityReservations();

            // invoke the operation
            string capacityReservationName = "myCapacityReservation";
            CapacityReservationInstanceViewType? expand = CapacityReservationInstanceViewType.InstanceView;
            CapacityReservationResource result = await collection.GetAsync(capacityReservationName, expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CapacityReservationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a capacity reservation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetACapacityReservation()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-09-01/examples/capacityReservationExamples/CapacityReservation_Get.json
            // this example is just showing the usage of "CapacityReservations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string capacityReservationGroupName = "myCapacityReservationGroup";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // get the collection of this CapacityReservationResource
            CapacityReservationCollection collection = capacityReservationGroup.GetCapacityReservations();

            // invoke the operation
            string capacityReservationName = "myCapacityReservation";
            CapacityReservationInstanceViewType? expand = CapacityReservationInstanceViewType.InstanceView;
            bool result = await collection.ExistsAsync(capacityReservationName, expand: expand);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a capacity reservation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetACapacityReservation()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-09-01/examples/capacityReservationExamples/CapacityReservation_Get.json
            // this example is just showing the usage of "CapacityReservations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string capacityReservationGroupName = "myCapacityReservationGroup";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // get the collection of this CapacityReservationResource
            CapacityReservationCollection collection = capacityReservationGroup.GetCapacityReservations();

            // invoke the operation
            string capacityReservationName = "myCapacityReservation";
            CapacityReservationInstanceViewType? expand = CapacityReservationInstanceViewType.InstanceView;
            NullableResponse<CapacityReservationResource> response = await collection.GetIfExistsAsync(capacityReservationName, expand: expand);
            CapacityReservationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CapacityReservationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List capacity reservations in reservation group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListCapacityReservationsInReservationGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-09-01/examples/capacityReservationExamples/CapacityReservation_ListByReservationGroup.json
            // this example is just showing the usage of "CapacityReservations_ListByCapacityReservationGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityReservationGroupResource created on azure
            // for more information of creating CapacityReservationGroupResource, please refer to the document of CapacityReservationGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string capacityReservationGroupName = "myCapacityReservationGroup";
            ResourceIdentifier capacityReservationGroupResourceId = CapacityReservationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName);
            CapacityReservationGroupResource capacityReservationGroup = client.GetCapacityReservationGroupResource(capacityReservationGroupResourceId);

            // get the collection of this CapacityReservationResource
            CapacityReservationCollection collection = capacityReservationGroup.GetCapacityReservations();

            // invoke the operation and iterate over the result
            await foreach (CapacityReservationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CapacityReservationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
