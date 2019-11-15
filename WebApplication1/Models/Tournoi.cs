using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Tournoi
    {

        public int id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
