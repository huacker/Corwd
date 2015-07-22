using System;
using System.ServiceModel;

namespace MulticluehnSolution.Contract
{
    [ServiceContract]
    public interface IService:ICrowdfundingPlan
    {
        //[OperationContract(IsOneWay = false)]
        //void DoWork();

    }
}