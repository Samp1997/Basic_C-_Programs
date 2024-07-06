﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallange
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}

class Program
{
    static void Main(string[] args)
    {

        using (var ctx = new SchoolContext())
        {
            var stud = new Student() { StudentName = "Bill" };

            ctx.Students.Add(stud);
            ctx.SaveChanges();
        }
    }
}
}
