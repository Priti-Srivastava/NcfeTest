﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncfe.CodeTest
{
    public interface ILeanerService
    {
        Learner GetLearner(int id, bool isArchive);
        
    }
}
