// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Assistants
{
    internal static partial class RunStepKindExtensions
    {
        public static string ToSerialString(this Assistants.RunStepKind value) => value switch
        {
            Assistants.RunStepKind.CreatedMessage => "message_creation",
            Assistants.RunStepKind.ToolCall => "tool_calls",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RunStepKind value.")
        };

        public static Assistants.RunStepKind ToRunStepKind(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "message_creation"))
            {
                return Assistants.RunStepKind.CreatedMessage;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "tool_calls"))
            {
                return Assistants.RunStepKind.ToolCall;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RunStepKind value.");
        }
    }
}