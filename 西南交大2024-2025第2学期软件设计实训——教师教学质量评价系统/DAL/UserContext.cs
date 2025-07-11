using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.Models;

namespace 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.DAL
{
    internal class UserContext : DbContext
    {
        public UserContext() : base("name=MySqlConnection") { }
        public DbSet<User> Users { get; set; }
    }
}
