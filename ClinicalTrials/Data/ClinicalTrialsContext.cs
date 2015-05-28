using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClinicalTrials.Data
{
    public class ClinicalTrialsContext : DbContext
    {
        public ClinicalTrialsContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ClinicalTrialsContext, ClinicalTrialsMigrationsConfiguration>()
                );
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<FormElement> FormElements { get; set; }
        public DbSet<ChildFormElement> ChildFormElements { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<ProtocolFormElementOption> ProtocolFormElementOptions { get; set; }
    }
}