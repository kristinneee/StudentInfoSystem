using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace userLogin
{

   public class UserContext : DbContext
    {
        public UserContext() : base(Properties.Settings.Default.DbConnect) {
        }
            
            
        public DbSet<User> Users { get; set; }
        //public DbSet<Student> Students { get;set }
        public System.Int32 UserId { get; set; }

    }
}

