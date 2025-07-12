using EvaluationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystem.DAL
{
    internal class StudentContext : DbContext
    {
        public StudentContext() : base("name=MySqlConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}
