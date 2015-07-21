using System;
using System.Collections.Generic;

namespace CrowdfundingSolution.BLLInterface
{
    public interface ICrowdfundingPlan
    {
        void Add(Dictionary<string,string> data);
        void GetProjectList();
        List<DAO.CrowdfundingPlan> GetCrowdPlanByID(string ID);
        void Update(string ID, Dictionary<string, string> data);
    }
}