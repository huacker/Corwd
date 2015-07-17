using System.Collections.Generic;
using System.Data.Entity;
using System;
using CrowdfundingSolution.BLLInterface;


namespace CrowdfundingSolution.BLLObject
{
    public class CrowdReleaseBLL : ICrowdRelease
    {
        public void ReleaseAdd(Dictionary<string, string> data)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                var bs = new DAO.Basic();
                bs.ID = Guid.NewGuid().ToString();
                bs.ProjectName = data["ShortAlias"];
                bs.Synopsis = data["CrowdfundingPlan"];
                bs.IndustryID = data["CrowdfundingAmount"];
                bs.AreaID = data["Percentage"];

                entity.Basic.Add(bs);
                entity.SaveChanges();
            }
        }
    }
}
