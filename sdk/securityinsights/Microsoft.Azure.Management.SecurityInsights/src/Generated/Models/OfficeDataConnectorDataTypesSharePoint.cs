// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Contoso.Management.SecurityInsights.Models
{
    using System.Linq;

    /// <summary>
    /// SharePoint data type connection.
    /// </summary>
    public partial class OfficeDataConnectorDataTypesSharePoint : DataConnectorDataTypeCommon
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OfficeDataConnectorDataTypesSharePoint class.
        /// </summary>
        public OfficeDataConnectorDataTypesSharePoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OfficeDataConnectorDataTypesSharePoint class.
        /// </summary>
        /// <param name="state">Describe whether this data type connection is
        /// enabled or not. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public OfficeDataConnectorDataTypesSharePoint(string state = default(string))
            : base(state)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
