// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CaseRelationsOperations.
    /// </summary>
    public static partial class CaseRelationsOperationsExtensions
    {
            /// <summary>
            /// Gets all case relations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
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
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static IPage<CaseRelation> List(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, ODataQuery<CaseRelation> odataQuery = default(ODataQuery<CaseRelation>), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all case relations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
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
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static async Task<IPage<CaseRelation>> ListAsync(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, ODataQuery<CaseRelation> odataQuery = default(ODataQuery<CaseRelation>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a case relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static CaseRelation GetRelation(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, string relationName)
            {
                return operations.GetRelationAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, relationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a case relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static async Task<CaseRelation> GetRelationAsync(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, string relationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRelationWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, relationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the case relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='relationInputModel'>
            /// The relation input model
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static CaseRelation CreateOrUpdateRelation(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, string relationName, RelationsModelInput relationInputModel)
            {
                return operations.CreateOrUpdateRelationAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, relationName, relationInputModel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the case relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='relationInputModel'>
            /// The relation input model
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static async Task<CaseRelation> CreateOrUpdateRelationAsync(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, string relationName, RelationsModelInput relationInputModel, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateRelationWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, relationName, relationInputModel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the case relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static void DeleteRelation(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, string relationName)
            {
                operations.DeleteRelationAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, relationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the case relation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='caseId'>
            /// Case ID
            /// </param>
            /// <param name='relationName'>
            /// Relation Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static async Task DeleteRelationAsync(this ICaseRelationsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string caseId, string relationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteRelationWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, caseId, relationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all case relations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static IPage<CaseRelation> ListNext(this ICaseRelationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all case relations.
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
            [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
            public static async Task<IPage<CaseRelation>> ListNextAsync(this ICaseRelationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
