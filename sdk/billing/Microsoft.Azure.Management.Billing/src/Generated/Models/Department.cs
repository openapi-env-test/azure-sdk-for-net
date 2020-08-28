// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A department.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Department : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Department class.
        /// </summary>
        public Department()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Department class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="departmentName">The name of the department.</param>
        /// <param name="costCenter">The cost center associated with the
        /// department.</param>
        /// <param name="status">The status of the department.</param>
        /// <param name="enrollmentAccounts">Associated enrollment accounts. By
        /// default this is not populated, unless it's specified in
        /// $expand.</param>
        public Department(string id = default(string), string name = default(string), string type = default(string), string departmentName = default(string), string costCenter = default(string), string status = default(string), IList<EnrollmentAccount> enrollmentAccounts = default(IList<EnrollmentAccount>))
            : base(id, name, type)
        {
            DepartmentName = departmentName;
            CostCenter = costCenter;
            Status = status;
            EnrollmentAccounts = enrollmentAccounts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the department.
        /// </summary>
        [JsonProperty(PropertyName = "properties.departmentName")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets the cost center associated with the department.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costCenter")]
        public string CostCenter { get; set; }

        /// <summary>
        /// Gets or sets the status of the department.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets associated enrollment accounts. By default this is not
        /// populated, unless it's specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentAccounts")]
        public IList<EnrollmentAccount> EnrollmentAccounts { get; set; }

    }
}
