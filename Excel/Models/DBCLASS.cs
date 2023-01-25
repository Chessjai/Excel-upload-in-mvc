using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Excel.Models
{
    public class DBCLASS:DbContext
    {
        public DBCLASS():base("MyConnectionString")
        {

        }
        public DbSet<Student> students { get; set; }
    }
}