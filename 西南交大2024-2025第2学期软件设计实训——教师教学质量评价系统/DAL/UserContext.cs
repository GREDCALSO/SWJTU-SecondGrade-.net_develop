using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSystem.Models;

namespace EvaluationSystem.DAL
{
    internal class UserContext : DbContext
    {
        public UserContext() : base("name=MySqlConnection") { }
        public DbSet<User> Users { get; set; }
    }
}
