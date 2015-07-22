using System.Collections.Generic;
using System.Data.Entity;
using CrowdfundingSolution.BLLInterface;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace CrowdfundingSolution.BLLObject
{
    public class CrowdfundingPlan : ICrowdfundingPlan
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
            using (var entity = new DAO.CrowdfundingSolutionEntities())
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

        public List<DAO.CrowdfundingPlan> GetCrowdPlanByID(string ID)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                List<DAO.CrowdfundingPlan> crowdPlanlst = new List<DAO.CrowdfundingPlan>();
                crowdPlanlst = entity.CrowdfundingPlan.Where(c => c.ID == ID).ToList();
                return crowdPlanlst;
            }
        }

        public void Update(string ID, Dictionary<string, string> data)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                DAO.CrowdfundingPlan modeNew = entity.CrowdfundingPlan.Where(c => c.ID == ID).FirstOrDefault();
                modeNew.ShortAlias = data["ShortAlias"];
                modeNew.CrowdfundingPlan1 = data["CrowdfundingPlan"];
                modeNew.CrowdfundingAmount = data["CrowdfundingAmount"];
                modeNew.Percentage = data["Percentage"];
                modeNew.Prerelease = data["Prerelease"];
                modeNew.BegingDate = data["BegingDate"];
                modeNew.EndDate = data["EndDate"];
                modeNew.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
                entity.SaveChanges();
            }
        }
    }
}