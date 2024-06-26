// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal class BackupProtectedItemOperationSource : IOperationSource<BackupProtectedItemResource>
    {
        private readonly ArmClient _client;

        internal BackupProtectedItemOperationSource(ArmClient client)
        {
            _client = client;
        }

        BackupProtectedItemResource IOperationSource<BackupProtectedItemResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BackupProtectedItemData.DeserializeBackupProtectedItemData(document.RootElement);
            return new BackupProtectedItemResource(_client, data);
        }

        async ValueTask<BackupProtectedItemResource> IOperationSource<BackupProtectedItemResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BackupProtectedItemData.DeserializeBackupProtectedItemData(document.RootElement);
            return new BackupProtectedItemResource(_client, data);
        }
    }
}
