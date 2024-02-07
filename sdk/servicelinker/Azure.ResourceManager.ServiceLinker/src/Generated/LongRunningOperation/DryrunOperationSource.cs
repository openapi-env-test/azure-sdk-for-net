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

namespace Azure.ResourceManager.ServiceLinker
{
    internal class DryrunOperationSource : IOperationSource<DryrunResource>
    {
        private readonly ArmClient _client;

        internal DryrunOperationSource(ArmClient client)
        {
            _client = client;
        }

        DryrunResource IOperationSource<DryrunResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DryrunResourceData.DeserializeDryrunResourceData(document.RootElement);
            return new DryrunResource(_client, data);
        }

        async ValueTask<DryrunResource> IOperationSource<DryrunResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DryrunResourceData.DeserializeDryrunResourceData(document.RootElement);
            return new DryrunResource(_client, data);
        }
    }
}
