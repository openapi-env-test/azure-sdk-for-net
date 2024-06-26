// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBSqlContainerResource : IJsonModel<CosmosDBSqlContainerData>
    {
        void IJsonModel<CosmosDBSqlContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBSqlContainerData>)Data).Write(writer, options);

        CosmosDBSqlContainerData IJsonModel<CosmosDBSqlContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CosmosDBSqlContainerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CosmosDBSqlContainerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CosmosDBSqlContainerData IPersistableModel<CosmosDBSqlContainerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CosmosDBSqlContainerData>(data, options);

        string IPersistableModel<CosmosDBSqlContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CosmosDBSqlContainerData>)Data).GetFormatFromOptions(options);
    }
}
