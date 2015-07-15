﻿using System.Data.Entity;
using CrowdfundingSolution.BLLInterface;

namespace CrowdfundingSolution.BLLObject
{
    public class CrowdfundingPlan
    {
        public void Add()
        {
            using (var entity = new DAL.Model.CrowdfundingSolutionEntities())
            {
                var plan = new DAL.Model.CrowdfundingPlan();
                plan.ID = "12321";
                entity.CrowdfundingPlan.Add(plan);
                entity.SaveChanges();
            }
        }
    }
}