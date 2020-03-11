// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CertificatesOperations.
    /// </summary>
    public static partial class CertificatesOperationsExtensions
    {
            /// <summary>
            /// Get the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static CertificateResource Get(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResource> GetAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static CertificateResource CreateOrUpdate(this ICertificatesOperations operations, CertificateResource certificateResource, string resourceGroupName, string serviceName, string certificateName)
            {
                return operations.CreateOrUpdateAsync(certificateResource, resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResource> CreateOrUpdateAsync(this ICertificatesOperations operations, CertificateResource certificateResource, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(certificateResource, resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static CertificateResource Delete(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName)
            {
                return operations.DeleteAsync(resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResource> DeleteAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the certificates of one user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static CertificateResourceCollection List(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName)
            {
                return operations.ListAsync(resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the certificates of one user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResourceCollection> ListAsync(this ICertificatesOperations operations, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            public static CertificateResource BeginCreateOrUpdate(this ICertificatesOperations operations, CertificateResource certificateResource, string resourceGroupName, string serviceName, string certificateName)
            {
                return operations.BeginCreateOrUpdateAsync(certificateResource, resourceGroupName, serviceName, certificateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update certificate resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='certificateResource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='certificateName'>
            /// The name of the certificate resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateResource> BeginCreateOrUpdateAsync(this ICertificatesOperations operations, CertificateResource certificateResource, string resourceGroupName, string serviceName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(certificateResource, resourceGroupName, serviceName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
