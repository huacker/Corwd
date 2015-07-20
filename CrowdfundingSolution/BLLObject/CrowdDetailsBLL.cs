using System.Collections.Generic;
using System.Data.Entity;
using System;
using CrowdfundingSolution.BLLInterface;


namespace CrowdfundingSolution.BLLObject
{
    public class CrowdDetailsBLL : ICrowdDetails
    {
        public void DetailsAdd(Dictionary<string, string> data)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                var bs = new DAO.Detailed();
                bs.ID = Guid.NewGuid().ToString();
                //bs.BasicID=
                bs.ProjectDetail = data["ProjectDetail"];
                bs.MarketAnalysis = data["MarketAnalysis"];
                bs.EarningsForecast = data["EarningsForecast"];
                bs.RiskControl= data["RiskControl"];
                bs.DevelopmentPlan = data["DevelopmentPlan"];
                bs.CoreCompetition = data["CoreCompetition"];
                bs.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
                entity.Detailed.Add(bs);
                entity.SaveChanges();
            }
        }
    }
}
