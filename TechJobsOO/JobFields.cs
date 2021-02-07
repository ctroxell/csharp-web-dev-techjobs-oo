using System;
using System.Collections.Generic;
using System.Text;
using TechJobsOO;

namespace TechJobsOO
{
    class JobFields
    {
        public string Name { get; set; }
        public int Id { get; set }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public JobFields(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        {
            Name = name;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            Id = 1;
        }

        public JobFields()
        {
            Id = Id++;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
    }
}
