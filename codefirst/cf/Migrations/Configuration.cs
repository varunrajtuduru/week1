namespace cf.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<cf.Models.Class1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "cf.Models.Class1";
        }

        protected override void Seed(cf.Models.Class1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
