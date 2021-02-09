using System;
using System.Collections.Generic;
using System.Text;
using TechJobsOO;

namespace TechJobsOO
{
    public abstract class JobFields
    {
        public int Id { get; set; }
        public static int nextId = 1;
        public string Value { get; set; }
        
        public JobFields()
        {
            Id = nextId;
            nextId++;
        }
        public JobFields(string value) : this()
        {
           Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override bool Equals(object obj)
        {
            return obj is JobFields field &&
                   Id == field.Id;
        }
    }
}
