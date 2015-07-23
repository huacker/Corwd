using System.ServiceModel;
using MulticluehnSolution.EntityModel;

namespace MulticluehnSolution.Contract
{
    [ServiceContract]
    public interface ICrowdfundingPlan
    {
        [OperationContract(IsOneWay = false)]
        string TestGetData(string str);

        [OperationContract(IsOneWay = false)]
        string CrowdfundingPlanGetByID(string ID);

        [OperationContract(IsOneWay = false)]
        void CrowdfundingPlanUpdate(string Crowdmodel);

        [OperationContract(IsOneWay = false)]
        void CrowdfundingPlanAdd(string Crowdmodel);

        [OperationContract(IsOneWay = false)]
        string CrowdfundingPlanGetAll();

        [OperationContract(IsOneWay = false)]
        void CrowdfundingPlanDelete(string ID);
    }
}