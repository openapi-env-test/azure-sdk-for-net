// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ServiceWorkspaceApiSchemaOperationSource : IOperationSource<ServiceWorkspaceApiSchemaResource>
    {
        private readonly ArmClient _client;

        internal ServiceWorkspaceApiSchemaOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceWorkspaceApiSchemaResource IOperationSource<ServiceWorkspaceApiSchemaResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApiSchemaData.DeserializeApiSchemaData(document.RootElement);
            return new ServiceWorkspaceApiSchemaResource(_client, data);
        }

        async ValueTask<ServiceWorkspaceApiSchemaResource> IOperationSource<ServiceWorkspaceApiSchemaResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApiSchemaData.DeserializeApiSchemaData(document.RootElement);
            return new ServiceWorkspaceApiSchemaResource(_client, data);
        }
    }
}
