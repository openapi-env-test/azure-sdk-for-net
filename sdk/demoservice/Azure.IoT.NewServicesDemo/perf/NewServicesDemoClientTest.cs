﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Test.Perf;
using CommandLine;

namespace Azure.IoT.NewServicesDemo.Perf
{
    public class NewServicesDemoClientTest : PerfTest<NewServicesDemoClientTest.NewServicesDemoClientPerfOptions>
    {
        /* please refer to https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/template/Azure.Template/perf/TemplateClientTest.cs to write perf test. */

        public NewServicesDemoClientTest(NewServicesDemoClientPerfOptions options) : base(options)
        {
        }
        public class NewServicesDemoClientPerfOptions : PerfOptions
        {
        }

        public override void Run(CancellationToken cancellationToken)
        {
        }

        public override async Task RunAsync(CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("exec some async operation");
            });
        }
    }
}
