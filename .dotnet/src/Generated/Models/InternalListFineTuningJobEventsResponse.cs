// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.FineTuning
{
    /// <summary> The ListFineTuningJobEventsResponse. </summary>
    internal partial class InternalListFineTuningJobEventsResponse
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InternalListFineTuningJobEventsResponse"/>. </summary>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal InternalListFineTuningJobEventsResponse(IEnumerable<InternalFineTuningJobEvent> data)
        {
            Argument.AssertNotNull(data, nameof(data));

            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="InternalListFineTuningJobEventsResponse"/>. </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalListFineTuningJobEventsResponse(IReadOnlyList<InternalFineTuningJobEvent> data, InternalListFineTuningJobEventsResponseObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Data = data;
            Object = @object;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalListFineTuningJobEventsResponse"/> for deserialization. </summary>
        internal InternalListFineTuningJobEventsResponse()
        {
        }

        /// <summary> Gets the data. </summary>
        public IReadOnlyList<InternalFineTuningJobEvent> Data { get; }
        /// <summary> Gets the object. </summary>
        public InternalListFineTuningJobEventsResponseObject Object { get; } = InternalListFineTuningJobEventsResponseObject.List;
    }
}