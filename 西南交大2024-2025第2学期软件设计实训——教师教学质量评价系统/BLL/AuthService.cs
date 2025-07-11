using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.DAL;
using 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.Models;
using 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.Common;

namespace 西南交大2024_2025第2学期软件设计实训__教师教学质量评价系统.BLL
{
    internal class AuthService
    {
        public bool Register(string username, string password)
        {
            using (var context = new UserContext())
            {
                if (context.Users.Any(u => u.Username == username))
                    return false;

                context.Users.Add(new User
                {
                    Username = username,
                    Password = password
                    //Password = HashPassword(password) // 调用了Common层
                });
                context.SaveChanges();
                return true;
            }
        }
        public bool Login(string username, string password)
        {
            using (var context = new UserContext())
            {
                return context.Users.Any(u =>
                    u.Username == username &&
                    u.Password == password);
                    //u.Password == HashPassword(password));
            }
        }
    }
}
