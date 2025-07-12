using EvaluationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystem.DAL
{
    internal class CollegeContext : DbContext
    {
        public CollegeContext() : base("name=MySqlConnection") { }

        public DbSet<College> Colleges { get; set; }
    }
}
