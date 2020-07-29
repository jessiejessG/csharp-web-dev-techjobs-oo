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

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string value, Employer employer, Location location, PositionType position, CoreCompetency coreCompetency) : this()
        {
            Name = value;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = position;
            JobCoreCompetency = coreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.

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
            if (Name == "")
            {
                Name = "Data not available";
            }
            if (string.IsNullOrEmpty(EmployerName.Value))
            {
                EmployerName.Value = "Data not available";
            }
            if (string.IsNullOrEmpty(EmployerLocation.Value))
            {
                EmployerLocation.Value = "Data not available";
            }
            if (string.IsNullOrEmpty(JobType.Value))
            {
                JobType.Value = "Data not available";
            }
            if (string.IsNullOrEmpty(JobCoreCompetency.Value))
            {
                JobCoreCompetency.Value = "Data not available";
            }
            return $"ID: {Id} \n Name: {Name} \n Employer: {EmployerName} \n Location: {EmployerLocation} \n Position Type: {JobType} \n Core Competency: {JobCoreCompetency}";
        }
    }
}
