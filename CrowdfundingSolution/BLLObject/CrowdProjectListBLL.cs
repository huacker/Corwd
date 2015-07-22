using System.Collections.Generic;
using System.Data.Entity;
using System;
using CrowdfundingSolution.BLLInterface;
using System.Linq;
namespace CrowdfundingSolution.BLLObject
{
    public class CrowdProjectListBLL : ICrowdProjectList
    {
        public void CrowdProjectListQuery()
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                DAO.Basic bs = entity.Basic.FirstOrDefault();
                //bs.Highlight = data["Highlight"];
                //bs.Promoter = data["Promoter"];
                //bs.Website = data["Website"];
                //bs.BusinessProgress = data["BusinessProgress"];
                //bs.BaseCity = data["BaseCity"];
                //bs.FoundingTime = data["FoundingTime"];
                //bs.Tags = data["Tags"];
                ////Convert.ToBoolean();
                //bs.Stage = data["Stage"];
                //bs.IsHaveOther = data["IsHaveOther"];
                //bs.CompanyName = data["CompanyName"];
                //bs.CompanyAddress = data["CompanyAddress"];
                //bs.ShareholderCount = data["ShareholderCount"];
                //bs.EmployeesCount = data["EmployeesCount"];
                //bs.ProjectDate = data["ProjectDate"];
                entity.SaveChanges();
            }
        }
    }
}
