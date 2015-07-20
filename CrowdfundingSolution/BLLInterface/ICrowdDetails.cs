using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdfundingSolution.BLLInterface
{
    public interface ICrowdDetails
    {
        void DetailsAdd(Dictionary<string, string>data);
    }
}
