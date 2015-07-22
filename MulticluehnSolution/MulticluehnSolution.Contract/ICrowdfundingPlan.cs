using System.ServiceModel;
using MulticluehnSolution.EntityModel;

namespace MulticluehnSolution.Contract
{
    [ServiceContract]
    public interface ICrowdfundingPlan
    {
        [OperationContract(IsOneWay = false)]
        void CrowdfundingPlanAdd(CrowdfundingPlanEntityModel model);
    }
}