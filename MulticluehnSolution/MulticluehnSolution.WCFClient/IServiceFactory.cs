using MulticluehnSolution.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MulticluehnSolution.WCFClient
{
    public interface IServiceFactory
    {
        IService CreateService();
    }
}
