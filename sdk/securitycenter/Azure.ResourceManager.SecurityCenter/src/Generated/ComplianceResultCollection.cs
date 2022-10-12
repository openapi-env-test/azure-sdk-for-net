// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="ComplianceResultResource" /> and their operations.
    /// Each <see cref="ComplianceResultResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="ComplianceResultCollection" /> instance call the GetComplianceResults method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class ComplianceResultCollection : ArmCollection, IEnumerable<ComplianceResultResource>, IAsyncEnumerable<ComplianceResultResource>
    {
        private readonly ClientDiagnostics _complianceResultClientDiagnostics;
        private readonly ComplianceResultsRestOperations _complianceResultRestClient;

        /// <summary> Initializes a new instance of the <see cref="ComplianceResultCollection"/> class for mocking. </summary>
        protected ComplianceResultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ComplianceResultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ComplianceResultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _complianceResultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ComplianceResultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ComplianceResultResource.ResourceType, out string complianceResultApiVersion);
            _complianceResultRestClient = new ComplianceResultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, complianceResultApiVersion);
        }

        /// <summary>
        /// Security Compliance Result
        /// Request Path: /{resourceId}/providers/Microsoft.Security/complianceResults/{complianceResultName}
        /// Operation Id: ComplianceResults_Get
        /// </summary>
        /// <param name="complianceResultName"> name of the desired assessment compliance result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="complianceResultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="complianceResultName"/> is null. </exception>
        public virtual async Task<Response<ComplianceResultResource>> GetAsync(string complianceResultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(complianceResultName, nameof(complianceResultName));

            using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.Get");
            scope.Start();
            try
            {
                var response = await _complianceResultRestClient.GetAsync(Id, complianceResultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComplianceResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Security Compliance Result
        /// Request Path: /{resourceId}/providers/Microsoft.Security/complianceResults/{complianceResultName}
        /// Operation Id: ComplianceResults_Get
        /// </summary>
        /// <param name="complianceResultName"> name of the desired assessment compliance result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="complianceResultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="complianceResultName"/> is null. </exception>
        public virtual Response<ComplianceResultResource> Get(string complianceResultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(complianceResultName, nameof(complianceResultName));

            using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.Get");
            scope.Start();
            try
            {
                var response = _complianceResultRestClient.Get(Id, complianceResultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ComplianceResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Security compliance results in the subscription
        /// Request Path: /{scope}/providers/Microsoft.Security/complianceResults
        /// Operation Id: ComplianceResults_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ComplianceResultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ComplianceResultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ComplianceResultResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _complianceResultRestClient.ListAsync(Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComplianceResultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ComplianceResultResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _complianceResultRestClient.ListNextPageAsync(nextLink, Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ComplianceResultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Security compliance results in the subscription
        /// Request Path: /{scope}/providers/Microsoft.Security/complianceResults
        /// Operation Id: ComplianceResults_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ComplianceResultResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ComplianceResultResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ComplianceResultResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _complianceResultRestClient.List(Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComplianceResultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ComplianceResultResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _complianceResultRestClient.ListNextPage(nextLink, Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ComplianceResultResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceId}/providers/Microsoft.Security/complianceResults/{complianceResultName}
        /// Operation Id: ComplianceResults_Get
        /// </summary>
        /// <param name="complianceResultName"> name of the desired assessment compliance result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="complianceResultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="complianceResultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string complianceResultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(complianceResultName, nameof(complianceResultName));

            using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _complianceResultRestClient.GetAsync(Id, complianceResultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /{resourceId}/providers/Microsoft.Security/complianceResults/{complianceResultName}
        /// Operation Id: ComplianceResults_Get
        /// </summary>
        /// <param name="complianceResultName"> name of the desired assessment compliance result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="complianceResultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="complianceResultName"/> is null. </exception>
        public virtual Response<bool> Exists(string complianceResultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(complianceResultName, nameof(complianceResultName));

            using var scope = _complianceResultClientDiagnostics.CreateScope("ComplianceResultCollection.Exists");
            scope.Start();
            try
            {
                var response = _complianceResultRestClient.Get(Id, complianceResultName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ComplianceResultResource> IEnumerable<ComplianceResultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ComplianceResultResource> IAsyncEnumerable<ComplianceResultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
