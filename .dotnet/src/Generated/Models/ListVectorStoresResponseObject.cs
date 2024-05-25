// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    internal readonly partial struct ListVectorStoresResponseObject : IEquatable<ListVectorStoresResponseObject>
    {
        private readonly string _value;

        public ListVectorStoresResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        public static ListVectorStoresResponseObject List { get; } = new ListVectorStoresResponseObject(ListValue);
        public static bool operator ==(ListVectorStoresResponseObject left, ListVectorStoresResponseObject right) => left.Equals(right);
        public static bool operator !=(ListVectorStoresResponseObject left, ListVectorStoresResponseObject right) => !left.Equals(right);
        public static implicit operator ListVectorStoresResponseObject(string value) => new ListVectorStoresResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListVectorStoresResponseObject other && Equals(other);
        public bool Equals(ListVectorStoresResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        public override string ToString() => _value;
    }
}
