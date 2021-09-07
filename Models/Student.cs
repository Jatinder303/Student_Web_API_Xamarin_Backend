using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Web_API_Xamarin_Backend.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Mobile { get; set; }
        public string email { get; set; }
    }
}
