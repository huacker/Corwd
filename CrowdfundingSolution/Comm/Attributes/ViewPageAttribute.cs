﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdfundingSolution.Comm.Attributes
{
    /// <summary>
    /// 表示当前Action请求为一个具体的功能页面
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ViewPageAttribute : Attribute
    {
    }
}
