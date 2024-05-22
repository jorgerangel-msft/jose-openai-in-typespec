// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.FineTuning
{
    internal partial class InternalListPaginatedFineTuningJobsResponse : IJsonModel<InternalListPaginatedFineTuningJobsResponse>
    {
        void IJsonModel<InternalListPaginatedFineTuningJobsResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("has_more"u8);
            writer.WriteBooleanValue(HasMore);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
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

        InternalListPaginatedFineTuningJobsResponse IJsonModel<InternalListPaginatedFineTuningJobsResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalListPaginatedFineTuningJobsResponse(document.RootElement, options);
        }

        internal static InternalListPaginatedFineTuningJobsResponse DeserializeInternalListPaginatedFineTuningJobsResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<InternalFineTuningJob> data = default;
            bool hasMore = default;
            InternalListPaginatedFineTuningJobsResponseObject @object = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    List<InternalFineTuningJob> array = new List<InternalFineTuningJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InternalFineTuningJob.DeserializeInternalFineTuningJob(item, options));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("has_more"u8))
                {
                    hasMore = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new InternalListPaginatedFineTuningJobsResponseObject(property.Value.GetString());
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalListPaginatedFineTuningJobsResponse(data, hasMore, @object, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalListPaginatedFineTuningJobsResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support writing '{options.Format}' format.");
            }
        }

        InternalListPaginatedFineTuningJobsResponse IPersistableModel<InternalListPaginatedFineTuningJobsResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalListPaginatedFineTuningJobsResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalListPaginatedFineTuningJobsResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalListPaginatedFineTuningJobsResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalListPaginatedFineTuningJobsResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static InternalListPaginatedFineTuningJobsResponse FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalListPaginatedFineTuningJobsResponse(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
