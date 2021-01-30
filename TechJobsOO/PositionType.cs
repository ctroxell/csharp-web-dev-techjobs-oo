using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.

        public override string ToString()
        {
            return $"{this.Value}";
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
            Id == positionType.Id &&
            EqualityComparer<int>.Default.Equals(Id, positionType.Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
