using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DoctorModel
    {
        public static string Check(string name, float temp)
        {
            if (temp >= 36.0 && temp <= 37.2)
            {
                return name + " No fever detected.";
            }
            else if (temp >= 37.3 && temp <= 42.0)
            {
                return name + " Fever detected. See a doctor.";
            }
            else
            {
                return "     ";
            }
            
        }
        public string Name { get; set; }
        public float Temp { get; set; }
    }
}
