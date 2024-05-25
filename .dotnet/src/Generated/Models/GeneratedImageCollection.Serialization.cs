// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace OpenAI.Images
{
    public partial class GeneratedImageCollection : IJsonModel<GeneratedImageCollection>
    {
        GeneratedImageCollection IJsonModel<GeneratedImageCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGeneratedImageCollection(document.RootElement, options);
        }

        BinaryData IPersistableModel<GeneratedImageCollection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support writing '{options.Format}' format.");
            }
        }

        GeneratedImageCollection IPersistableModel<GeneratedImageCollection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGeneratedImageCollection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GeneratedImageCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static GeneratedImageCollection FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeneratedImageCollection(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
