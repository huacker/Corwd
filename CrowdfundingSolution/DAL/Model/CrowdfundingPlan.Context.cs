﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CrowdfundingSolutionEntities : DbContext
    {
        public CrowdfundingSolutionEntities()
            : base("name=CrowdfundingSolutionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Basic> Basic { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<CrowdfundingPlan> CrowdfundingPlan { get; set; }
        public virtual DbSet<Detailed> Detailed { get; set; }
        public virtual DbSet<ProjectManage> ProjectManage { get; set; }
    }
}
