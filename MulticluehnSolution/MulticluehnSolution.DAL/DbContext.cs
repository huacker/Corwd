using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using MulticluehnSolution.EntityModel;

namespace MulticluehnSolution.DAL
{
    public class DbContext: System.Data.Entity.DbContext
    {
        public DbContext(): base("MyDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        //public DbSet<Album> Album { get; set; }
        //public DbSet<Attachment> Attachment { get; set; }
        //public DbSet<Basic> Basic { get; set; }
        //public DbSet<Contact> Contact { get; set; }
        public DbSet<CrowdfundingPlanEntityModel> CrowdfundingPlanEntityModel { get; set; }
        //public DbSet<Detailed> Detailed { get; set; }
        //public DbSet<ProjectManage> ProjectManage { get; set; }

    }

}
