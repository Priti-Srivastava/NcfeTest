using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncfe.CodeTest
{
    public class LearnerService: ILeanerService
    {
        public Learner GetLearner(int learnerId, bool isLearnerArchived)
        {
            Learner archivedLearner = null;
            try
            {
                if (isLearnerArchived)
                {
                    var archivedDataService = new ArchivedDataService();
                    archivedLearner = archivedDataService.GetArchivedLearner(learnerId);

                    return archivedLearner;
                }
                else
                {
                    var dataAccess = new LearnerDataAccess();
                    var learnerResponse = dataAccess.LoadLearner(learnerId);
                    return learnerResponse.Learner;
                }
            }
            catch (Exception)
            {
                return new Learner();
            }
        }

    }
}
