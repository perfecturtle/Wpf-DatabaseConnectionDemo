using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.NET5Test.Models;

namespace Wpf.NET5Test.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext() : base(PeopleContext.ConnectionString)
        {
            this.Configuration.UseDatabaseNullSemantics = false;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;
        }
        public static string ConnectionString
        {
            get
            {
                //string connString = "Data Source=SQLTESTSVR;Initial Catalog=AaBb;Persist Security Info=True;User ID=sa;Password=abc123@;MultipleActiveResultSets=True;";
                //"data source=sqlserver;Initial Catalog=AaBb;persist security info=True;User ID=sa;Password=abc123@;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient";

                string connString = "Data Source= .\\MYSQLSERVER; Initial Catalog=NewDBSetUp; Integrated Security=True;";
                return connString;
            }
        }
        public DbSet<People> Peoples { get; set; }
    }
}
