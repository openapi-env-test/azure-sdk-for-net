// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class BackupShortTermRetentionPolicyOperationSource : IOperationSource<BackupShortTermRetentionPolicyResource>
    {
        private readonly ArmClient _client;

        internal BackupShortTermRetentionPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        BackupShortTermRetentionPolicyResource IOperationSource<BackupShortTermRetentionPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BackupShortTermRetentionPolicyData.DeserializeBackupShortTermRetentionPolicyData(document.RootElement);
            return new BackupShortTermRetentionPolicyResource(_client, data);
        }

        async ValueTask<BackupShortTermRetentionPolicyResource> IOperationSource<BackupShortTermRetentionPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BackupShortTermRetentionPolicyData.DeserializeBackupShortTermRetentionPolicyData(document.RootElement);
            return new BackupShortTermRetentionPolicyResource(_client, data);
        }
    }
}
