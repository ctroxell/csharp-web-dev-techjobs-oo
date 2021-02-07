using System;
namespace TechJobsOO
{
    public class Location
    {
        public int Id { get; }
        public string Value { get; set; }

        public Location()
        {
            Id = Id++;
        }

        public Location(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
