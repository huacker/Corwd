using System.Collections.Generic;
using System.Data.Entity;
using CrowdfundingSolution.BLLInterface;
using System;
using System.Linq;

namespace CrowdfundingSolution.BLLObject
{
    public class CrowdfundingPlan:ICrowdfundingPlan
    {
        public void Add(Dictionary<string, string> data)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                var plan = new DAO.CrowdfundingPlan();
                plan.ID = Guid.NewGuid().ToString();
                plan.ShortAlias = data["ShortAlias"];
                plan.CrowdfundingPlan1 = data["CrowdfundingPlan"];
                plan.CrowdfundingAmount = data["CrowdfundingAmount"];
                plan.Percentage = data["Percentage"];
                plan.Prerelease = data["Prerelease"];
                plan.BegingDate = data["BegingDate"];
                plan.EndDate = data["EndDate"];
                plan.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
                entity.CrowdfundingPlan.Add(plan);
                entity.SaveChanges();
            }
        }

        public List<DAO.CrowdfundingPlan> GetCrowdPlanByID(string ID)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                List<DAO.CrowdfundingPlan> crowdPlanlst = new List<DAO.CrowdfundingPlan>();
                crowdPlanlst = entity.CrowdfundingPlan.Where(c => c.ID == ID).ToList();
                return crowdPlanlst;
            }
        }
    }
}