namespace WaveAccess.Data.Entity.Test.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using WaveAccess.Data.Entity;
    using WaveAccess.Data.Entity.Test.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WaveAccess.Data.Entity.Test.Models.SimpleContext context)
        {
            this.ExecuteSqlScripts(context);
        }
    }
}
