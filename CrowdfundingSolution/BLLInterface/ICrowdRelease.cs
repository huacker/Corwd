using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdfundingSolution.BLLInterface
{
    public interface ICrowdRelease
    {
         void ReleaseAdd(Dictionary<string,string> data);
         void BasicInformationAdd(string ID,Dictionary<string, string> data);

        //void GetProjectList();

        //List<DAO.Basic> GetBsaicByID(string ID);
    }
}
