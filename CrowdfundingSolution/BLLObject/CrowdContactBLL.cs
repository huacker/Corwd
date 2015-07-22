using System.Collections.Generic;
using System.Data.Entity;
using System;
using CrowdfundingSolution.BLLInterface;

namespace CrowdfundingSolution.BLLObject
{
    public class CrowdContactBLL:ICrowdContact
    {
        public void ContactAdd(Dictionary<string, string> data)
        {
            using (var entity = new DAO.CrowdfundingSolutionEntities())
            {
                var bs = new DAO.Contact();
                bs.ID = Guid.NewGuid().ToString();
                //bs.BasicID = data["BasicID"];
                bs.QQ = data["QQ"];
                bs.PhoneNum = data["PhoneNum"];
                bs.Qqun = data["Qqun"];
                bs.Wqun = data["Wqun"];

                bs.SubmitDate = DateTime.Now.ToString("yyyy-MM-dd");
                entity.Contact.Add(bs);
                entity.SaveChanges();

            }
        }
    }
}
