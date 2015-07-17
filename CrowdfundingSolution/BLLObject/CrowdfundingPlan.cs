using System.Collections.Generic;
using System.Data.Entity;
using CrowdfundingSolution.BLLInterface;
using System;
using System.Threading.Tasks;
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

        public async void GetProjectList()//
        {
            List<DAO.CrowdfundingPlan> result = new List<DAO.CrowdfundingPlan>();
            using ( var entity=new DAO.CrowdfundingSolutionEntities())
            {
                //var prjectList = await (from p in entity.CrowdfundingPlan orderby p.SubmitDate select p);
                var prjectList = await entity.CrowdfundingPlan.ToListAsync();

                foreach (var p in prjectList)
                {
                    result.Add(p);
                }
            }
            //return result;
        }
    }
}