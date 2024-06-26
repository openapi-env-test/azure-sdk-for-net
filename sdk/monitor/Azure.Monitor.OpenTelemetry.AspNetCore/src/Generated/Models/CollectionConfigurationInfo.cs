// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Monitor.OpenTelemetry.AspNetCore.Models
{
    /// <summary> Represents the collection configuration - a customizable description of performance counters, metrics, and full telemetry documents to be collected by the client SDK. </summary>
    internal partial class CollectionConfigurationInfo
    {
        /// <summary> Initializes a new instance of <see cref="CollectionConfigurationInfo"/>. </summary>
        /// <param name="eTag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="metrics"> An array of metric configuration info. </param>
        /// <param name="documentStreams"> An array of document stream configuration info. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eTag"/>, <paramref name="metrics"/> or <paramref name="documentStreams"/> is null. </exception>
        internal CollectionConfigurationInfo(string eTag, IEnumerable<DerivedMetricInfo> metrics, IEnumerable<DocumentStreamInfo> documentStreams)
        {
            Argument.AssertNotNull(eTag, nameof(eTag));
            Argument.AssertNotNull(metrics, nameof(metrics));
            Argument.AssertNotNull(documentStreams, nameof(documentStreams));

            ETag = eTag;
            Metrics = metrics.ToList();
            DocumentStreams = documentStreams.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CollectionConfigurationInfo"/>. </summary>
        /// <param name="eTag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="metrics"> An array of metric configuration info. </param>
        /// <param name="documentStreams"> An array of document stream configuration info. </param>
        /// <param name="quotaInfo"> Controls document quotas to be sent to Live Metrics. </param>
        internal CollectionConfigurationInfo(string eTag, IReadOnlyList<DerivedMetricInfo> metrics, IReadOnlyList<DocumentStreamInfo> documentStreams, QuotaConfigurationInfo quotaInfo)
        {
            ETag = eTag;
            Metrics = metrics;
            DocumentStreams = documentStreams;
            QuotaInfo = quotaInfo;
        }

        /// <summary> An encoded string that indicates whether the collection configuration is changed. </summary>
        public string ETag { get; }
        /// <summary> An array of metric configuration info. </summary>
        public IReadOnlyList<DerivedMetricInfo> Metrics { get; }
        /// <summary> An array of document stream configuration info. </summary>
        public IReadOnlyList<DocumentStreamInfo> DocumentStreams { get; }
        /// <summary> Controls document quotas to be sent to Live Metrics. </summary>
        public QuotaConfigurationInfo QuotaInfo { get; }
    }
}
