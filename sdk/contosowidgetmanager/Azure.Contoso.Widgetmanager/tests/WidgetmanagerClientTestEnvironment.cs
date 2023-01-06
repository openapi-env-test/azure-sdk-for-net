// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Contoso.Widgetmanager.Tests
{
    public class WidgetmanagerClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("Widgetmanager_ENDPOINT");

        // Add other client paramters here as above.
    }
}
