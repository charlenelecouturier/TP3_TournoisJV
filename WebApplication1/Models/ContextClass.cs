using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models


{
    public class ContextClass:DbContext
    {

        public ContextClass() : base("DB")
        {

        }

       
    




        public DbSet<User> Users { get; set; }
        public DbSet<Tournoi> Tournois{ get; set; }
    }
}