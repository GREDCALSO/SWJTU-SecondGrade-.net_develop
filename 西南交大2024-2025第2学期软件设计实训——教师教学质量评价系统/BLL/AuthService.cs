using EvaluationSystem.Common;
using EvaluationSystem.DAL;
using EvaluationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EvaluationSystem.BLL
{
    // AuthService用于用户身份验证，处理相关逻辑
    internal class AuthService
    {
        public bool Register(string username, string password, string charaNo,string charaname,string collegeNo)
        {
            var Usercontext = new UserContext();
            if (Usercontext.Users.Any(u => u.Username == username))
                return false;

            Usercontext.Users.Add(new User
            {
                Username = username,
                Password = password,
                Chara_No = charaNo
                //Password = HashPassword(password) // 调用了Common层
            });
            // 2. 角色表插入
            if (charaNo.StartsWith("440")) // 学生
            {
                using (var context = new StudentContext())
                {
                    var student = new Student
                    {
                        Name = charaname,
                        Stu_No = charaNo,
                        College_No = collegeNo,
                        is_deleted = 0
                    };
                    context.Students.Add(student);
                    context.SaveChanges();
                    Usercontext.SaveChanges();
                    return true;
                }
            }
            else if (charaNo.StartsWith("660")) // 教师
            {
                using (var context = new TeacherContext())
                {
                    var teacher = new Teacher
                    {
                        Name = charaname,
                        Teacher_No = charaNo,
                        College_No = collegeNo,
                        is_deleted = 0
                    };
                    context.Teachers.Add(teacher);
                    context.SaveChanges();
                    Usercontext.SaveChanges();
                    return true;
                }
            }
            else if (charaNo.StartsWith("990")) // 督导组
            {
                using (var context = new MentorContext())
                {
                    var mentor = new Mentor
                    {
                        Name = charaname,
                        Mentor_No = charaNo,
                        College_No = collegeNo,
                        is_deleted = 0
                    };
                    context.Mentors.Add(mentor);
                    context.SaveChanges();
                    Usercontext.SaveChanges();
                    return true;
                }
            }
            else if (charaNo.StartsWith("128")) // 学院管理员
            {
                using (var context = new AdminContext())
                {
                    var admin = new CollegeAdmin
                    {
                        Name = charaname,
                        admin_No = charaNo,
                        College_No = collegeNo,
                        is_deleted = 0
                    };
                    context.Admins.Add(admin);
                    context.SaveChanges();
                    Usercontext.SaveChanges();
                    return true;
                }
            }
            else
            {
                // 其他角色处理
                return false;
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
