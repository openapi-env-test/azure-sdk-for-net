// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProtectionPoliciesOperations.
    /// </summary>
    public static partial class ProtectionPoliciesOperationsExtensions
    {
            /// <summary>
            /// Provides the details of the backup policies associated to Recovery Services
            /// Vault. This is an asynchronous
            /// operation. Status of the operation can be fetched using
            /// GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy information to be fetched.
            /// </param>
            public static ProtectionPolicyResource Get(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName)
            {
                return operations.GetAsync(vaultName, resourceGroupName, policyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the details of the backup policies associated to Recovery Services
            /// Vault. This is an asynchronous
            /// operation. Status of the operation can be fetched using
            /// GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy information to be fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionPolicyResource> GetAsync(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, policyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or modifies a backup policy. This is an asynchronous operation.
            /// Status of the operation can be fetched
            /// using GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy to be created.
            /// </param>
            /// <param name='parameters'>
            /// resource backup policy
            /// </param>
            public static ProtectionPolicyResource CreateOrUpdate(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName, ProtectionPolicyResource parameters)
            {
                return operations.CreateOrUpdateAsync(vaultName, resourceGroupName, policyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or modifies a backup policy. This is an asynchronous operation.
            /// Status of the operation can be fetched
            /// using GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy to be created.
            /// </param>
            /// <param name='parameters'>
            /// resource backup policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionPolicyResource> CreateOrUpdateAsync(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName, ProtectionPolicyResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(vaultName, resourceGroupName, policyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
