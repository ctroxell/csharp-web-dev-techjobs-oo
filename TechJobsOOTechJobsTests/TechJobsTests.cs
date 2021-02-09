using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO.TechJobsTests
{
    [TestClass()]
    public class TechJobTests
    {
        [TestMethod()]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job1.Id + 1 == job2.Id);
        }
        
        [TestMethod()]
        public void TestJobContructorSetsAllFields()
        {
            Job job3 = new Job { Name = "Product Tester", EmployerName = new Employer("ACME"), EmployerLocation = new Location("Desert"), JobType = new PositionType("Quality control"), JobCoreCompetency = new CoreCompetency("Persistence") };
            Assert.AreEqual(job3.Name, "Product Tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");

        }
        
        [TestMethod()]
        public void TestJobsForEquality()
        {
            Job job4 = new Job { Name = "A", EmployerName = new Employer("B"), EmployerLocation = new Location("C"), JobType = new PositionType("D"), JobCoreCompetency = new CoreCompetency("E") };
            Job job5 = new Job { Name = "A", EmployerName = new Employer("0"), EmployerLocation = new Location("C"), JobType = new PositionType("D"), JobCoreCompetency = new CoreCompetency("E") };
            Assert.IsFalse(job4.Id == job5.Id);
        }
        
        [TestMethod()]
        public void TestToStringMethod()
        {
            Job job6 = new Job { Name = "A", EmployerName = new Employer("B"), EmployerLocation = new Location("C"), JobType = new PositionType("D"), JobCoreCompetency = new CoreCompetency("E") };
            string correctString = "ID: 6\nName: A\nEmployer: B\nLocation: C\nPosition Type: D\nCore Competency: E";
            Assert.AreEqual(correctString, job6.ToString());
            Job job7 = new Job { Name = "A", EmployerName = new Employer("B"), EmployerLocation = new Location("C"), JobType = new PositionType("D"), JobCoreCompetency = new CoreCompetency("E") };
            job7.EmployerName.Value = "";
            string correctString2 = "ID: 7\nName: A\nEmployer: Data not available\nLocation: C\nPosition Type: D\nCore Competency: E";
            Assert.AreEqual(correctString2, job7.ToString());
        }
    }
}