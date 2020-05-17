// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IncidentCommentsOperations.
    /// </summary>
    public static partial class IncidentCommentsOperationsExtensions
    {
            /// <summary>
            /// Gets all incident comments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            public static IPage<IncidentComment> ListByIncident(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, ODataQuery<IncidentComment> odataQuery = default(ODataQuery<IncidentComment>), string skipToken = default(string))
            {
                return operations.ListByIncidentAsync(resourceGroupName, workspaceName, incidentId, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all incident comments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IncidentComment>> ListByIncidentAsync(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, ODataQuery<IncidentComment> odataQuery = default(ODataQuery<IncidentComment>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIncidentWithHttpMessagesAsync(resourceGroupName, workspaceName, incidentId, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an incident comment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            public static IncidentComment GetComment(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId)
            {
                return operations.GetCommentAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an incident comment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IncidentComment> GetCommentAsync(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCommentWithHttpMessagesAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates the incident comment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            /// <param name='message'>
            /// The comment message
            /// </param>
            public static IncidentComment CreateComment(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId, string message)
            {
                return operations.CreateCommentAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId, message).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates the incident comment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            /// <param name='message'>
            /// The comment message
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IncidentComment> CreateCommentAsync(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId, string message, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateCommentWithHttpMessagesAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId, message, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all incident comments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IncidentComment> ListByIncidentNext(this IIncidentCommentsOperations operations, string nextPageLink)
            {
                return operations.ListByIncidentNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all incident comments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IncidentComment>> ListByIncidentNextAsync(this IIncidentCommentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIncidentNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
