using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ncfe.CodeTest
{
    public class LearnerDataAccess
    {
        public LearnerResponse LoadLearner(int learnerId)
        {
            // rettrieve learner from 3rd party webservice
            LearnerResponse learnerResponse = null;
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = TimeSpan.FromMinutes(10);
                //call Rest API as per URI condition 
                learnerResponse=new LearnerResponse();
            }
            catch(HttpRequestException ex) {
                learnerResponse = FailoverLearnerDataAccess.GetLearnerById(learnerId);
            }
            return learnerResponse;
        }
    }
}
