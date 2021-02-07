using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private int Id;
        public string Value;

        public CoreCompetency()
        {
            Id = Id++;
        }

        public CoreCompetency(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
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

