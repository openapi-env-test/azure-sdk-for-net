// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The result of the query compilation request. </summary>
    public partial class StreamAnalyticsQueryCompilationResult
    {
        /// <summary> Initializes a new instance of StreamAnalyticsQueryCompilationResult. </summary>
        internal StreamAnalyticsQueryCompilationResult()
        {
            Errors = new ChangeTrackingList<StreamAnalyticsQueryCompilationError>();
            Warnings = new ChangeTrackingList<string>();
            Inputs = new ChangeTrackingList<string>();
            Outputs = new ChangeTrackingList<string>();
            Functions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of StreamAnalyticsQueryCompilationResult. </summary>
        /// <param name="errors"> Error messages produced by the compiler. </param>
        /// <param name="warnings"> Warning messages produced by the compiler. </param>
        /// <param name="inputs"> All input names used by the query. </param>
        /// <param name="outputs"> All output names used by the query. </param>
        /// <param name="functions"> All function names used by the query. </param>
        internal StreamAnalyticsQueryCompilationResult(IReadOnlyList<StreamAnalyticsQueryCompilationError> errors, IReadOnlyList<string> warnings, IReadOnlyList<string> inputs, IReadOnlyList<string> outputs, IReadOnlyList<string> functions)
        {
            Errors = errors;
            Warnings = warnings;
            Inputs = inputs;
            Outputs = outputs;
            Functions = functions;
        }

        /// <summary> Error messages produced by the compiler. </summary>
        public IReadOnlyList<StreamAnalyticsQueryCompilationError> Errors { get; }
        /// <summary> Warning messages produced by the compiler. </summary>
        public IReadOnlyList<string> Warnings { get; }
        /// <summary> All input names used by the query. </summary>
        public IReadOnlyList<string> Inputs { get; }
        /// <summary> All output names used by the query. </summary>
        public IReadOnlyList<string> Outputs { get; }
        /// <summary> All function names used by the query. </summary>
        public IReadOnlyList<string> Functions { get; }
    }
}
