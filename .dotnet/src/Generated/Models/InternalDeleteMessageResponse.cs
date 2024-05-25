// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI.Models;

namespace OpenAI.Assistants
{
    internal partial class InternalDeleteMessageResponse
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalDeleteMessageResponse(string id, bool deleted)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Deleted = deleted;
        }

        internal InternalDeleteMessageResponse(string id, bool deleted, object @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Deleted = deleted;
            Object = @object;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalDeleteMessageResponse()
        {
        }

        public string Id { get; }
        public bool Deleted { get; }
    }
}
