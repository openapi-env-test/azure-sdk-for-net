// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Analytics.Purview.Shared.Tests
{
    public class SharedClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("Shared_ENDPOINT");

        // Add other client paramters here as above.
    }
}
