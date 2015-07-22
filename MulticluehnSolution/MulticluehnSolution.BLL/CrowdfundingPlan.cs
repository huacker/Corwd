using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulticluehnSolution.EntityModel;
using MulticluehnSolution.IDAL;
using MulticluehnSolution.Contract;
using MulticluehnSolution.Common.WCFExtension;

namespace MulticluehnSolution.BLL
{
    public class CrowdfundingPlan:IService
    {
        public IDAO dao;

        public CrowdfundingPlan()
        {
            //Need to inject dynamic later
            this.dao = new MulticluehnSolution.DAL.DAO();
        }
        public void CrowdfundingPlanAdd(CrowdfundingPlanEntityModel model)
        {
            dao.Insert<CrowdfundingPlanEntityModel>(model);
        }
    }
}
