// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Administration
{
    /// <summary> The PurviewMetadataPolicy service client. </summary>
    public partial class PurviewMetadataPolicyClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _collectionName;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewMetadataPolicyClient for mocking. </summary>
        protected PurviewMetadataPolicyClient()
        {
        }

        /// <summary> Updates a metadata policy. </summary>
        /// <param name="policyId"> Unique policy id. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>MetadataPolicy</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>MetadataPolicy</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> UpdateMetadataPolicyAsync(string policyId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(policyId, nameof(policyId));

            using var scope = ClientDiagnostics.CreateScope("PurviewMetadataPolicyClient.UpdateMetadataPolicy");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateMetadataPolicyRequest(policyId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a metadata policy. </summary>
        /// <param name="policyId"> Unique policy id. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>MetadataPolicy</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>MetadataPolicy</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response UpdateMetadataPolicy(string policyId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(policyId, nameof(policyId));

            using var scope = ClientDiagnostics.CreateScope("PurviewMetadataPolicyClient.UpdateMetadataPolicy");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateMetadataPolicyRequest(policyId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a metadata policy. </summary>
        /// <param name="policyId"> Id of an existing policy that needs to be fetched. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>MetadataPolicy</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetMetadataPolicyAsync(string policyId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(policyId, nameof(policyId));

            using var scope = ClientDiagnostics.CreateScope("PurviewMetadataPolicyClient.GetMetadataPolicy");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetMetadataPolicyRequest(policyId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a metadata policy. </summary>
        /// <param name="policyId"> Id of an existing policy that needs to be fetched. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>MetadataPolicy</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetMetadataPolicy(string policyId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(policyId, nameof(policyId));

            using var scope = ClientDiagnostics.CreateScope("PurviewMetadataPolicyClient.GetMetadataPolicy");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetMetadataPolicyRequest(policyId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List or Get metadata policies. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for one item in the pageable response.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>MetadataPolicyListValues</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetMetadataPoliciesAsync(RequestContext context = null)
        {
            return GetMetadataPoliciesImplementationAsync("PurviewMetadataPolicyClient.GetMetadataPolicies", context);
        }

        private AsyncPageable<BinaryData> GetMetadataPoliciesImplementationAsync(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetMetadataPoliciesRequest(context)
                        : CreateGetMetadataPoliciesNextPageRequest(nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "values", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> List or Get metadata policies. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <remarks>
        /// Below is the JSON schema for one item in the pageable response.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>MetadataPolicyListValues</c>:
        /// <code>{
        ///   name: string, # Optional. The name of policy
        ///   id: string, # Optional. The id of policy
        ///   version: number, # Optional. The version of policy
        ///   properties: {
        ///     description: string, # Optional. The description of policy
        ///     decisionRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         effect: &quot;Deny&quot; | &quot;Permit&quot;, # Optional. The effect for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The DecisionRules of policy
        ///     attributeRules: [
        ///       {
        ///         kind: &quot;decisionrule&quot; | &quot;attributerule&quot;, # Optional. The kind of rule
        ///         id: string, # Optional. The id for rule
        ///         name: string, # Optional. The name for rule
        ///         dnfCondition: [AttributeMatcher[]], # Optional. The dnf Condition for a rule
        ///       }
        ///     ], # Optional. The AttributeRules of policy
        ///     collection: {
        ///       type: string, # Optional. The type of reference
        ///       referenceName: string, # Optional. The name of reference
        ///     }, # Optional. The collection reference for a policy
        ///     parentCollectionName: string, # Optional. The parent collection of the policy
        ///   }, # Optional.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetMetadataPolicies(RequestContext context = null)
        {
            return GetMetadataPoliciesImplementation("PurviewMetadataPolicyClient.GetMetadataPolicies", context);
        }

        private Pageable<BinaryData> GetMetadataPoliciesImplementation(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetMetadataPoliciesRequest(context)
                        : CreateGetMetadataPoliciesNextPageRequest(nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "values", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetMetadataPoliciesRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/policyStore", false);
            uri.AppendPath("/metadataPolicies", false);
            uri.AppendQuery("api-version", "2021-07-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateUpdateMetadataPolicyRequest(string policyId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/policyStore", false);
            uri.AppendPath("/metadataPolicies/", false);
            uri.AppendPath(policyId, true);
            uri.AppendQuery("api-version", "2021-07-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetMetadataPolicyRequest(string policyId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/policyStore", false);
            uri.AppendPath("/metadataPolicies/", false);
            uri.AppendPath(policyId, true);
            uri.AppendQuery("api-version", "2021-07-01-preview", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetMetadataPoliciesNextPageRequest(string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/policyStore", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
