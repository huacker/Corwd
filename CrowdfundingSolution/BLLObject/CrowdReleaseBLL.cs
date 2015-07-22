using System.Collections.Generic;
using System.Data.Entity;
using System;
using CrowdfundingSolution.BLLInterface;
using System.Linq;


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
                bs.ProjectName = data["ProjectName"];
                bs.Synopsis = data["Synopsis"];
                bs.IndustryID = data["Industry"];
                bs.AreaID = data["province"];
                bs.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
                entity.Basic.Add(bs);
                entity.SaveChanges();
            }
        }
        //public async void GetProjectList()//
        //{
        //    List<DAO.Basic> result = new List<DAO.Basic>();
        //    using (var entity = new DAO.CrowdfundingSolutionEntities())
        //    {
                
        //        var prjectList = await entity.Basic.ToListAsync();

        //        foreach (var p in prjectList)
        //        {
        //            result.Add(p);
        //        }
        //    }
        //}

        //public List<DAO.Basic> GetBsaicByID(string ID)
        //{
        //    using (var entity = new DAO.CrowdfundingSolutionEntities())
        //    {
        //        List<DAO.Basic> bs = new List<DAO.Basic>();
        //        bs = entity.Basic.Where(c => c.ID == ID).ToList();
        //        return bs;
        //    }
        //}
        public void BasicInformationAdd(string ID,Dictionary<string, string> data)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                DAO.Basic bs = entity.Basic.Where(c => c.ID == ID).FirstOrDefault();
                bs.Highlight = data["Highlight"];
                bs.Promoter = data["Promoter"];
                bs.Website = data["Website"];
                bs.BusinessProgress = data["BusinessProgress"];
                bs.BaseCity = data["BaseCity"];
                bs.FoundingTime = data["FoundingTime"];
                bs.Tags = data["Tags"];
                //Convert.ToBoolean();
                bs.Stage = data["Stage"];
                bs.IsHaveOther = data["IsHaveOther"];
                bs.CompanyName = data["CompanyName"];
                bs.CompanyAddress = data["CompanyAddress"];
                bs.ShareholderCount = data["ShareholderCount"];
                bs.EmployeesCount = data["EmployeesCount"];
                bs.ProjectDate = data["ProjectDate"];
                entity.SaveChanges();
            }
        }
    }
}
