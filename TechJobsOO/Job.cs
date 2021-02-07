using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
                    
            string idString = "ID: " + Id;
            string nameString = "\nName: " + Name;
            string employerString = "\nEmployer: " + EmployerName.Value;
            string locationString = "\nLocation: " + EmployerLocation.Value;
            string positionString = "\nPosition Type: " + JobType.Value;
            string coreString = "\nCore Competency: " + JobCoreCompetency.Value;

            if(idString.Length == 4)
            {
                idString = "ID: Data not available";
            }
            if (nameString.Length == 7)
            {
                nameString = "\nName: Data not available";
            }
            if (employerString.Length == 11)
            {
                employerString = "\nEmployer: Data not available";
            }
            if (locationString.Length == 11)
            {
                locationString = "\nLocation: Data not available";
            }
            if (positionString.Length == 16)
            {
                positionString = "\nPosition Type: Data not available";
            }
            if (coreString.Length == 18)
            {
                coreString = "\nCore Competency: Data not available";
            }

            string fullJobString = idString + nameString + employerString + locationString + positionString + coreString;

            return fullJobString;
        }

    }
}
