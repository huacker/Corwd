using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulticluehnSolution.WCFClient;
using MulticluehnSolution.Contract;

namespace MulticluehnSolution.Web.App_Start
{
    public  class WCFClientFactory
    {
        public static IServiceFactory ServiceFactory
        {
            get
            {
                //Need to inject dynamic later
                return new RemoteServiceFactory();
            }
        }

        //public static IService Service
        //{
        //    get
        //    {
        //        return this.ServiceFactory.CreateService();
        //    }
        //}
    }
}
