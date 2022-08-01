using Ncfe.CodeTest;
using NUnit.Framework;
namespace TestLeaner
{
    public class Tests
    {
        [Test]
        [TestCase(1, true)]
        [TestCase(1, false)]
        public void GetLeanerTest_Success(int Id,bool IsArchive)
        {
           LearnerService learnerService = new LearnerService();
           var data= learnerService.GetLearner(Id, IsArchive);  
           Assert.IsNotNull(data);
           Assert.Pass();
        }
        [Test]
        [TestCase(20000, true)]
        public void GetLeanerTest_Failover(int Id, bool IsArchive)
        {
            LearnerService learnerService = new LearnerService();
            var data = learnerService.GetLearner(Id, IsArchive);
            Assert.IsNotNull(data);
            Assert.AreEqual(data.Name,null);
        }
        [Test]
        public void GetLeanerTest_Error()
        {
            LearnerService learnerService = new LearnerService();
            var data = learnerService.GetLearner(-1,true );
            Assert.IsNotNull(data);
            Assert.AreEqual(data.Id, 0);
        }
        private Learner SampleData()
        {
            return new Learner
            {
                Name = "Prit",
                Id = 1,
            };

        }
    }
}