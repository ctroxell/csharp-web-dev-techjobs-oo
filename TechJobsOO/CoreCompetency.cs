using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private int id;
        private string value;

        public CoreCompetency()
        {
            id = id++;
        }

        public CoreCompetency(string v) : this()
        {
            value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
    }
}

