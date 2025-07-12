using EvaluationSystem.DAL;
using EvaluationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystem.BLL
{
    internal class TeacherService
    {
        public bool Register(string charaNo, string name, string collegeNo)
        {
            using (var context = new TeacherContext())
            {
                if (context.Teachers.Any(u => u.Teacher_No == charaNo))
                    return false;

                context.Teachers.Add(new Teacher
                {
                    Name = name,
                    College_No = collegeNo,
                    Teacher_No = charaNo
                    //Password = HashPassword(password) // 调用了Common层
                });
                context.SaveChanges();
                return true;
            }
        }
    }
}
