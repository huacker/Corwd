using System;
using System.Collections.Generic;

namespace CrowdfundingSolution.BLLInterface
{
    public interface ICrowdfundingPlan
    {
        void Add(Dictionary<string,string> data);
    }
}