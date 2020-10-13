﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using userLogin;
//using Microsoft.EntityFrameworkCore;

namespace StudentInfoSystem
{
  public  class StudentInfoContext : DbContext
    {
        public StudentInfoContext() : base(Properties.Settings.Default.DbConnect)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
       
    }
}

