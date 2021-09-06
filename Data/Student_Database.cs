using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Web_API_Xamarin_Backend.Models;

namespace Student_Web_API_Xamarin_Backend.Data
{
    public class Student_Database : DbContext
    {
        public Student_Database (DbContextOptions<Student_Database> options)
            : base(options)
        {
        }

        public DbSet<Student_Web_API_Xamarin_Backend.Models.Student> Student { get; set; }
    }
}
