// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AlertsOperations.
    /// </summary>
    public static partial class AlertsOperationsExtensions
    {
            /// <summary>
            /// Lists the alerts for scope defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with alerts operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId} for
            /// Management Group scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            public static AlertsResult List(this IAlertsOperations operations, string scope)
            {
                return operations.ListAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the alerts for scope defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with alerts operations. This includes
            /// '/subscriptions/{subscriptionId}/' for subscription scope,
            /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// '/providers/Microsoft.Management/managementGroups/{managementGroupId} for
            /// Management Group scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for billingProfile scope,
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
            /// for invoiceSection scope, and
            /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
            /// specific for partners.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AlertsResult> ListAsync(this IAlertsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the Alerts for external cloud provider type defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='externalCloudProviderType'>
            /// The external cloud provider type associated with dimension/query
            /// operations. This includes 'externalSubscriptions' for linked account and
            /// 'externalBillingAccounts' for consolidated account. Possible values
            /// include: 'externalSubscriptions', 'externalBillingAccounts'
            /// </param>
            /// <param name='externalCloudProviderId'>
            /// This can be '{externalSubscriptionId}' for linked account or
            /// '{externalBillingAccountId}' for consolidated account used with
            /// dimension/query operations.
            /// </param>
            public static AlertsResult ListExternal(this IAlertsOperations operations, string externalCloudProviderType, string externalCloudProviderId)
            {
                return operations.ListExternalAsync(externalCloudProviderType, externalCloudProviderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the Alerts for external cloud provider type defined.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='externalCloudProviderType'>
            /// The external cloud provider type associated with dimension/query
            /// operations. This includes 'externalSubscriptions' for linked account and
            /// 'externalBillingAccounts' for consolidated account. Possible values
            /// include: 'externalSubscriptions', 'externalBillingAccounts'
            /// </param>
            /// <param name='externalCloudProviderId'>
            /// This can be '{externalSubscriptionId}' for linked account or
            /// '{externalBillingAccountId}' for consolidated account used with
            /// dimension/query operations.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AlertsResult> ListExternalAsync(this IAlertsOperations operations, string externalCloudProviderType, string externalCloudProviderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListExternalWithHttpMessagesAsync(externalCloudProviderType, externalCloudProviderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
