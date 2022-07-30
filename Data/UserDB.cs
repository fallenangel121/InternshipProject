using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipProject
{
    internal class UserDb : Microsoft.EntityFrameworkCore.DbContext
    {


        public UserDb()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings

            options.UseMySQL("Server=localhost;uid=root;pwd=;Database=ZOO");
        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }

    }
}
