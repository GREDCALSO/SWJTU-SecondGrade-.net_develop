using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSystem.DAL;
using EvaluationSystem.Models;
using EvaluationSystem.Common;

namespace EvaluationSystem.BLL
{
    // AuthService用于用户身份验证，处理相关逻辑
    internal class AuthService
    {
        public bool Register(string username, string password, string charaNo)
        {
            using (var context = new UserContext())
            {
                if (context.Users.Any(u => u.Username == username))
                    return false;

                context.Users.Add(new User
                {
                    Username = username,
                    Password = password,
                    Chara_No = charaNo
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
