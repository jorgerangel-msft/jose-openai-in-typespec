// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    internal partial class BatchRequestOutputError
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal BatchRequestOutputError()
        {
        }

        internal BatchRequestOutputError(string code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string Code { get; }
        public string Message { get; }
    }
}
