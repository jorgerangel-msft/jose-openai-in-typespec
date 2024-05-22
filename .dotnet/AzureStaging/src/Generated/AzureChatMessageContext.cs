// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The AzureChatMessageContext. </summary>
    public partial class AzureChatMessageContext
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureChatMessageContext"/>. </summary>
        internal AzureChatMessageContext()
        {
            Citations = new ChangeTrackingList<AzureChatCitation>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatMessageContext"/>. </summary>
        /// <param name="intent"></param>
        /// <param name="citations"></param>
        /// <param name="allRetrievedDocuments"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureChatMessageContext(string intent, IReadOnlyList<AzureChatCitation> citations, AzureChatRetrievedDocument allRetrievedDocuments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Intent = intent;
            Citations = citations;
            AllRetrievedDocuments = allRetrievedDocuments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the intent. </summary>
        public string Intent { get; }
        /// <summary> Gets the citations. </summary>
        public IReadOnlyList<AzureChatCitation> Citations { get; }
        /// <summary> Gets the all retrieved documents. </summary>
        public AzureChatRetrievedDocument AllRetrievedDocuments { get; }
    }
}