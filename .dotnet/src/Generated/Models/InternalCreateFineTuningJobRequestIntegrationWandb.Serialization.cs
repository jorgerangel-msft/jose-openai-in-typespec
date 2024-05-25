// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.FineTuning
{
    internal partial class InternalCreateFineTuningJobRequestIntegrationWandb : IJsonModel<InternalCreateFineTuningJobRequestIntegrationWandb>
    {
        void IJsonModel<InternalCreateFineTuningJobRequestIntegrationWandb>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateFineTuningJobRequestIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateFineTuningJobRequestIntegrationWandb)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("project"u8);
            writer.WriteStringValue(Project);
            if (Optional.IsDefined(Name))
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            if (Optional.IsDefined(Entity))
            {
                if (Entity != null)
                {
                    writer.WritePropertyName("entity"u8);
                    writer.WriteStringValue(Entity);
                }
                else
                {
                    writer.WriteNull("entity");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (true && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalCreateFineTuningJobRequestIntegrationWandb IJsonModel<InternalCreateFineTuningJobRequestIntegrationWandb>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateFineTuningJobRequestIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalCreateFineTuningJobRequestIntegrationWandb)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalCreateFineTuningJobRequestIntegrationWandb(document.RootElement, options);
        }

        internal static InternalCreateFineTuningJobRequestIntegrationWandb DeserializeInternalCreateFineTuningJobRequestIntegrationWandb(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string project = default;
            string name = default;
            string entity = default;
            IList<string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("project"u8))
                {
                    project = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        entity = null;
                        continue;
                    }
                    entity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalCreateFineTuningJobRequestIntegrationWandb(project, name, entity, tags ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalCreateFineTuningJobRequestIntegrationWandb>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateFineTuningJobRequestIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalCreateFineTuningJobRequestIntegrationWandb)} does not support writing '{options.Format}' format.");
            }
        }

        InternalCreateFineTuningJobRequestIntegrationWandb IPersistableModel<InternalCreateFineTuningJobRequestIntegrationWandb>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalCreateFineTuningJobRequestIntegrationWandb>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalCreateFineTuningJobRequestIntegrationWandb(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalCreateFineTuningJobRequestIntegrationWandb)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalCreateFineTuningJobRequestIntegrationWandb>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalCreateFineTuningJobRequestIntegrationWandb FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalCreateFineTuningJobRequestIntegrationWandb(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
