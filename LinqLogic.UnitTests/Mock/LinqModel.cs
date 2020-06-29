using System;

namespace LinqLogic.UnitTests.Mock
{
    // IEquatable interface to allow for .Equals comparison on objects.
    // Assumption here is this is some kind of data model, and we're just comparing on Id.
    public sealed class LinqModel : IEquatable<LinqModel>
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public LinqModel(int id, string value)
        {
            Id = id;
            Value = value;
        }

        bool IEquatable<LinqModel>.Equals(LinqModel other)
        {
            if (other == null) return false;

            if (Id != other.Id) return false;

            return true;
        }
    }
}
