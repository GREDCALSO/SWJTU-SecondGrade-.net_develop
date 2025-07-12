using EvaluationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystem.DAL
{
    internal class AdminContext : DbContext
    {
        public AdminContext() : base("name=MySqlConnection") { }

        public DbSet<CollegeAdmin> Admins { get; set; }
    }
}
