using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace cf.Models
{
    public class Class1:DbContext
    {
        public Class1() : base("name=Econnection")
        {

        }
        public DbSet<Department> Departmenttable { get; set; }
        public DbSet<Employee> Employeestable { get; set; }

    }
}