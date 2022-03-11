// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters for updating the sync properties of the connected
    /// registry with its parent.
    /// </summary>
    public partial class SyncUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the SyncUpdateProperties class.
        /// </summary>
        public SyncUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncUpdateProperties class.
        /// </summary>
        /// <param name="schedule">The cron expression indicating the schedule
        /// that the connected registry will sync with its parent.</param>
        /// <param name="syncWindow">The time window during which sync is
        /// enabled for each schedule occurrence. Specify the duration using
        /// the format P[n]Y[n]M[n]DT[n]H[n]M[n]S as per ISO8601.</param>
        /// <param name="messageTtl">The period of time for which a message is
        /// available to sync before it is expired. Specify the duration using
        /// the format P[n]Y[n]M[n]DT[n]H[n]M[n]S as per ISO8601.</param>
        public SyncUpdateProperties(string schedule = default(string), System.TimeSpan? syncWindow = default(System.TimeSpan?), System.TimeSpan? messageTtl = default(System.TimeSpan?))
        {
            Schedule = schedule;
            SyncWindow = syncWindow;
            MessageTtl = messageTtl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the cron expression indicating the schedule that the
        /// connected registry will sync with its parent.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or sets the time window during which sync is enabled for each
        /// schedule occurrence. Specify the duration using the format
        /// P[n]Y[n]M[n]DT[n]H[n]M[n]S as per ISO8601.
        /// </summary>
        [JsonProperty(PropertyName = "syncWindow")]
        public System.TimeSpan? SyncWindow { get; set; }

        /// <summary>
        /// Gets or sets the period of time for which a message is available to
        /// sync before it is expired. Specify the duration using the format
        /// P[n]Y[n]M[n]DT[n]H[n]M[n]S as per ISO8601.
        /// </summary>
        [JsonProperty(PropertyName = "messageTtl")]
        public System.TimeSpan? MessageTtl { get; set; }

    }
}
