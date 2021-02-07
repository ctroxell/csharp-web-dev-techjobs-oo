using System;
using TechJobsOO;

namespace TechJobsTests
{
    class JobTests
    {
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job1.Id + 1 == job2.Id);
        }
    }
}
