using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userLogin
{
  public  class User
    { 
        public System.String name { get; set; }
        public System.String pass { get; set; }
        public System.Int32 number { get; set; }
        public System.Int32? role { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime? activeUntil { get; set; }
       public DbSet<User> Users { get; set; }
        public System.Int32 UserId { get; set; }

    }
}