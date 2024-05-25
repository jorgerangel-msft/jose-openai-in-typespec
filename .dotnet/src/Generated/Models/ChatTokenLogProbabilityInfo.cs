// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class ChatTokenLogProbabilityInfo
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal ChatTokenLogProbabilityInfo(string token, float logProbability, IEnumerable<int> utf8ByteValues, IEnumerable<ChatTokenTopLogProbabilityInfo> topLogProbabilities)
        {
            Argument.AssertNotNull(token, nameof(token));
            Argument.AssertNotNull(topLogProbabilities, nameof(topLogProbabilities));

            Token = token;
            LogProbability = logProbability;
            Utf8ByteValues = utf8ByteValues?.ToList();
            TopLogProbabilities = topLogProbabilities.ToList();
        }

        internal ChatTokenLogProbabilityInfo(string token, float logProbability, IReadOnlyList<int> utf8ByteValues, IReadOnlyList<ChatTokenTopLogProbabilityInfo> topLogProbabilities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8ByteValues = utf8ByteValues;
            TopLogProbabilities = topLogProbabilities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ChatTokenLogProbabilityInfo()
        {
        }

        public string Token { get; }
    }
}
