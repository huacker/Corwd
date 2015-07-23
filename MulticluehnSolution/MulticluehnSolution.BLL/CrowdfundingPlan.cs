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

        public void CrowdfundingPlanAdd(string Crowdmodel)
        {
            CrowdfundingPlanEntityModel model = new CrowdfundingPlanEntityModel();
            model = SerializeHelper.XmlDeserialize<CrowdfundingPlanEntityModel>(Crowdmodel);
            model.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
            dao.Insert<CrowdfundingPlanEntityModel>(model);

        }

        public string CrowdfundingPlanGetByID(string ID)
        {
            CrowdfundingPlanEntityModel model = new CrowdfundingPlanEntityModel();
            model = dao.Find<CrowdfundingPlanEntityModel>(ID);

            List<CrowdfundingPlanEntityModel> lstmodel = dao.FindAll<CrowdfundingPlanEntityModel>();
            return SerializeHelper.XmlSerialize<CrowdfundingPlanEntityModel>(model);
        }

        public void CrowdfundingPlanUpdate(string Crowdmodel)
        {

            CrowdfundingPlanEntityModel model = new CrowdfundingPlanEntityModel();
            model = SerializeHelper.XmlDeserialize<CrowdfundingPlanEntityModel>(Crowdmodel);
            model.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
            dao.Update<CrowdfundingPlanEntityModel>(model);
        }

        public string CrowdfundingPlanGetAll()
        {
            List<CrowdfundingPlanEntityModel> lstmodel = dao.FindAll<CrowdfundingPlanEntityModel>();
            return SerializeHelper.XmlSerialize<List<CrowdfundingPlanEntityModel>>(lstmodel);
        }

        public void CrowdfundingPlanDelete(string ID)
        {
            CrowdfundingPlanEntityModel model = dao.Find<CrowdfundingPlanEntityModel>(ID);
            dao.Delete<CrowdfundingPlanEntityModel>(model);
        }
    }
}
