using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulticluehnSolution.EntityModel;
using MulticluehnSolution.IDAL;
using MulticluehnSolution.Contract;
using MulticluehnSolution.Common.WCFExtension;
using MulticluehnSolution.Common.Utility;

namespace MulticluehnSolution.BLL
{
    public class CrowdfundingPlan : IService
    {
        public IDAO dao;

        public CrowdfundingPlan()
        {
            //Need to inject dynamic later
            this.dao = new MulticluehnSolution.DAL.DAO();
        }

        public string TestGetData(string str)
        {
            return "Hello Word!" + str;
        }

        public void CrowdfundingPlanAdd(CrowdfundingPlanEntityModel model)
        {
            dao.Insert<CrowdfundingPlanEntityModel>(model);
        }

        public string GetCrowdPlanByID(string ID)
        {
            CrowdfundingPlanEntityModel model = new CrowdfundingPlanEntityModel();
            model = dao.Find<CrowdfundingPlanEntityModel>(ID);
            return SerializeHelper.XmlSerialize<CrowdfundingPlanEntityModel>(model);
        }

        public void Update(string Crowdmodel)
        {

            CrowdfundingPlanEntityModel model = new CrowdfundingPlanEntityModel();
            model = SerializeHelper.XmlDeserialize<CrowdfundingPlanEntityModel>(Crowdmodel);
            model.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
            dao.Update<CrowdfundingPlanEntityModel>(model);
        }
    }
}
