// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Files
{
    /// <summary> The ListFilesResponse_object. </summary>
    internal readonly partial struct InternalListFilesResponseObject : IEquatable<InternalListFilesResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalListFilesResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalListFilesResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static InternalListFilesResponseObject List { get; } = new InternalListFilesResponseObject(ListValue);
        /// <summary> Determines if two <see cref="InternalListFilesResponseObject"/> values are the same. </summary>
        public static bool operator ==(InternalListFilesResponseObject left, InternalListFilesResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalListFilesResponseObject"/> values are not the same. </summary>
        public static bool operator !=(InternalListFilesResponseObject left, InternalListFilesResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalListFilesResponseObject"/>. </summary>
        public static implicit operator InternalListFilesResponseObject(string value) => new InternalListFilesResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalListFilesResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalListFilesResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}