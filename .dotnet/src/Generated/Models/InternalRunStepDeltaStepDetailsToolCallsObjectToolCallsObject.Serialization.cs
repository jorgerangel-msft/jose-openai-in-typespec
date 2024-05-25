// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace OpenAI.Assistants
{
    [PersistableModelProxy(typeof(UnknownRunStepDeltaStepDetailsToolCallsObjectToolCallsObject))]
    internal partial class InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject : IJsonModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>
    {
        void IJsonModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject IJsonModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(document.RootElement, options);
        }

        internal static InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject DeserializeInternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "code_interpreter": return InternalRunStepDeltaStepDetailsToolCallsCodeObject.DeserializeInternalRunStepDeltaStepDetailsToolCallsCodeObject(element, options);
                    case "file_search": return InternalRunStepDeltaStepDetailsToolCallsFileSearchObject.DeserializeInternalRunStepDeltaStepDetailsToolCallsFileSearchObject(element, options);
                    case "function": return InternalRunStepDeltaStepDetailsToolCallsFunctionObject.DeserializeInternalRunStepDeltaStepDetailsToolCallsFunctionObject(element, options);
                }
            }
            return UnknownRunStepDeltaStepDetailsToolCallsObjectToolCallsObject.DeserializeUnknownRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(element, options);
        }

        BinaryData IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRunStepDeltaStepDetailsToolCallsObjectToolCallsObject(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
