﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdfundingSolution.BLLInterface
{
    public interface ICrowdContact
    {
        void ContactAdd(Dictionary<string, string> data);
    }
}
