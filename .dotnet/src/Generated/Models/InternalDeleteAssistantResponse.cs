// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Models;

namespace OpenAI.Assistants
{
    internal partial class InternalDeleteAssistantResponse
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalDeleteAssistantResponse(string id, bool deleted)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Deleted = deleted;
        }

        internal InternalDeleteAssistantResponse(string id, bool deleted, object @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Deleted = deleted;
            Object = @object;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalDeleteAssistantResponse()
        {
        }

        public string Id { get; }
        public bool Deleted { get; }
    }
}
