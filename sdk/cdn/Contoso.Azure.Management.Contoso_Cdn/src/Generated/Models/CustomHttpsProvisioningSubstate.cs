// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Contoso.Azure.Management.Cdn.Models
{

    /// <summary>
    /// Defines values for CustomHttpsProvisioningSubstate.
    /// </summary>
    public static class CustomHttpsProvisioningSubstate
    {
        public const string SubmittingDomainControlValidationRequest = "SubmittingDomainControlValidationRequest";
        public const string PendingDomainControlValidationREquestApproval = "PendingDomainControlValidationREquestApproval";
        public const string DomainControlValidationRequestApproved = "DomainControlValidationRequestApproved";
        public const string DomainControlValidationRequestRejected = "DomainControlValidationRequestRejected";
        public const string DomainControlValidationRequestTimedOut = "DomainControlValidationRequestTimedOut";
        public const string IssuingCertificate = "IssuingCertificate";
        public const string DeployingCertificate = "DeployingCertificate";
        public const string CertificateDeployed = "CertificateDeployed";
        public const string DeletingCertificate = "DeletingCertificate";
        public const string CertificateDeleted = "CertificateDeleted";
    }
}
