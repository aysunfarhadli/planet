using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                AddData(context);
                RemoveData(context);
                UpdateData(context);
            }
        }

        static void AddData(AppDbContext context)
        {
            var group = new Group { Name = "Mathematics" };
            var student1 = new Student { Name = "Aysun Aliyeva", Group = group };
            var student2 = new Student { Name = "Ayten Farhadli", Group = group };

            context.Groups.Add(group);
            context.Students.Add(student1);
            context.Students.Add(student2);
            context.SaveChanges();
        }

        static void RemoveData(AppDbContext context)
        {
            var student = context.Students.FirstOrDefault(s => s.Name == "Aysun Aliyeva");
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        static void UpdateData(AppDbContext context)
        {
            var student = context.Students.FirstOrDefault(s => s.Name == "Ayten Farhadli");
            if (student != null)
            {
                student.Name = "Ayten Aliyeva";
                context.SaveChanges();
            }
        }
    }
}
